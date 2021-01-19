using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly
{
    public class MasterDayDataset : IList<MasterDayItem>
    {
        const string TABLENAME = "MasterWords";
        List<MasterDayItem> _innerList;
        OleDbConnection _connection;
        public MasterDayDataset()
        {
            _connection = new OleDbConnection(Properties.Settings.Default.UserDatabaseConnectionString);
            _innerList = new List<MasterDayItem>();
            CreateTable();
            fetchall();
        }
        public MasterDayItem this[int index] { get => _innerList[index]; set => _innerList[index] = value; }

        public int Count => _innerList.Count;

        public bool IsReadOnly => false;

        public void Add(MasterDayItem item)
        {
            try
            {
                string query = "INSERT INTO " + TABLENAME + " (Slot1, Slot2, Slot3, Slot4, DateAndTime) VALUES (@s1, @s2, @s3, @s4, @date);";
                OleDbCommand cmd = new OleDbCommand(query, _connection);
                cmd.Parameters.AddWithValue("@s1", item.Slot1);
                cmd.Parameters.AddWithValue("@s2", item.Slot2);
                cmd.Parameters.AddWithValue("@s3", item.Slot3);
                cmd.Parameters.AddWithValue("@s4", item.Slot4);
                cmd.Parameters.AddWithValue("@date", item.Date);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();

                _innerList.Add(item);
            }
            catch
            {

            }
        }

        public void Clear()
        {
            _innerList.Clear();
        }

        public bool Contains(MasterDayItem item)
        {
            return _innerList.Contains(item);
        }

        public void CopyTo(MasterDayItem[] array, int arrayIndex)
        {
            _innerList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MasterDayItem> GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        public int IndexOf(MasterDayItem item)
        {
            return _innerList.IndexOf(item);
        }

        public void Insert(int index, MasterDayItem item)
        {
            _innerList.Insert(index, item);
        }

        public bool Remove(MasterDayItem item)
        {
            try
            {
                bool result = _innerList.Remove(item);

                if (!result) return result;

                string query = "DELETE FROM " + TABLENAME + " WHERE (id = @id)";
                OleDbCommand cmd = new OleDbCommand(query, _connection);
                cmd.Parameters.AddWithValue("@id", item.Id);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();

                return result;
            }
            catch
            {
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            _innerList.Remove(_innerList[index]);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        private void Open()
        {
            _connection.Open();
        }

        private void Close()
        {
            _connection.Close();
        }

        public void fetchall()
        {
            try
            {
                string query = "SELECT id, Slot1, Slot2, Slot3, Slot4, DateAndTime FROM " + TABLENAME;
                OleDbCommand cmd = new OleDbCommand(query, _connection);
                Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MasterDayItem item = new MasterDayItem();
                        item.Id = reader.GetInt32(0);
                        item.Slot1 = reader.GetInt32(1);
                        item.Slot2 = reader.GetInt32(2);
                        item.Slot3 = reader.GetInt32(3);
                        item.Slot4 = reader.GetInt32(4);
                        item.Date = reader.GetString(5);

                        _innerList.Add(item);
                    }
                }

                reader.Close();
                Close();
            }
            catch
            {
                
            }
            finally
            {
                Close();
            }
        }

        public bool isExistsInDate(string date)
        {
            foreach (MasterDayItem item in this)
            {
                if(item.Date == date)
                {
                    return true;
                }
            }
            return false;
        }

        public List<MasterDayItem> fetchFromDate(string date)
        {
            List<MasterDayItem> temp = new List<MasterDayItem>();
            foreach (MasterDayItem item in this)
            {
                if(item.Date == date)
                {
                    temp.Add(item);
                }
            }

            return temp;
        }

        public MasterDayItem fetchById(long id)
        {
            foreach (MasterDayItem item in this)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }

            return new MasterDayItem();
        }

        private void CreateTable()
        {
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                string query = "CREATE TABLE " + TABLENAME + "(" +
                    "Id INT NOT NULL IDENTITY(1,1), " +
                    "Slot1 int, " +
                    "Slot2 int, " +
                    "Slot3 int, " +
                    "Slot4 int, " +
                    "DateAndTime text, " +
                    "PRIMARY KEY(Id)" +
                    ");";
                cmd = new OleDbCommand(query, _connection);
                Open();
                cmd.ExecuteNonQuery();
                Close();
            }
            catch
            {
                //System.Windows.Forms.MessageBox.Show("Update Failed\n" + ex.Message, "Error");
                cmd.Dispose();
                Close();
            }
            finally
            {
                Close();
            }
        }
    }
}
