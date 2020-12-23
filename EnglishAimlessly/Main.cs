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
    public partial class Main : Form
    {
        private WordsDictionary wordsDictionary;
        private UserDictionary userDictionary;
        private Examples examples;
        private Groups groups;
        public static int LearnMode = 0; //Learn modes; number 0 for conventional learning, and number 2 is for CompleteRandom Learnin
        Word word;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastPractice = DateTime.Now;
            Properties.Settings.Default.Save();

            userDictionary = new UserDictionary();
            wordsDictionary = new WordsDictionary();
            examples = new Examples(); //This will reload whenever the object is constructed
            groups = new Groups();

            LoadTheWord();

            LoadTheLimits();
            BackgroundLoader.Start();


            if (LearnMode == 0)
            {
                lblTitle.Text = "Normal Mode";
            }
            else if (LearnMode == 1)
            {
                lblTitle.Text = "Random Mode";
            }
        }

        private Word ChooseAWord()
        {
            WordsDictionary controledDictionary = new WordsDictionary();
            if (Properties.Settings.Default.SelectedGroupPractice == "*All*")
            {
                controledDictionary.ReloadList();
            }
            else
            {
                if (groups.Contains(new Group(Properties.Settings.Default.SelectedGroupPractice.Trim())))
                {
                    controledDictionary.LoadDictionaryFilteredByGroupName(Properties.Settings.Default.SelectedGroupPractice);
                }
                else
                {
                    controledDictionary.ReloadList();
                }
            }

            if (controledDictionary.Count > 0)
            {
                Random ran = new Random();
                int minPracticed = controledDictionary.MinPracticedNumber();
                List<Word> temp = new List<Word>();
                foreach (Word item in controledDictionary)
                {
                    if (LearnMode == 0)
                    {
                        if (minPracticed == item.Practiced)
                        {
                            temp.Add(item);
                        }
                    }
                    else if (LearnMode == 1)
                    {
                        temp.Add(item);
                    }
                }

                return temp[ran.Next(temp.Count)];
            }
            else
            {
                Close();
                return new Word();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (btnSkip.Text.ToLower() == "close")
            {
                Close();
            }
            else
            {
                DialogResult re = MessageBox.Show("Are you sure you want to skip? The word won't be saved as practiced", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (re == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Word newWord = word;
            newWord.Practiced += 1;
            userDictionary.Add(new UserWord(newWord, DateTime.Now, newWord.Id));
            wordsDictionary.UpdateWord(word, newWord);

            Example example = new Example();
            example.RelatedId = word.Id;
            example.Value = txtExample.Text;
            example.Time = DateTime.Now;
            examples.Add(example);

            //Save and close after updating the database
            Properties.Settings.Default.LastPractice = DateTime.Now;
            Properties.Settings.Default.Save();
            Close();
        }

        private void LoadTheWord()
        {
            string htmlData = "";
            userDictionary.ReloadList();
            wordsDictionary.ReloadList();
            word = ChooseAWord();

            lblWord.Text = word.Name + " (" + word.Type.ToString() + ")";
            //lblEquivalent.Text = word.Equivalent;
            if (word.Equivalent.Trim() != "")
            {
                htmlData += "<p><b><i>" + word.Equivalent + "</i></b></p><br><hr><br>\n";
            }
            htmlData += word.Description;
            DisplayHtml(htmlData);
            lblPracticed.Text = "Practiced: " + word.Practiced.ToString();
            lblGroup.Text = string.Format("Group: {0}", word.Group);
            if (word.Important)
            {
                lblWord.Text = word.Name + "* (" + word.Type.ToString() + ")";
                lblWord.ForeColor = Color.Red;
            }
            else
            {
                lblWord.ForeColor = Color.Black;
            }
        }
        private void DisplayHtml(string html)
        {
            try
            {
                lblDescription.Navigate("about:blank");
                try
                {
                    if (lblDescription.Document != null)
                    {
                        lblDescription.Document.Write(string.Empty);
                    }
                }
                catch
                { } // do nothing with this
                lblDescription.DocumentText = HtmlStyle(html);
            }
            catch
            {

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (userDictionary.FilterByDateTime(DateTime.Now).Count < Properties.Settings.Default.MaximumWords)
            {
                Word newWord = word;
                newWord.Practiced += 1;
                userDictionary.Add(new UserWord(newWord, DateTime.Now, newWord.Id));
                wordsDictionary.UpdateWord(word, newWord);

                Example example = new Example();
                example.RelatedId = word.Id;
                example.Value = txtExample.Text;
                example.Time = DateTime.Now;
                examples.Add(example);
                txtExample.Text = "";
                //Save and ready up for the next word
                Properties.Settings.Default.LastPractice = DateTime.Now;
                Properties.Settings.Default.Save();
                btnContinue.Enabled = false;
                btnContinue.BackColor = Color.Gray;
                btnContinue.ForeColor = Color.Black;
                btnSkip.Text = "Close";
                LoadTheWord();
            }
            else
            {
                LoadTheLimits();
            }
        }

        private void BackgroundLoader_Tick(object sender, EventArgs e)
        {
            LoadTheLimits();
        }

        private void LoadTheLimits()
        {
            if (userDictionary.FilterByDateTime(DateTime.Now).Count >= Properties.Settings.Default.MaximumWords)
            {
                btnContinue.Enabled = false;
                btnNext.Enabled = false;
                btnContinue.BackColor = Color.Gray;
                btnContinue.ForeColor = Color.Black;
                btnNext.BackColor = Color.Gray;
                btnNext.ForeColor = Color.Black;
                btnSkip.Text = "Close";
                BackgroundLoader.Stop();
            }
        }

        private void lnkExamples_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExampleInspection.Id = word.Id;
            ExampleInspection.isAll = false;
            ExampleInspection inspection = new ExampleInspection();
            inspection.Show();
        }

        public static string HtmlStyle(string Documents)
        {
            string style = ".content{\n" +
            "background-color: white;\n" +
            "padding: 2px 5px 5px 5px;\n" +
            "font - family: 'Segoe UI', Tahoma, Geneva, Verdana, sans - serif;\n" + 
            "}\n" +

            "p{\n" +
            "line-height: 0.75em;\n" +
            "margin: 1px; \n" + 
            "padding: 5px; \n" + 
            "}";
            string html = "<!doctype html>\n" +
                "<html lang=\"en\">\n" +
                "<head>\n" +
                "<title>Learn English Words</title>\n" +
                "<style>" + style + "</style>\n" +
                "</head>\n" +
                "<body>\n" +
                "<div class=\"content\">\n" +
                Documents +
                "</div>\n" +
                "</body>\n" +
                "</html>";
            return html;
        }
    }
}
