using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly
{
    public class Group
    {
        public Group()
        {

        }
        public Group(string name)
        {
            Name = name;
        }
        public Group(string name, DateTime creationDate) : this(name)
        {
            CreationDate = creationDate;
        }
        public Group(int id, string name, DateTime creationDate) :  this(name, creationDate)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
