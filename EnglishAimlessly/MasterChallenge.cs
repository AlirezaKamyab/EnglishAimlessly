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
    public partial class MasterChallenge : Form
    {
        WordsDictionary dictionary;
        List<Word> listOfMasteredWords;
        List<int> results; 
        int all = 0;
        int current = -1;
        public MasterChallenge()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MasterChallenge_Load(object sender, EventArgs e)
        {
            dictionary = new WordsDictionary();
            dictionary.ReloadList();

            results = new List<int>();
            listOfMasteredWords = dictionary.FilterByPracticedNumber(5, Properties.Settings.Default.MasterQuestions, true);
            all = listOfMasteredWords.Count;

            if (current < all - 1)
            {
                makeWordReady();
                loader.Start();
            }
            else
            {
                lblWord.Text = "You haven't mastered any words";
                btnDunno.Enabled = false;
                btnIKnow.Enabled = false;
                btnNotSure.Enabled = false;
            }
        }

        private void makeWordReady()
        {
            if(current < all - 1)
            {
                current++;
                Word word = listOfMasteredWords[current];
                lblWord.Text = word.Name + "(" + word.Type + ")";
                lblCounter.Text = "Question " + (current + 1) + " out of " + all;
            }
        }

        private void btnNotSure_Click(object sender, EventArgs e)
        {
            if (current < all)
            {
                results.Add(1);
                makeWordReady();
            }
        }

        private void btnIKnow_Click(object sender, EventArgs e)
        {
            if (current < all)
            {
                results.Add(0);
                makeWordReady();
            }
        }

        private void btnDunno_Click(object sender, EventArgs e)
        {
            if (current < all)
            {
                results.Add(2);
                makeWordReady();
            }
        }

        private void loader_Tick(object sender, EventArgs e)
        {
            if (results.Count == all)
            {
                loader.Stop();
                MasterResults.masteredWords = listOfMasteredWords;
                MasterResults.results = results;
                EnglishAimlessly.Menu.openFormFromMenu(new MasterResults());
                Close();
            }
        }
    }
}
