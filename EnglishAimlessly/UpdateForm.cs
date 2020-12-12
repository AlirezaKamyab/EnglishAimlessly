using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAimlessly
{
    public partial class UpdateForm : Form
    {
        public static int Id = 0;
        public static WordsDictionary wordsDictionary;
        private Groups groups;
        UserDictionary userDic;
        Word word;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            word = new Word();
            groups = new Groups(); //This class updates its list automatically, no need for calling reload function

            comboType.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Word.WordType)))
            {
                comboType.Items.Add(item.ToString());
            }
            try
            {
                userDic = new UserDictionary();
                word = wordsDictionary.FindById(Id);
                userDic.ReloadList();
                lblTitle.Text = "Update #" + Id;

                txtWord.Text = word.Name;
                txtDescription.Text = word.Description;
                txtEquivalent.Text = word.Equivalent;
                comboType.Text = word.Type.ToString();
                checkImportant.Checked = word.Important;
                comboGroup.Text = word.Group;
            }
            catch
            {
                MessageBox.Show("Could not find any word by the Id " + Id, "Error on update form");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Word newWord = new Word();
            newWord.Id = Id;
            newWord.Name = txtWord.Text;
            newWord.Type = Word.ToWordType(comboType.Text);
            newWord.Equivalent = txtEquivalent.Text;
            newWord.Description = txtDescription.Text;
            newWord.Important = checkImportant.Checked;
            newWord.Practiced = word.Practiced;
            newWord.Group = comboGroup.Text;
            if (groups.Contains(new Group(word.Group, DateTime.Now)))
            {
                wordsDictionary.UpdateWord(word, newWord);
                foreach (UserWord item in userDic.FindUserWordByRelatedID(Id))
                {
                    newWord.Practiced = item.Practiced;
                    userDic.UpdateWord(item, new UserWord(newWord, item.PracticedDateTime, word.Id));
                }
                Close();
            }
            else
            {
                MessageBox.Show("Please select a group", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
