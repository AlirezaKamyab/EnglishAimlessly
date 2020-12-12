﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAimlessly
{
    public partial class Settings : Form
    {
        private Groups groupNames;
        public Settings()
        {
            InitializeComponent();
        }

        private void btnCycleApply_Click(object sender, EventArgs e)
        {
            if (comboCycle.SelectedIndex >= 0)
            {
                Properties.Settings.Default.PracticeCycle = comboCycle.SelectedIndex;
                Properties.Settings.Default.Save();
                DialogResult re = MessageBox.Show("Settings updated\nDo you want your practice time to reset?", "Cycle", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if(re == DialogResult.Yes)
                {
                    Properties.Settings.Default.LastPractice = DateTime.Now;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                MessageBox.Show("Please choose a cycle", "Cycle", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            groupNames = new Groups();//RELOADED

            if (Properties.Settings.Default.ActivitionCode == Properties.Settings.Default.Code)
            {
                lblActivitionStatues.Show();
            }
            comboCycle.Text = comboCycle.Items[Properties.Settings.Default.PracticeCycle].ToString();
            CheckStartup.Checked = Properties.Settings.Default.IsOneStartUp;
            lblVersion.Text = "Version: " + Properties.Settings.Default.Version;
            lblDatabaseVersion.Text = "Database Version: " + Properties.Settings.Default.DatabaseVersion;

            if(Properties.Settings.Default.MaximumWords < 10000)
            {
                comboWordsADay.Text = Properties.Settings.Default.MaximumWords + " Words";
            }
            else
            {
                comboWordsADay.Text = "Infinite";
            }

            foreach (Group item in groupNames)
            {
                comboGroup.Items.Add(item.Name);
            }
            comboGroup.Items.Add("*All*");

            comboGroup.Text = "*All*";
            comboGroup.SelectedIndex = comboGroup.Items.Count - 1;
            if(groupNames.Count > 0)
            {
                if(groupNames.Contains(new Group(Properties.Settings.Default.SelectedGroupPractice.Trim())))
                {
                    comboGroup.Text = Properties.Settings.Default.SelectedGroupPractice.Trim();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckStartup_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsOneStartUp = CheckStartup.Checked;
            Properties.Settings.Default.Save();
            RegistryKey registerset = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (CheckStartup.Checked)
            {
                registerset.SetValue("EnglishAimlessly", Application.ExecutablePath.ToString());
            }
            else
            {
                registerset.DeleteValue("EnglishAimlessly", false);
            }
        }

        private void btnApplyWordsADay_Click(object sender, EventArgs e)
        {
            int max = 3;
            switch (comboWordsADay.SelectedIndex)
            {
                case 0:
                    max = 3;
                    break;
                case 1:
                    max = 5;
                    break;
                case 2:
                    max = 10;
                    break;
                case 3:
                    max = 15;
                    break;
                case 4:
                    max = 20;
                    break;
                case 5:
                    max = 30;
                    break;
                case 6:
                    max = int.MaxValue;
                    break;
                default:
                    max = 10;
                    break;
            }
            Properties.Settings.Default.MaximumWords = max;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings saved!", "Setting");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Time Cycle Apply
            if (comboCycle.SelectedIndex >= 0)
            {
                Properties.Settings.Default.PracticeCycle = comboCycle.SelectedIndex;
                Properties.Settings.Default.Save();
                DialogResult re = MessageBox.Show("Settings updated\nDo you want your practice time to reset?", "Cycle", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (re == DialogResult.Yes)
                {
                    Properties.Settings.Default.LastPractice = DateTime.Now;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                MessageBox.Show("Please choose a cycle", "Cycle", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

            //Words aday Apply
            int max = 3;
            switch (comboWordsADay.SelectedIndex)
            {
                case 0:
                    max = 3;
                    break;
                case 1:
                    max = 5;
                    break;
                case 2:
                    max = 10;
                    break;
                case 3:
                    max = 15;
                    break;
                case 4:
                    max = 20;
                    break;
                case 5:
                    max = 30;
                    break;
                case 6:
                    max = int.MaxValue;
                    break;
                default:
                    max = 10;
                    break;
            }
            Properties.Settings.Default.MaximumWords = max;
            Properties.Settings.Default.Save();

            //Group Apply
            if(groupNames.Contains(new Group(comboGroup.Text.Trim())) || comboGroup.Text.Trim() == "*All*")
            {
                Properties.Settings.Default.SelectedGroupPractice = comboGroup.Text.Trim();
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Group is not found; try to create a new group or change the settings to another group!", "Group", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
