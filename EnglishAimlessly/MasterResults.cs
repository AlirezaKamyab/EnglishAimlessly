using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnglishAimlessly;

namespace EnglishAimlessly
{
    public partial class MasterResults : Form
    {
        private WordsDictionary dictionary;
        public static List<Word> masteredWords;
        public static List<int> results;
        public MasterResults()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MasterResults_Load(object sender, EventArgs e)
        {
            dictionary = new WordsDictionary();
            dictionary.ReloadList();

            MakeLists();
        }

        private void MakeLists()
        {
            pnlFlowPanel.Controls.Clear();
            for (int i = 0; i < masteredWords.Count; i++)
            {
                ResultItem item = new ResultItem();
                item.Size = new Size(788, 69);
                item.Word = masteredWords[i].Name + " (" + masteredWords[i].Type + ")";
                item.Question = "Question " + (i + 1);
                if(results[i] == 0)
                {
                    item.Indicator = Color.DarkGreen;
                }
                else if(results[i] == 1)
                {
                    item.Indicator = Color.Yellow;
                }
                else
                {
                    item.Indicator = Color.Red;
                }
                item.Left = (this.ClientSize.Width - item.Width) / 2;
                pnlFlowPanel.Controls.Add(item);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < masteredWords.Count; i++)
            {
                Word wrd = masteredWords[i];
                if(results[i] == 1)
                {
                    wrd.Practiced -= 2;
                    dictionary.UpdateWord(masteredWords[i], wrd);
                }
                else if(results[i] == 2)
                {
                    wrd.Practiced -= 4;
                    dictionary.UpdateWord(masteredWords[i], wrd);
                }
            }

            btnUpdateAll.Enabled = false;
            btnUpdateRed.Enabled = false;
            btnYellow.Enabled = false;
        }

        private void btnUpdateRed_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < masteredWords.Count; i++)
            {
                Word wrd = masteredWords[i];
                if (results[i] == 2)
                {
                    wrd.Practiced -= 4;
                    dictionary.UpdateWord(masteredWords[i], wrd);
                }
            }

            btnUpdateAll.Enabled = false;
            btnUpdateRed.Enabled = false;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < masteredWords.Count; i++)
            {
                Word wrd = masteredWords[i];
                if (results[i] == 1)
                {
                    wrd.Practiced -= 2;
                    dictionary.UpdateWord(masteredWords[i], wrd);
                }
            }

            btnUpdateAll.Enabled = false;
            btnYellow.Enabled = false;
        }
    }
}
