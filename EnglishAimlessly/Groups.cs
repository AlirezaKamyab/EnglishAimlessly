using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections;

namespace EnglishAimlessly
{
    public class Groups : IList<Group>
    {
        private List<Group> _innerList;
        private OleDbConnection _connection;
        public string ConnectionString { get; set; }
        public Groups()
        {
            ConnectionString = Properties.Settings.Default.DictionaryDatabaseConnectionString;
            _innerList = new List<Group>();
            _connection = new OleDbConnection(ConnectionString);
            Reload();
        }
        public Group this[int index] { get => _innerList[index]; set => _innerList[index] = value; }

        public int Count => _innerList.Count;

        public bool IsReadOnly => false;

        public void Add(Group item)
        {
            try
            {
                string strCommand = "INSERT INTO DictionaryGroups (Name, CreationDate) VALUES (@Name, @CreationDate)";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@CreationDate", item.CreationDate.ToString());

                Open();
                command.ExecuteNonQuery();
                Close();

                Added?.Invoke(null);
                _innerList.Add(item);
            }
            catch(Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            _innerList.Clear();
        }

        public bool Contains(Group item)
        {
            foreach (Group gr in this)
            {
                if(item.Name == gr.Name)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Group[] array, int arrayIndex)
        {
            _innerList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Group> GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        public int IndexOf(Group item)
        {
            return _innerList.IndexOf(item);
        }

        public void Insert(int index, Group item)
        {
            _innerList.Insert(index, item);
        }

        public bool Remove(Group item)
        {
            try
            {
                string strCommand = "DELETE FROM DictionaryGroups WHERE(Id = @Id)";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                command.Parameters.AddWithValue("@Id", item.Id);

                Open();
                command.ExecuteNonQuery();
                Close();

                Deleted?.Invoke(null);
                return _innerList.Remove(item);
            }
            catch
            {
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

        public void Reload()
        {
            try
            {
                string strCommand = "SELECT * FROM DictionaryGroups";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                Open();
                OleDbDataReader reader = command.ExecuteReader();

                _innerList.Clear();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Group group = new Group();
                        group.Id = reader.GetInt32(0);
                        group.Name = reader.GetString(1);
                        group.CreationDate = DateTime.Parse(reader.GetString(2));
                        _innerList.Add(group);
                    }
                }
                Close();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void Update(int id, Group newGroup)
        {
            try
            {
                string strCommand = "UPDATE DictionaryGroups" +
                    " SET Name = @Name, CreationDate = @CreationDate" +
                    " WHERE Id = @Id";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                command.Parameters.AddWithValue("@Name", newGroup.Name);
                command.Parameters.AddWithValue("@CreationDate", newGroup.CreationDate.ToString());
                command.Parameters.AddWithValue("@Id", id);

                Open();
                command.ExecuteNonQuery();
                Close();

                Updated?.Invoke(null, null);

                Reload();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public IEnumerable<Group> GetData()
        {
            foreach (Group item in this)
            {
                yield return item;
            }
        }

        public Group FindById(int Id)
        {
            Reload();
            foreach (Group item in this)
            {
                if(item.Id == Id)
                {
                    return item;
                }
            }

            return new Group(-1, "", DateTime.Now);
        }

        public Group FindByName(string name)
        {
            Reload();
            foreach (Group item in this)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }

            return new Group(-1, "", DateTime.Now);
        }

        public event AddHandler Added;
        public event DeleteHandler Deleted;
        public event UpdateHander Updated;
    }
}
