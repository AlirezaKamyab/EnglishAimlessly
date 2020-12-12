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
    public partial class InspectForm : Form
    {
        public static int Id = 0;
        WordsDictionary wordsDictionary;
        Word word;
        public InspectForm()
        {
            InitializeComponent();
        }

        private void InspectForm_Load(object sender, EventArgs e)
        {
            wordsDictionary = new WordsDictionary();
            wordsDictionary.ReloadList();
            word = LoadWordById();

            lblWord.Text = word.Name + " (" + word.Type.ToString() + ")";
            lblEquivalent.Text = word.Equivalent;
            lblDescription.Text = word.Description;
            lblPracticed.Text = "Practiced: " + word.Practiced.ToString();
            lblTitle.Text = "Inspect #" + Id;
            lblGroup.Text = string.Format("Group: {0}", word.Group);
            if (word.Important)
            {
                lblWord.Text = word.Name + "* (" + word.Type.ToString() + ")";
                lblWord.ForeColor = Color.Red;
            }
        }

        public Word LoadWordById()
        {
            try
            {
                return wordsDictionary.FindById(Id);
            }
            catch
            {
                Close();
                return new Word();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExamples_Click(object sender, EventArgs e)
        {
            ExampleInspection.Id = word.Id;
            ExampleInspection.isAll = false;
            ExampleInspection inspection = new ExampleInspection();
            inspection.Show();
        }
    }
}
