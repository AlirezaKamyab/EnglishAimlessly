using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace EnglishAimlessly
{
    public class UserDictionary : IList<UserWord>
    {
        private List<UserWord> _innerList;
        private OleDbConnection _connection;
        public UserDictionary()
        {
            _innerList = new List<UserWord>();
            ConnectionString = Properties.Settings.Default.UserDatabaseConnectionString;
            _connection = new OleDbConnection(ConnectionString);
        }
        public string ConnectionString { get; set; }
        public UserWord this[int index] { get => _innerList[index]; set => _innerList[index] = value; }

        public int Count => _innerList.Count();

        public bool IsReadOnly => false;

        public void Add(UserWord item)
        {
            try
            {
                string strCommand = "INSERT INTO UserData (Word, Type, Equivalent, Description, Practiced, LastPractice, RelatedID) VALUES (" +
                    "@Word, @Type, @Equivalent, @Description, @Practiced, @LastPractice, @RelatedID);";
                OleDbCommand cmd = new OleDbCommand(strCommand, _connection);
                cmd.Parameters.AddWithValue("@Word", item.Name);
                cmd.Parameters.AddWithValue("@Type", item.Type.ToString());
                cmd.Parameters.AddWithValue("@Equivalent", item.Equivalent);
                cmd.Parameters.AddWithValue("@Description", item.Description);
                cmd.Parameters.AddWithValue("@Practiced", item.Practiced);
                cmd.Parameters.AddWithValue("@LastPractice", item.PracticedDateTime.ToString());
                cmd.Parameters.AddWithValue("@RelatedID", item.RelatedID);
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

        public bool Contains(UserWord item)
        {
            return _innerList.Contains(item);
        }

        public void CopyTo(UserWord[] array, int arrayIndex)
        {
            _innerList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<UserWord> GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        public int IndexOf(UserWord item)
        {
            return _innerList.IndexOf(item);
        }

        public void Insert(int index, UserWord item)
        {
            _innerList.Insert(index, item);
        }

        public bool Remove(UserWord item)
        {
            try
            {
                string strCommand = "DELETE FROM UserData WHERE (ID = @Id);";
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        private void Open()
        {
            try
            {
                _connection.Open();
            }
            catch
            {

            }
        }

        private void Close()
        {
            try
            {
                _connection.Close();
            }
            catch
            {

            }
        }

        public IEnumerable<UserWord> GetData()
        {
            string strCommand = "SELECT * FROM UserData";
            OleDbCommand command = new OleDbCommand(strCommand, _connection);
            Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UserWord userWord = new UserWord
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Type = Word.ToWordType(reader.GetString(2)),
                        Equivalent = reader.GetString(3),
                        Description = reader.GetString(4),
                        Practiced = reader.GetInt32(5),
                        PracticedDateTime = DateTime.Parse(reader.GetString(6)),
                        RelatedID = reader.GetInt32(7)
                    };
                    yield return userWord;
                }
            }
            Close();
        }

        public void ReloadList()
        {
            _innerList.Clear();
            foreach (UserWord item in GetData())
            {
                _innerList.Add(item);
            }
        }

        public List<UserWord> FilterByDateTime(DateTime dateTime)
        {
            List<UserWord> temp = new List<UserWord>();
            foreach (UserWord item in this)
            {
                if (dateTime.ToLongDateString() == item.PracticedDateTime.ToLongDateString())
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        public void UpdateWord(UserWord originalWord, UserWord newWord)
        {
            try
            {
                string strCommand = "UPDATE UserData" +
                    " SET Word = @Word, Type = @Type, Equivalent = @Equivalent, Description = @Description, Practiced = @Practiced, " +
                    "LastPractice = @LastPractice, RelatedID = @RelatedID " +
                    "WhERE ID = @Id";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                command.Parameters.AddWithValue("@Word", newWord.Name);
                command.Parameters.AddWithValue("@Type", newWord.Type.ToString());
                command.Parameters.AddWithValue("@Equivalent", newWord.Equivalent);
                command.Parameters.AddWithValue("@Description", newWord.Description);
                command.Parameters.AddWithValue("@Practiced", newWord.Practiced);
                command.Parameters.AddWithValue("@LastPractice", newWord.PracticedDateTime.ToString());
                command.Parameters.AddWithValue("@RelatedID", newWord.RelatedID);
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
        public List<UserWord> FindUserWordByRelatedID(int relatedID)
        {
            List<UserWord> temp = new List<UserWord>();
            foreach (UserWord item in _innerList)
            {
                if(item.RelatedID == relatedID)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        public void CommandLine(string strCommand)
        {
            Open();
            OleDbCommand command = new OleDbCommand(strCommand, _connection);
            command.ExecuteNonQuery();
            Close();
        }
        public event AddHandler Added;
        public event DeleteHandler Deleted;
        public event UpdateHander Updated;
    }
}
