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
    public partial class ExampleInspection : Form
    {
        private WordsDictionary dictionary;
        private UserDictionary userDictionary;
        private Examples examples;
        public static int Id = 0; //This should be relatedId to wordsDictionary
        public static bool isAll = false;
        public ExampleInspection()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExampleInspection_Load(object sender, EventArgs e)
        {
            dictionary = new WordsDictionary();
            userDictionary = new UserDictionary();
            examples = new Examples(); //This will reload automatically, no need to call for any reload function

            dictionary.ReloadList();
            userDictionary.ReloadList();

            if (!isAll)
            {
                LoadPage(examples.FindListByRelatedId(Id));
            }
            else
            {
                LoadPage(examples.ToList());
            }
        }

        private void LoadPage(List<Example> examples)
        {
            Word word = dictionary.FindById(Id);
            if (!isAll)
            {
                lblWord.Text = word.Name + "(" + word.Type.ToString() + ")";
                lblTitle.Text = "Inspect #" + Id.ToString();
            }
            else
            {
                lblWord.Text = "All Examples";
                lblTitle.Text = "Example Inspection Form";
            }

            flowPanel.Controls.Clear();

            foreach (Example item in examples)
            {
                Button btn = new Button();
                btn.Name = item.Id.ToString();
                btn.Click += Btn_Click;
                btn.Width = flowPanel.Width - 35;
                btn.Height = 35;
                btn.Left = (this.ClientSize.Width - btn.Width) / 2;
                if (!isAll)
                {
                    btn.Text = "Record written in " + item.Time.ToShortDateString();
                }
                else
                {
                    Word temp = dictionary.FindById(item.RelatedId);
                    if (temp.Id >= 0)
                    {
                        btn.Text = string.Format("{0} ({1}); DateTime: {2}", temp.Name, temp.Type.ToString(), item.Time.ToShortDateString());
                    }
                    else
                    {
                        btn.Text = string.Format("NOT FOUND; DateTime: {0}", item.Time.ToShortDateString());
                    }
                }
                btn.FlatStyle = FlatStyle.Flat;
                if (item.Value != string.Empty)
                {
                    btn.BackColor = Color.Crimson;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Red;
                }
                FontFamily family = new FontFamily("arial");
                btn.Font = new Font(family, 10, FontStyle.Bold);
                flowPanel.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ReadExample.Id = int.Parse(btn.Name);
            ReadExample read = new ReadExample();
            read.FormClosing += Read_FormClosing;
            read.Show();
        }

        private void Read_FormClosing(object sender, FormClosingEventArgs e)
        {
            examples.Reload();
            if (!isAll)
            {
                LoadPage(examples.FindListByRelatedId(Id));
            }
            else
            {
                LoadPage(examples.ToList());
            }
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            if (!isAll)
            {
                List<Example> IdFilter = examples.FindListByRelatedId(Id);
                List<Example> DateTimeFilter = examples.FindListByRelatedDateTime(dateTime.Value);
                List<Example> Incommon = new List<Example>();
                foreach(Example item1 in DateTimeFilter)
                {
                    foreach(Example item2 in IdFilter)
                    {
                        if(item1.Id == item2.Id)
                        {
                            Incommon.Add(item1);
                            break;
                        }
                    }
                }
                LoadPage(Incommon);
            }
            else
            {
                List<Example> DateTimeFilter = examples.FindListByRelatedDateTime(dateTime.Value);
                LoadPage(DateTimeFilter);
            }
        }
    }
}
