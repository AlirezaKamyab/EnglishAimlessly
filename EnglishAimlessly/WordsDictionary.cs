using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Net;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace EnglishAimlessly
{
    public class WordsDictionary : IList<Word>
    {
        private OleDbConnection _connection;
        public string ConnectionString { get; set; }
        private List<Word> _innerList;
        public WordsDictionary()
        {
            _innerList = new List<Word>();
            ConnectionString = Properties.Settings.Default.DictionaryDatabaseConnectionString;
            _connection = new OleDbConnection(ConnectionString);
        }
        public Word this[int index] { get => _innerList[index]; set => _innerList[index] = value; }

        public int Count => _innerList.Count;

        public bool IsReadOnly => false;

        public void Add(Word item)
        {
            try
            {
                string strCommand = "INSERT INTO Dictionary (Word, Type, Equivalent, Description, Practiced, Important, GroupName) VALUES (" +
                    "@Word, @Type, @Equivalent, @Description, @Practiced, @Important, @GroupName);";
                OleDbCommand cmd = new OleDbCommand(strCommand, _connection);
                cmd.Parameters.AddWithValue("@Word", item.Name);
                cmd.Parameters.AddWithValue("@Type", item.Type.ToString());
                cmd.Parameters.AddWithValue("@Equivalent", item.Equivalent);
                cmd.Parameters.AddWithValue("@Description", item.Description);
                cmd.Parameters.AddWithValue("@Practiced", item.Practiced);
                cmd.Parameters.AddWithValue("@Important", item.Important);
                cmd.Parameters.AddWithValue("@GroupName", item.Group);
                Open();
                cmd.ExecuteNonQuery();
                Close();

                _innerList.Add(item);
                Added?.Invoke(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on adding item");
            }
        }

        public void Clear()
        {
            _innerList.Clear();
        }

        public bool Contains(Word item)
        {
            return _innerList.Contains(item);
        }

        public void CopyTo(Word[] array, int arrayIndex)
        {
            _innerList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Word> GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        public int IndexOf(Word item)
        {
            return _innerList.IndexOf(item);
        }

        public void Insert(int index, Word item)
        {
            _innerList.Insert(index, item);
        }

        public bool Remove(Word item)
        {
            try
            {
                string strCommand = "DELETE FROM Dictionary WHERE (ID = @Id);";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                command.Parameters.AddWithValue("@Id", item.Id);
                Open();
                command.ExecuteNonQuery();
                Close();

                Deleted?.Invoke(item);
                return _innerList.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on deleting item");
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            Remove(_innerList[index]);
        }

        public void RemoveAll()
        {
            foreach (Word item in this)
            {
                DatabaseRemove(item);
            }
            ReloadList();
        }

        private void DatabaseRemove(Word item)
        {
            try
            {
                string strCommand = "DELETE FROM Dictionary WHERE (ID = @Id);";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                command.Parameters.AddWithValue("@Id", item.Id);
                Open();
                command.ExecuteNonQuery();
                Close();
            }
            catch
            {

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        public void Open()
        {
            try
            {
                _connection.Open();
            }
            catch
            {

            }
        }

        public void Close()
        {
            try
            {
                _connection.Close();
            }
            catch
            {

            }
        }

        public IEnumerable<Word> GetData()
        {
            string strCommand = "SELECT * FROM Dictionary";
            OleDbCommand command = new OleDbCommand(strCommand, _connection);
            Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Word word = new Word();
                    word.Id = reader.GetInt32(0);
                    word.Name = reader.GetString(1);
                    word.Type = Word.ToWordType(reader.GetString(2));
                    word.Equivalent = reader.GetString(3);
                    word.Description = reader.GetString(4);
                    word.Practiced = reader.GetInt32(5);
                    word.Important = reader.GetBoolean(6);
                    word.Group = reader.GetString(7);
                    yield return word;
                }
            }
            Close();
        }

        public void ReloadList()
        {
            _innerList.Clear();
            foreach (Word item in GetData())
            {
                _innerList.Add(item);
            }
        }

        public Word FindById(int id)
        {
            foreach (Word item in this)
            {
                if(item.Id == id)
                {
                    return item;
                }          
            }
            return new Word(-1, "", Word.WordType.noun, "", "", 0, false, "");
        }

        public int MinPracticedNumber()
        {
            int number = int.MaxValue;
            foreach (Word item in this)
            {
                if(number > item.Practiced)
                {
                    number = item.Practiced;
                }
            }
            if (number == int.MaxValue)
                number = 0;
            return number;
        }

        public int MaxPracticedNumber()
        {
            int number = 0;
            foreach (Word item in this)
            {
                if (number < item.Practiced)
                {
                    number = item.Practiced;
                }
            }

            return number;
        }

        public int NotPracticedCount()
        {
            int number = 0;
            foreach (Word item in this)
            {
                if (item.Practiced == 0)
                {
                    number += 1;
                }
            }

            return number;
        }

        public void UpdateWord(Word originalWord, Word newWord)
        {
            try
            {
                string strCommand = "UPDATE Dictionary" +
                    " SET Word = @Word, Type = @Type, Equivalent = @Equivalent, Description = @Description, Practiced = @Practiced, " +
                    "Important = @Important, GroupName = @GroupName" +
                    " WHERE ID = @Id";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                command.Parameters.AddWithValue("@Word", newWord.Name);
                command.Parameters.AddWithValue("@Type", newWord.Type.ToString());
                command.Parameters.AddWithValue("@Equivalent", newWord.Equivalent);
                command.Parameters.AddWithValue("@Description", newWord.Description);
                command.Parameters.AddWithValue("@Practiced", newWord.Practiced);
                command.Parameters.AddWithValue("@Important", newWord.Important);
                command.Parameters.AddWithValue("@GroupName", newWord.Group);
                command.Parameters.AddWithValue("@Id", originalWord.Id);
                Open();
                command.ExecuteNonQuery();
                Close();

                ReloadList();
                Updated?.Invoke(originalWord, newWord);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on updating database");
            }
        }

        public List<Word> FindItemsByGroupName(string group)
        {
            List<Word> temp = new List<Word>();
            foreach (Word item in this)
            {
                if(item.Group == group)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        public void LoadDictionaryFilteredByGroupName(string group)
        {
            _innerList.Clear();
            foreach (Word item in GetData())
            {
                if(item.Group == group.Trim())
                {
                    _innerList.Add(item);
                }
            }
        }

        public List<Word> FilterByPracticedNumber(int number, int max, bool random = false)
        {
            List<Word> temp = new List<Word>();
            int counter = 0;
            foreach (Word item in this)
            {
                if(item.Practiced >= number)
                {
                    temp.Add(item);
                    counter++;
                }

                if(counter >= max)
                {
                    break;
                }
            }
            Shuffle<Word>(temp);
            return temp;
        }

        public void CommandLine(string strCommand)
        {
            Open();
            OleDbCommand command = new OleDbCommand(strCommand, _connection);
            command.ExecuteNonQuery();
            Close();
        }

        private void Shuffle<T>(IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public event AddHandler Added;
        public event DeleteHandler Deleted;
        public event UpdateHander Updated;
    }
    public delegate void AddHandler(Word word);
    public delegate void DeleteHandler(Word word);
    public delegate void UpdateHander(Word oldWord, Word newWord);
}
