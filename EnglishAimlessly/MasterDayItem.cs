using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly
{
    public class MasterDayItem
    {
        private long _id = 0;
        private int _slot1;
        private int _slot2;
        private int _slot3;
        private int _slot4;
        private string _date;

        public MasterDayItem()
        {

        }

        public MasterDayItem(long id, int s1, int s2, int s3, int s4, string date)
        {
            Id = id;
            Slot1 = s1;
            Slot2 = s2;
            Slot3 = s3;
            Slot4 = s4;
            Date = date;
        }

        public MasterDayItem(int s1, int s2, int s3, int s4, string date) : this(0, s1, s2, s3, s4, date)
        {
        }

        public long Id { get { return _id; } set { _id = value; } }
        public int Slot1 { get { return _slot1; } set { _slot1 = value; } }
        public int Slot2 { get { return _slot2; } set { _slot2 = value; } }
        public int Slot3 { get { return _slot3; } set { _slot3 = value; } }
        public int Slot4 { get { return _slot4; } set { _slot4 = value; } }
        public string Date { get { return _date; } set { _date = value; } }
    }
}
