using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly
{
    public static class User
    {
        private static int _exp = 0;
        public static string Name { get; set; }
        public static int Level { get; set; } = 1;
        public static int EXP
        {
            get
            {
                return _exp;
            }
            set
            {
                _exp = value;
                while(_exp >= 1000)
                {
                    _exp -= 1000;
                    Level++;
                }
            }
        }
    }
}
