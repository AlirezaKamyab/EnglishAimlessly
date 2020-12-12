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
    public partial class AddGroup : Form
    {
        public static Groups groups;
        bool isOk = false;
        public AddGroup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            //groups = new Groups(); // This class will reload its list automatically, no need to call reload
            groups.Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isOk)
            {
                if (groups.Contains(new Group(txtName.Text.Trim(), DateTime.Now)) == false)
                {
                    Group group = new Group();
                    group.Name = txtName.Text.Trim();
                    group.CreationDate = DateTime.Now;
                    groups.Add(group);
                    groups.Reload();
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                lblHint.Text = "Name should contain at least 3 characters";
                lblHint.ForeColor = Color.Red;
                isOk = false;
            }
            else if(groups.Contains(new Group(txtName.Text.Trim())))
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
