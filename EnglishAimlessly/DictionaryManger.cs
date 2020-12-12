using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAimlessly
{
    public partial class DictionaryManger : Form
    {
        public WordsDictionary dictionary;
        private int IdSelected = 0;
        private Groups groups;
        public DictionaryManger()
        {
            InitializeComponent();
        }

        private void DictionaryManger_Load(object sender, EventArgs e)
        {
            dictionary = new WordsDictionary();
            groups = new Groups(); // this reloads the list itself, there is no need to call reload again

            comboGroup.Items.Clear();
            foreach (Group item in groups)
            {
                comboGroup.Items.Add(item.Name);
            }
            dictionary.ReloadList();
            UpdateGridView(dictionary.FindItemsByGroupName(comboGroup.Text));

            dictionary.Added += Dictionary_Added;
            DictionaryList.SelectionChanged += DictionaryList_SelectionChanged;
            dictionary.Updated += Dictionary_Updated;
            dictionary.Deleted += Dictionary_Deleted;
            groups.Added += Groups_Added;
            groups.Updated += Groups_Updated;
            groups.Deleted += Groups_Deleted;
            Timer SelectedItemReloader = new Timer();
            SelectedItemReloader.Interval = 50;
            SelectedItemReloader.Start();
            SelectedItemReloader.Tick += SelectedItemReloader_Tick;

            if (comboGroup.Items.Count > 0)
            {
                comboGroup.SelectedIndex = 0;
                comboGroup.Text = comboGroup.Items[0].ToString();
            }
        }

        private void Groups_Deleted(Word word)
        {
            groups.Reload();
            comboGroup.Items.Clear();
            foreach (Group item in groups)
            {
                comboGroup.Items.Add(item.Name);
            }

            if (comboGroup.Items.Count > 0)
            {
                comboGroup.SelectedIndex = 0;
                comboGroup.Text = comboGroup.Items[0].ToString();
            }
            else
            {
                comboGroup.Text = "";
            }
        }

        private void Groups_Updated(Word oldWord, Word newWord)
        {
            dictionary.ReloadList();
            groups.Reload();
            comboGroup.Items.Clear();
            foreach (Group item in groups)
            {
                comboGroup.Items.Add(item.Name);
            }

            if (comboGroup.Items.Count > 0)
            {
                Group g = groups.FindById(UpdateGroup.Id);
                comboGroup.SelectedIndex = comboGroup.Items.IndexOf(g.Name);
            }
        }

        private void Groups_Added(Word word)
        {
            groups.Reload();
            comboGroup.Items.Clear();
            foreach (Group item in groups)
            {
                comboGroup.Items.Add(item.Name);
            }

            if (comboGroup.Items.Count > 0)
            {
                comboGroup.SelectedIndex = 0;
                comboGroup.Text = comboGroup.Items[0].ToString();
            }
        }

        private void Dictionary_Updated(Word oldWorld, Word newWord)
        {
            UpdateGridView(dictionary.FindItemsByGroupName(comboGroup.Text));
        }

        private void SelectedItemReloader_Tick(object sender, EventArgs e)
        {
            try
            {
                if (DictionaryList.SelectedRows[0].Cells[0].Value != null)
                {
                    IdSelected = int.Parse(DictionaryList.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch
            {

            }

            if (comboGroup.Text.ToString() != "" && comboGroup.Items.Count > 0)
            {
                //updated code; it does nothing here
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void Dictionary_Deleted(Word word)
        {
            dictionary.ReloadList();
            UpdateGridView(dictionary.FindItemsByGroupName(comboGroup.Text));
        }

        private void DictionaryList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DictionaryList.SelectedRows[0].Cells[0].Value != null)
                {
                    IdSelected = int.Parse(DictionaryList.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch
            {

            }
        }
        private void Dictionary_Added(Word word)
        {
            dictionary.ReloadList();
            UpdateGridView(dictionary.FindItemsByGroupName(comboGroup.Text));
        }
        public void UpdateGridView(List<Word> list)
        {
            dictionary.ReloadList();
            DictionaryList.Rows.Clear();
            foreach (Word item in list)
            {
                int index = DictionaryList.Rows.Add();
                DataGridViewRow row = DictionaryList.Rows[index];
                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.Name;
                row.Cells[2].Value = item.Type;
                row.Cells[3].Value = item.Equivalent;
                row.Cells[4].Value = item.Description;
                row.Cells[5].Value = item.Important;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm.groupName = comboGroup.Text;
            AddForm.wordsDictionary = dictionary;
            AddForm form = new AddForm();
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IdSelected != 0)
            {
                DeleteForm.Id = IdSelected;
                DeleteForm.wordsDictionary = dictionary;
                DeleteForm deleteForm = new DeleteForm();
                deleteForm.Show();
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (groups.Contains(new Group(comboGroup.Text.Trim())))
            {
                Group group = groups.FindByName(comboGroup.Text);
                DeleteGroup.Id = group.Id;
                DeleteGroup.words = dictionary;
                DeleteGroup.groups = groups;
                DeleteGroup deleteGroup = new DeleteGroup();
                deleteGroup.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IdSelected != 0)
            {
                UpdateForm.Id = IdSelected;
                UpdateForm.wordsDictionary = dictionary;
                UpdateForm updateForm = new UpdateForm();
                updateForm.Show();
            }
        }

        private void comboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridView(dictionary.FindItemsByGroupName(comboGroup.Text));
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            AddGroup.groups = groups;
            AddGroup addGroup = new AddGroup();
            addGroup.Show();
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            if (groups.Contains(new Group(comboGroup.Text.Trim())))
            {
                Group group = groups.FindByName(comboGroup.Text);
                UpdateGroup.Id = group.Id;
                UpdateGroup.words = dictionary;
                UpdateGroup.groups = groups;
                UpdateGroup groupUpdate = new UpdateGroup();
                groupUpdate.Show();
            }
        }

        private void comboGroup_TextChanged(object sender, EventArgs e)
        {
            if (groups.Contains(new Group(comboGroup.Text, DateTime.Now)))
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
