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
    public partial class MasterDay : Form
    {
        WordsDictionary words;
        MasterDayDataset masterDayItems;
        List<MasterDayItem> todays;
        public MasterDay()
        {
            InitializeComponent();
        }

        private void MaterDay_Load(object sender, EventArgs e)
        {
            words = new WordsDictionary();
            masterDayItems = new MasterDayDataset();
            todays = new List<MasterDayItem>();
            words.ReloadList();

            DateTime dteTime = DateTime.Now;
            todays = masterDayItems.fetchFromDate(dteTime.ToShortDateString());

            MakeItemsReady();
        }

        private void MakeItemsReady()
        {
            List<Word> masteredWords = new List<Word>();
            if (todays.Count == 0)
            {
                masteredWords = words.FilterByPracticedNumber(5, 4, true);
                if (masteredWords.Count < 4) return;
                DateTime dteTime = DateTime.Now;
                masterDayItems.Add(new MasterDayItem(masteredWords[0].Id, masteredWords[1].Id, masteredWords[2].Id, masteredWords[3].Id, dteTime.ToShortDateString()));
            }
            else
            {
                try
                {
                    masteredWords.Add(words.FindById(todays[0].Slot1));
                    masteredWords.Add(words.FindById(todays[0].Slot2));
                    masteredWords.Add(words.FindById(todays[0].Slot3));
                    masteredWords.Add(words.FindById(todays[0].Slot4));
                }
                catch
                {

                }
            }
            foreach (Word item in masteredWords)
            {
                Item_Word wrd = new Item_Word();
                wrd.Clicked += Wrd_Clicked;
                wrd.Name = item.Id.ToString();
                wrd.Title = item.Name;
                wrd.Description = "Practiced " + item.Practiced + " time";
                if (item.Practiced > 1) wrd.Description += "s";
                if (item.Important)
                {
                    wrd.TitleColor = Color.White;
                    wrd.DescriptionColor = Color.White;
                    wrd.BackgroundColor = Color.Black;
                }

                if(item.Name.Length > 0) pnlItems.Controls.Add(wrd);
            }
        }

        private void Wrd_Clicked(object sender)
        {
            Item_Word item = sender as Item_Word;
            try
            {
                InspectForm.Id = int.Parse(item.Name);
                InspectForm form = new InspectForm();
                form.Show();
            }
            catch
            {
                MessageBox.Show("Something went wrong while searching for the id.","Oops, an error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
