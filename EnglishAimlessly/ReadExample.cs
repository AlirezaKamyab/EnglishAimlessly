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
    public partial class ReadExample : Form
    {
        private WordsDictionary wordDictionary;
        private UserDictionary userDictionary;
        private Examples examples;
        public static int Id = 0;
        public ReadExample()
        {
            InitializeComponent();
        }

        private void ReadExample_Load(object sender, EventArgs e)
        {
            wordDictionary = new WordsDictionary();
            userDictionary = new UserDictionary();
            examples = new Examples(); //This will load the list automatically, so no need for calling any reload function

            wordDictionary.ReloadList();
            userDictionary.ReloadList();

            Example example = examples.FindItemById(Id);
            lblDateTime.Text = example.Time.ToShortDateString();
            lblExample.Text = example.Value;

            if (lblExample.Text.Trim() == string.Empty)
            {
                lblExample.Text = "No record found";
                lblExample.ForeColor = Color.Red;
            }

            Word word = wordDictionary.FindById(example.RelatedId);
            lblWord.Text = word.Name + " (" + word.Type + ")";
            if (word.Id < 0)
            {
                lblWord.Text = "Not Found";
                lblWord.ForeColor = Color.Red;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Are you willing to delete this example?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (re == DialogResult.Yes)
            {
                Example example = new Example();
                example.Id = Id;
                examples.Remove(example);
                Close();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
