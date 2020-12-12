namespace EnglishAimlessly
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMasteredWords = new System.Windows.Forms.Button();
            this.btnMasterReview = new System.Windows.Forms.Button();
            this.btnCompleteRandomLearning = new System.Windows.Forms.Button();
            this.btnMyExamples = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblWordStatues = new System.Windows.Forms.Label();
            this.lblNextPractice = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnActivition = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnLearn = new System.Windows.Forms.Button();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastPracticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceTimer = new System.Windows.Forms.Timer(this.components);
            this.LimitLoader = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.contextMenuStripNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1176, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "English Aimlessly";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMasteredWords);
            this.panel1.Controls.Add(this.btnMasterReview);
            this.panel1.Controls.Add(this.btnCompleteRandomLearning);
            this.panel1.Controls.Add(this.btnMyExamples);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.lblWordStatues);
            this.panel1.Controls.Add(this.lblNextPractice);
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnActivition);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnManager);
            this.panel1.Controls.Add(this.btnLearn);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 600);
            this.panel1.TabIndex = 1;
            // 
            // btnMasteredWords
            // 
            this.btnMasteredWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasteredWords.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasteredWords.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMasteredWords.Location = new System.Drawing.Point(741, 320);
            this.btnMasteredWords.Name = "btnMasteredWords";
            this.btnMasteredWords.Size = new System.Drawing.Size(174, 119);
            this.btnMasteredWords.TabIndex = 15;
            this.btnMasteredWords.Text = "Mastered Words";
            this.btnMasteredWords.UseVisualStyleBackColor = true;
            this.btnMasteredWords.Click += new System.EventHandler(this.btnMasteredWords_Click);
            // 
            // btnMasterReview
            // 
            this.btnMasterReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterReview.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterReview.ForeColor = System.Drawing.Color.Blue;
            this.btnMasterReview.Location = new System.Drawing.Point(492, 320);
            this.btnMasterReview.Name = "btnMasterReview";
            this.btnMasterReview.Size = new System.Drawing.Size(174, 119);
            this.btnMasterReview.TabIndex = 14;
            this.btnMasterReview.Text = "Review Mastered\r\nWords";
            this.btnMasterReview.UseVisualStyleBackColor = true;
            this.btnMasterReview.Click += new System.EventHandler(this.btnMasterReview_Click);
            // 
            // btnCompleteRandomLearning
            // 
            this.btnCompleteRandomLearning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteRandomLearning.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteRandomLearning.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCompleteRandomLearning.Location = new System.Drawing.Point(249, 320);
            this.btnCompleteRandomLearning.Name = "btnCompleteRandomLearning";
            this.btnCompleteRandomLearning.Size = new System.Drawing.Size(174, 119);
            this.btnCompleteRandomLearning.TabIndex = 13;
            this.btnCompleteRandomLearning.Text = "Complete Random\r\nLearn";
            this.btnCompleteRandomLearning.UseVisualStyleBackColor = true;
            this.btnCompleteRandomLearning.Click += new System.EventHandler(this.btnCompleteRandomLearning_Click);
            // 
            // btnMyExamples
            // 
            this.btnMyExamples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyExamples.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyExamples.ForeColor = System.Drawing.Color.Chocolate;
            this.btnMyExamples.Location = new System.Drawing.Point(156, 11);
            this.btnMyExamples.Name = "btnMyExamples";
            this.btnMyExamples.Size = new System.Drawing.Size(149, 41);
            this.btnMyExamples.TabIndex = 12;
            this.btnMyExamples.Text = "My Examples";
            this.btnMyExamples.UseVisualStyleBackColor = true;
            this.btnMyExamples.Click += new System.EventHandler(this.btnMyExamples_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnHistory.Location = new System.Drawing.Point(11, 11);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(139, 41);
            this.btnHistory.TabIndex = 11;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lblWordStatues
            // 
            this.lblWordStatues.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordStatues.ForeColor = System.Drawing.Color.Red;
            this.lblWordStatues.Location = new System.Drawing.Point(14, 558);
            this.lblWordStatues.Name = "lblWordStatues";
            this.lblWordStatues.Size = new System.Drawing.Size(1174, 32);
            this.lblWordStatues.TabIndex = 10;
            this.lblWordStatues.Text = "You haven\'t practiced yet";
            this.lblWordStatues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNextPractice
            // 
            this.lblNextPractice.AutoSize = true;
            this.lblNextPractice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPractice.Location = new System.Drawing.Point(127, 494);
            this.lblNextPractice.Name = "lblNextPractice";
            this.lblNextPractice.Size = new System.Drawing.Size(210, 23);
            this.lblNextPractice.TabIndex = 9;
            this.lblNextPractice.Text = "Next practice in 0 minutes";
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Gray;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(1082, 12);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(50, 50);
            this.btnHide.TabIndex = 8;
            this.btnHide.Text = "-";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1138, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnActivition
            // 
            this.btnActivition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivition.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivition.ForeColor = System.Drawing.Color.Purple;
            this.btnActivition.Location = new System.Drawing.Point(869, 195);
            this.btnActivition.Name = "btnActivition";
            this.btnActivition.Size = new System.Drawing.Size(174, 119);
            this.btnActivition.TabIndex = 4;
            this.btnActivition.Text = "ActivitionCode";
            this.btnActivition.UseVisualStyleBackColor = true;
            this.btnActivition.Click += new System.EventHandler(this.btnActivition_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSettings.Location = new System.Drawing.Point(616, 195);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(174, 119);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnManager
            // 
            this.btnManager.Enabled = false;
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.Red;
            this.btnManager.Location = new System.Drawing.Point(370, 195);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(174, 119);
            this.btnManager.TabIndex = 2;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnLearn
            // 
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.ForeColor = System.Drawing.Color.Blue;
            this.btnLearn.Location = new System.Drawing.Point(131, 195);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(174, 119);
            this.btnLearn.TabIndex = 1;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.contextMenuStripNotify;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "EnglishAimlessly";
            this.notify.Visible = true;
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.BackColor = System.Drawing.Color.White;
            this.contextMenuStripNotify.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripNotify.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.lastPracticeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripNotify.Name = "contextMenuStripNotify";
            this.contextMenuStripNotify.ShowCheckMargin = true;
            this.contextMenuStripNotify.ShowImageMargin = false;
            this.contextMenuStripNotify.Size = new System.Drawing.Size(220, 76);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // lastPracticeToolStripMenuItem
            // 
            this.lastPracticeToolStripMenuItem.Name = "lastPracticeToolStripMenuItem";
            this.lastPracticeToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.lastPracticeToolStripMenuItem.Text = "Last Practice 0 min";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // practiceTimer
            // 
            this.practiceTimer.Interval = 1;
            this.practiceTimer.Tick += new System.EventHandler(this.practiceTimer_Tick);
            // 
            // LimitLoader
            // 
            this.LimitLoader.Interval = 750;
            this.LimitLoader.Tick += new System.EventHandler(this.LimitLoader_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStripNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActivition;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblNextPractice;
        private System.Windows.Forms.Timer practiceTimer;
        private System.Windows.Forms.Label lblWordStatues;
        private System.Windows.Forms.ToolStripMenuItem lastPracticeToolStripMenuItem;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Timer LimitLoader;
        private System.Windows.Forms.Button btnMyExamples;
        private System.Windows.Forms.Button btnMasteredWords;
        private System.Windows.Forms.Button btnMasterReview;
        private System.Windows.Forms.Button btnCompleteRandomLearning;
    }
}