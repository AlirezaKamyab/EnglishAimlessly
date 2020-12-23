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
    public partial class Editor : Form
    {
        public static string code = "";
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            txtCode.Text = code;
            txtCode.AcceptsTab = true;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            code = txtCode.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
