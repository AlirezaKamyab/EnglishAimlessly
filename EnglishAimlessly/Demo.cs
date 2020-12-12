using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAimlessly
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }
        WordsDictionary dic = new WordsDictionary();
        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            UserWord word = new UserWord();
            word.Name = "Predominent";
            word.Type = UserWord.WordType.adj;
            word.Equivalent = "Obvious";
            word.Description = "When something is very clear and important that is noticable";
            word.Practiced = 0;
            word.Important = true;
            dic.Add(word);
            MessageBox.Show("Done","Hooray");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dic.ReloadList();
            foreach (UserWord item in dic)
            {
                MessageBox.Show(item.ToString(), "#" + item.Id);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dic.RemoveAt(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DictionaryManger manger = new DictionaryManger();
            manger.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastPractice = new DateTime(2005, 10, 25, 12, 30, 59);
            Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ATime atime = new ATime();
            label1.Text = string.Format("Years {0}\n" +
                "months {1}\n" +
                "days {2}\n" +
                "hours {3}\n" +
                "minutes {4}\n" +
                "seconds {5}", atime.Years, atime.Months, atime.Days, atime.Hours, atime.Minutes, atime.Seconds);
        }
    }
}
