using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAimlessly
{
    public partial class UpdateGroup : Form
    {
        public static Groups groups;
        public static WordsDictionary words;
        public static int Id = 0;
        Group group;
        bool isOk = false;
        public UpdateGroup()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isOk)
            {
                if (groups.Contains(new Group(txtName.Text.Trim(), DateTime.Now)) == false)
                {
                    Group newgroup = new Group();
                    newgroup.Name = txtName.Text.Trim();
                    newgroup.CreationDate = group.CreationDate;
                    newgroup.Id = group.Id;
                    groups.Update(Id, newgroup);

                    words.ReloadList();
                    int counter = 0;
                    while (counter < words.Count)
                    {
                        if (words[counter].Group == group.Name)
                        {
                            words.UpdateWord(words[counter], new Word(words[counter].Name, words[counter].Type, words[counter].Equivalent, words[counter].Description, words[counter].Practiced, words[counter].Important, newgroup.Name));
                        }
                        counter++;
                    }

                    Close();
                }
                else
                {
                    lblHint.Text = "This name is existed!";
                    lblHint.ForeColor = Color.Red;
                }
            }
            else
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateGroup_Load(object sender, EventArgs e)
        {
            groups.Reload();
            group = groups.FindById(Id);
            txtName.Text = group.Name;
            lblperviousName.Text = string.Format("You are about to change the name of dictionary group from \"{0}\"; All of the words in this group, will be transf" +
                "ered to the new group",group.Name);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                lblHint.Text = "Name should contain at least 3 characters";
                lblHint.ForeColor = Color.Red;
                isOk = false;
            }
            else if (groups.Contains(new Group(txtName.Text.Trim())))
            {
                lblHint.Text = "This name is existed!";
                lblHint.ForeColor = Color.Red;
                isOk = false;
            }
            else if (txtName.Text == "*All*")
            {
                lblHint.Text = "This is somewhat a keyword to us; choose another name;";
                lblHint.ForeColor = Color.Red;
                isOk = false;
            }
            else
            {
                lblHint.Text = "You are good to go";
                lblHint.ForeColor = Color.DarkGreen;
                isOk = true;
            }
        }
    }
}
