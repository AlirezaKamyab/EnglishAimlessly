using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly
{
    public class UserWord : Word
    {
        public UserWord()
        {

        }
        public UserWord(Word word, int relatedId) : base(word)
        {
            RelatedID = relatedId;
        }
        public UserWord(Word word, DateTime PracticedTime, int relatedId) : base(word)
        {
            PracticedDateTime = PracticedTime;
            RelatedID = relatedId;
        }

        public DateTime PracticedDateTime { get; set; }
        public int RelatedID { get; set; }
    }
}
