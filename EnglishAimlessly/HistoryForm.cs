using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EnglishAimlessly
{
    public partial class HistoryForm : Form
    {
        WordsDictionary wordsDictionary;
        UserDictionary userDictionary;
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            wordsDictionary = new WordsDictionary();
            userDictionary = new UserDictionary();
            wordsDictionary.ReloadList();
            userDictionary.ReloadList();

            LoadList(userDictionary.FilterByDateTime(dateTime.Value));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                InspectForm inspect = new InspectForm();
                InspectForm.Id = int.Parse(button.Name);
                inspect.Show();
            }
            catch
            {
                MessageBox.Show("The word is not existed", "Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            LoadList(userDictionary.FilterByDateTime(dateTime.Value));
        }

        private void LoadList(List<UserWord> userlist)
        {
            flowPanel.Controls.Clear();
            wordsDictionary.ReloadList();
            userDictionary.ReloadList();

            foreach (UserWord item in userlist)
            {
                Button button = new Button();
                button.Name = item.RelatedID.ToString();
                button.FlatStyle = FlatStyle.Flat;
                button.Text = item.Name + " (" + item.Type + ")     " + item.PracticedDateTime.ToShortTimeString();
                button.Width = flowPanel.Width - 35;
                button.Height = 35;
                button.Left = (this.ClientSize.Width - button.Width) / 2;
                button.Click += Button_Click;
                button.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);
                ChangeTheColor(button, item.Practiced);
                flowPanel.Controls.Add(button);
            }
        }

        private void ChangeTheColor(Button button, int practiced)
        {
            switch (practiced)
            {
                case 1:
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                    break;
                case 2:
                    button.BackColor = Color.White;
                    button.ForeColor = Color.DarkOrange;
                    break;
                case 3:
                    button.BackColor = Color.White;
                    button.ForeColor = Color.DodgerBlue;
                    break;
                case 4:
                    button.BackColor = Color.White;
                    button.ForeColor = Color.MediumSpringGreen;
                    break;
                case 5:
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Indigo;
                    break;
                default:
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Blue;
                    break;
            }
        }
    }
}
