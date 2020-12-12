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
    public partial class DeleteForm : Form
    {
        public static int Id = 0;
        public static WordsDictionary wordsDictionary;
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        Word word;
        private void DeleteForm_Load(object sender, EventArgs e)
        {
            word = wordsDictionary.FindById(Id);
            lblInfo.Text = string.Format("Are you sure you want to remove *{0}* from the database premenantly?\n The word is practiced {1} time(s)", 
                word.Name, word.Practiced);
            lblTitle.Text = string.Format("Delete #{0}", word.Id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                wordsDictionary.Remove(word);
                Close();
            }
            catch
            {
                Close();
            }
        }
    }
}
