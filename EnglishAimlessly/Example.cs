using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly
{
    public class Example
    {
        public Example()
        {

        }
        public Example(int relatedId, string value, DateTime dateTime)
        {
            RelatedId = relatedId;
            Value = value;
            Time = dateTime;
        }
        public Example(int id, int relatedId, string value, DateTime dateTime ) : this(relatedId, value, dateTime)
        {
            Id = id;
        }
        public int Id { get; set; }
        public int RelatedId { get; set; }
        public string Value { get; set; }
        public DateTime Time { get; set; }
    }
}
