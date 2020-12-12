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
    public partial class Activator : Form
    {
        public Activator()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Code = txtCode.Text;
            Properties.Settings.Default.Save();
            if(Properties.Settings.Default.Code == Properties.Settings.Default.ActivitionCode)
            {
                lblStatue.ForeColor = Color.DarkGreen;
                lblStatue.Text = "Program is activated.";
            }
            else
            {
                lblStatue.ForeColor = Color.Red;
                lblStatue.Text = "Activition code is not correct";
            }
        }

        private void Activator_Load(object sender, EventArgs e)
        {
            txtCode.Text = Properties.Settings.Default.Code;
        }
    }
}
