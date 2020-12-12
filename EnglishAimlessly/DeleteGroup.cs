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
    public partial class DeleteGroup : Form
    {
        public static Groups groups;
        public static WordsDictionary words;
        public static int Id = 0;
        private Group group;
        public DeleteGroup()
        {
            InitializeComponent();
        }

        private void DeleteGroup_Load(object sender, EventArgs e)
        {
            groups.Reload();
            group = groups.FindById(Id);
            lblName.Text = "Are you sure you want to delete \"" + group.Name + "\"? All of the words in this group will be removed too!";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                groups.Remove(group);
                words.ReloadList();
                foreach (Word item in words)
                {
                    if (item.Group == group.Name)
                    {
                        words.Remove(item);
                    }
                }

                Close();
            }
            catch
            {
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
