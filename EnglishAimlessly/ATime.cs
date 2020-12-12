using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAimlessly
{
    public class ATime
    {
        private DateTime _dateTime;
        public ATime()
        {
            _dateTime = DateTime.Now;
            LastPractice = Properties.Settings.Default.LastPractice;
        }
        public int TotalMiliseconds { get => getTotalMiliseconds(); }
        public int Seconds { get => CountSeconds(); }
        public int TotalSeconds { get => getTotalSeconds(); }
        public int Minutes { get { return CountMinutes(); } }
        public int TotalMinutes { get => getTotalMinutes(); }
        public int Hours { get { return CountHours(); } }
        public int TotalHours { get => getTotalHours(); }
        public int Days { get { return CountDays(); } }

        /// <summary>
        /// Does not word properly; Needs update
        /// </summary>
        public int Months { get { return CountMonths(); } }

        /// <summary>
        /// Does not work properly; Needs update
        /// </summary>
        public int Years { get { return CountYears(); } }
        public DateTime LastPractice { get; set; }

        private int CountDays()
        {
            _dateTime = DateTime.Now;
            TimeSpan duration = _dateTime.Subtract(Properties.Settings.Default.LastPractice);
            int days = duration.Hours / 24;
            return days;
        }

        private int CountMonths()
        {
            _dateTime = DateTime.Now;
            int count = 0;
            int year = Properties.Settings.Default.LastPractice.Year;
            int month = Properties.Settings.Default.LastPractice.Month;
            int day = Properties.Settings.Default.LastPractice.Day;
            while (year < _dateTime.Year || month < _dateTime.Month || day < _dateTime.Day)
            {
                if (day == DateTime.DaysInMonth(year, month))
                {
                    day = 1;
                    if (month == 12)
                    {
                        month = 1;
                        year++;
                    }
                    else
                    {
                        month++;
                    }
                    count++;
                }
                else
                {
                    day += 1;
                }
            }

            return count;
        }

        private int CountYears()
        {
            _dateTime = DateTime.Now;
            int count = 0;
            int year = Properties.Settings.Default.LastPractice.Year;
            int month = Properties.Settings.Default.LastPractice.Month;
            int day = Properties.Settings.Default.LastPractice.Day;
            while (year < _dateTime.Year || month < _dateTime.Month || day < _dateTime.Day)
            {
                if (day == DateTime.DaysInMonth(year, month))
                {
                    day = 1;
                    if (month == 12)
                    {
                        month = 1;
                        year++;
                        count++;
                    }
                    else
                    {
                        month++;
                    }
                }
                else
                {
                    day += 1;
                }
            }

            return count;
        }

        private int CountHours()
        {
            _dateTime = DateTime.Now;
            TimeSpan duration = _dateTime.Subtract(Properties.Settings.Default.LastPractice);
            return duration.Hours;
        }

        private int CountMinutes()
        {
            _dateTime = DateTime.Now;
            TimeSpan duration = _dateTime.Subtract(Properties.Settings.Default.LastPractice);
            return duration.Minutes;
        }

        private int CountSeconds()
        {
            _dateTime = DateTime.Now;
            TimeSpan duration = _dateTime.Subtract(Properties.Settings.Default.LastPractice);
            return duration.Seconds;
        }

        private int getTotalMiliseconds()
        {
            _dateTime = DateTime.Now;
            TimeSpan duration = _dateTime.Subtract(Properties.Settings.Default.LastPractice);
            return (int)duration.TotalMilliseconds;
        }

        private int getTotalHours()
        {
            _dateTime = DateTime.Now;
            TimeSpan duration = _dateTime.Subtract(Properties.Settings.Default.LastPractice);
            return (int)duration.TotalHours;
        }

        private int getTotalMinutes()
        {
            _dateTime = DateTime.Now;
            TimeSpan duration = _dateTime.Subtract(Properties.Settings.Default.LastPractice);
            return (int)duration.TotalMinutes;
        }

        private int getTotalSeconds()
        {
            _dateTime = DateTime.Now;
            TimeSpan duration = _dateTime.Subtract(Properties.Settings.Default.LastPractice);
            return (int)duration.TotalSeconds;
        }

    }
}
