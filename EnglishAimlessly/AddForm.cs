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
    public partial class AddForm : Form
    {
        public static WordsDictionary wordsDictionary;
        public static string groupName = "";
        private Groups groups;
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserWord word = new UserWord();

            word.Name = txtWord.Text;
            word.Type = UserWord.ToWordType(comboType.Text);
            word.Equivalent = txtEquivalent.Text;
            word.Description = txtDescription.Text;
            word.Important = checkImportant.Checked;
            word.Practiced = 0;
            word.Group = comboGroup.Text;
            if (groups.Contains(new Group(word.Group, DateTime.Now)))
            {
                wordsDictionary.Add(word);
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

        private void AddForm_Load(object sender, EventArgs e)
        {
            Word word = new Word();
            groups = new Groups(); // this class reloads its list in the constructor; no need to recall reload function
            try
            {
                comboGroup.Text = groupName;
            }
            catch
            {

            }

            comboType.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Word.WordType)))
            {
                comboType.Items.Add(item.ToString());
            }

            comboGroup.Items.Clear();

            foreach (Group item in groups)
            {
                comboGroup.Items.Add(item.Name);
            }
        }
    }
}
