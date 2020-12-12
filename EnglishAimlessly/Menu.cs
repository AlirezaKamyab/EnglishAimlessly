using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.OleDb;

namespace EnglishAimlessly
{
    public partial class Menu : Form
    {
        WordsDictionary wordsDictionary;
        UserDictionary userDictionary;
        ATime atime;
        Timer loader;
        SoundPlayer soundPlayer;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            atime = new ATime();
            loader = new Timer();

            wordsDictionary = new WordsDictionary();
            userDictionary = new UserDictionary();

            userDictionary.ReloadList();
            wordsDictionary.ReloadList();
            UserdatabaseVersionControl(); // Adding new stuff without putting data in dager of wiping

            soundPlayer = new SoundPlayer(Properties.Resources.notify);

            loader.Interval = 1;
            loader.Start();
            loader.Tick += Loader_Tick;
            practiceTimer.Start();
            LimitLoader.Start();
        }

        private void Loader_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ActivitionCode == Properties.Settings.Default.Code)
            {
                btnManager.Enabled = true;
            }
            else
            {
                btnManager.Enabled = false;
            }


            if (wordsDictionary.MinPracticedNumber() == 0)
            {
                lblWordStatues.Text = "Newbie";
                lblWordStatues.ForeColor = Color.Red;
            }
            else if (wordsDictionary.MinPracticedNumber() == 1)
            {
                lblWordStatues.Text = "You have practiced all the words; let's review then;";
                lblWordStatues.ForeColor = Color.Orange;
            }
            else if (wordsDictionary.MinPracticedNumber() == 2)
            {
                lblWordStatues.Text = "You are getting good at this; keep the pace;";
                lblWordStatues.ForeColor = Color.Chocolate;
            }
            else if (wordsDictionary.MinPracticedNumber() == 3)
            {
                lblWordStatues.Text = "Smart";
                lblWordStatues.ForeColor = Color.DodgerBlue;
            }
            else if (wordsDictionary.MinPracticedNumber() == 4)
            {
                lblWordStatues.Text = "You are a nerd; let's keep the alternation;";
                lblWordStatues.ForeColor = Color.DarkOliveGreen;
            }
            else if (wordsDictionary.MinPracticedNumber() == 5)
            {
                lblWordStatues.Text = "You have mastered the words; You may update the dictionary;";
                lblWordStatues.ForeColor = Color.DarkKhaki;
            }
            else if (wordsDictionary.MinPracticedNumber() > 5)
            {
                lblWordStatues.Text = "Master";
                lblWordStatues.ForeColor = Color.Purple;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            wordsDictionary.ReloadList();
            userDictionary.ReloadList();
            practiceTimer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void btnActivition_Click(object sender, EventArgs e)
        {
            Activator activator = new Activator();
            activator.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            DictionaryManger manager = new DictionaryManger();
            manager.FormClosing += Manager_FormClosing;
            manager.Show();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            wordsDictionary.ReloadList();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.LearnMode = 0;
            main.FormClosing += Main_FormClosing1;
            main.Show();
        }

        private void Main_FormClosing1(object sender, FormClosingEventArgs e)
        {
            wordsDictionary.ReloadList();
            userDictionary.ReloadList();
        }

        private void practiceTimer_Tick(object sender, EventArgs e)
        {
            //--Practice time
            Main main = new Main();
            main.FormClosing += Main_FormClosing;
            lastPracticeToolStripMenuItem.Text = lblNextPractice.Text;
            switch (Properties.Settings.Default.PracticeCycle)
            {
                case 0:
                    lblNextPractice.Text = "Next practice in " + ConvertTime(30*60*1000);
                    if (atime.TotalMinutes >= 30)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 1:
                    lblNextPractice.Text = "Next practice in " + ConvertTime(45 * 60 * 1000);
                    if (atime.TotalMinutes >= 45)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 2:
                    lblNextPractice.Text = "Next practice in " + ConvertTime(60 * 60 * 1000);

                    if (atime.TotalHours >= 1)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 3:
                    lblNextPractice.Text = "Next practice in " + ConvertTime(2 * 60 * 60 * 1000);

                    if (atime.TotalHours >= 2)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 4:
                    lblNextPractice.Text = "Next practice in " + ConvertTime(5 * 60 * 60 * 1000);

                    if (atime.TotalHours >= 5)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 5:
                    lblNextPractice.Text = "Next practice in " + ConvertTime(12 * 60 * 60 * 1000); ;

                    if (atime.TotalHours >= 12)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 6:
                    lblNextPractice.Text = "Next practice in " + ConvertTime(1 * 24 * 60 * 60 * 1000);

                    if (atime.Days >= 1)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 7:
                    lblNextPractice.Text = "Next practice in " + ConvertTime(2 * 24 * 60 * 60 * 1000);

                    if (atime.Days >= 2)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 8:
                    lblNextPractice.Text = "Next practice in " + ConvertTime(7 * 24 * 60 * 60 * 1000);
                    if (atime.Days >= 7)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 9:
                    lblNextPractice.Text = "Next practice in " + ConvertTime(14 * 24 * 60 * 60 * 1000); ;
                    if (atime.Days >= 14)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 10:
                    lblNextPractice.Text = "Last practice was in " + atime.Days + "d " + atime.Hours + "h " + atime.Minutes + "m ago";
                    if (atime.Months >= 1)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 11:
                    lblNextPractice.Text = "Last practice was in " + atime.Days + "d " + atime.Hours + "h " + atime.Minutes + "m ago";
                    if (atime.Months >= 2)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                case 12:
                    lblNextPractice.Text = "Last practice was in " + atime.Days + "d " + atime.Hours + "h " + atime.Minutes + "m ago";
                    if (atime.Years >= 1)
                    {
                        ReadyForLearning(main);
                    }
                    break;
                default:
                    lblNextPractice.Text = "Last practice was in " + atime.Days + "d " + atime.Hours + "h " + atime.Minutes + "m ago";
                    if (atime.Minutes >= 30)
                    {
                        ReadyForLearning(main);
                    }
                    break;
            }
        }

        private void ReadyForLearning(Main main)
        {
            practiceTimer.Stop();
            soundPlayer.PlaySync();
            Main.LearnMode = 0;
            main.Show();
        }

        private string ConvertTime(int TargetMiliseconds)
        {
            int NowMiliseconds = atime.TotalMiliseconds;
            int duration = TargetMiliseconds - NowMiliseconds;
            int hours = 0, minutes = 0, seconds = 0, days = 0;
            string result = "";
            while (duration >= 1000)
            {
                duration -= 1000;
                seconds++;
                if(seconds >= 60)
                {
                    seconds = 0;
                    minutes++;
                    if(minutes >= 60)
                    {
                        minutes = 0;
                        hours++;
                        if(hours >= 24)
                        {
                            days++;
                            hours = 0;
                        }
                    }
                }
            } 

            if(days > 0)
            {
                result += days + "d ";
            }
            if(hours > 0)
            {
                result += hours + "h ";
            }
            if(minutes > 0)
            {
                result += minutes + "m ";
            }
            if(seconds > 0)
            {
                result += seconds + "s ";
            }

            return result;
        }

        private void LoadTheLimits()
        {
            if (userDictionary.FilterByDateTime(DateTime.Now).Count >= Properties.Settings.Default.MaximumWords)
            {
                practiceTimer.Enabled = false;
                btnLearn.Enabled = false;
                btnCompleteRandomLearning.Enabled = false;
                loader.Enabled = false;
                lblNextPractice.Text = "Words exceeded the max value for today";
                lastPracticeToolStripMenuItem.Text = lblNextPractice.Text;
            }
            else
            {
                if (practiceTimer.Enabled == false && btnLearn.Enabled == false && loader.Enabled == false)
                {
                    btnCompleteRandomLearning.Enabled = true;
                    practiceTimer.Enabled = true;
                    btnLearn.Enabled = true;
                    loader.Enabled = true;
                }
            }
        }

        private void LimitLoader_Tick(object sender, EventArgs e)
        {
            LoadTheLimits();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm();
            history.Show();
        }
        private void UserdatabaseVersionControl()
        {
            try
            {
                string strCommand = "SELECT * FROM ExampleList;";
                userDictionary.CommandLine(strCommand);
            }
            catch
            {
                string strCommand = "CREATE TABLE  ExampleList(" +
    "id INT NOT NULL IDENTITY(1,1)," +
    "RelatedId int," +
    "Example text," +
    "DateAndTime text," +
    "PRIMARY KEY(id)" +
    ");";
                userDictionary.CommandLine(strCommand);
            }
        }

        private void btnMyExamples_Click(object sender, EventArgs e)
        {
            ExampleInspection.isAll = true;
            ExampleInspection inspection = new ExampleInspection();
            inspection.Show();
        }

        private void btnCompleteRandomLearning_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.LearnMode = 1;
            main.FormClosing += Main_FormClosing1;
            main.Show();
        }

        private void btnMasterReview_Click(object sender, EventArgs e)
        {
            MasterChallenge mc = new MasterChallenge();
            mc.Show();
        }


        /// <summary>
        /// This is just a form Object for helping to open from menu
        /// </summary>
        /// <param name="form"></param>
        public static void openFormFromMenu(Form form)
        {
            form.Show();
        }

        private void btnMasteredWords_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon","Wait for it");
        }
    }
}
