using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace EnglishAimlessly
{
    public class Examples : IList<Example>
    {
        private List<Example> _innerList;
        private OleDbConnection _connection;
        public string ConnectionString { get => Properties.Settings.Default.UserDatabaseConnectionString; }
        public Examples()
        {
            _innerList = new List<Example>();
            _connection = new OleDbConnection(ConnectionString);
            Reload();
        }
        public Example this[int index] { get => _innerList[index]; set => _innerList[index] = value; }

        public int Count => _innerList.Count;

        public bool IsReadOnly => false;

        public void Add(Example item)
        {
            try
            {
                string strCommand = "INSERT INTO ExampleList (RelatedId, Example, DateAndTime) VALUES (@RelatedId, @Example, @DateTime);";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                command.Parameters.AddWithValue("@RelatedId", item.RelatedId);
                command.Parameters.AddWithValue("@Example", item.Value);
                command.Parameters.AddWithValue("@DateTime", item.Time.ToString());
                Open();
                command.ExecuteNonQuery();
                Close();
            }
            catch
            {

            }
        }

        public void Clear()
        {
            _innerList.Clear();
        }

        public bool Contains(Example item)
        {
            return _innerList.Contains(item);
        }

        public void CopyTo(Example[] array, int arrayIndex)
        {
            _innerList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Example> GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        public int IndexOf(Example item)
        {
            return _innerList.IndexOf(item);
        }

        public void Insert(int index, Example item)
        {
            _innerList.Insert(index, item);
        }

        public bool Remove(Example item)
        {
            try
            {
                string strCommand = "DELETE FROM ExampleList Where(id = @id)";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                command.Parameters.AddWithValue("@id", item.Id);
                Open();
                command.ExecuteNonQuery();
                Close();
                return _innerList.Remove(item);
            }
            catch
            {
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            this.Remove(_innerList[index]);
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
        public void CommandLine(string cmd)
        {
            Open();
            OleDbCommand command = new OleDbCommand(cmd, _connection);
            command.ExecuteNonQuery();
            Close();
        }
        public void Reload()
        {
            try
            {
                string strCommand = "SELECT * FROM ExampleList";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                Open();
                OleDbDataReader reader = command.ExecuteReader();
                Clear();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Example example = new Example();
                        example.Id = reader.GetInt32(0);
                        example.RelatedId = reader.GetInt32(1);
                        example.Value = reader.GetString(2);
                        example.Time = DateTime.Parse(reader.GetString(3));
                        _innerList.Add(example);
                    }
                }
                Close();
            }
            catch
            {

            }
        }

        public void Update(Example oldExample, Example newExample)
        {
            try
            {
                string strCommand = "UPDATE ExampleList " +
                    "SET (RelatedId = @RelatedID, Example = @Example, DateAndTime = @DateTime) " +
                    "WHERE(id = @id);";
                OleDbCommand command = new OleDbCommand(strCommand, _connection);
                command.Parameters.AddWithValue("@RelatedId", newExample.RelatedId);
                command.Parameters.AddWithValue("@Example", newExample.Value);
                command.Parameters.AddWithValue("@DateTime", newExample.Time.ToString());
                command.Parameters.AddWithValue("@id", oldExample.Value);
                Open();
                command.ExecuteNonQuery();
                Close();
            }
            catch
            {

            }
        }

        public IEnumerable<Example> GetData()
        {
            foreach (Example item in this)
            {
                yield return item;
            }
        }

        public List<Example> FindListByRelatedId(int relatedID)
        {
            List<Example> temp = new List<Example>();
            foreach (Example item in this)
            {
                if(item.RelatedId == relatedID)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        public List<Example> FindListByRelatedDateTime(DateTime dateTime)
        {
            List<Example> temp = new List<Example>();
            foreach (Example item in this)
            {
                if (item.Time.ToLongDateString() == dateTime.ToLongDateString())
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        public Example FindItemById(int Id)
        {
            foreach (Example item in this)
            {
                if (item.Id == Id)
                    return item;
            }
            return new Example();
        }
    }
}
