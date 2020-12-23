namespace EnglishAimlessly
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActivitionStatues = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDatabaseVersion = new System.Windows.Forms.Label();
            this.CheckStartup = new System.Windows.Forms.CheckBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMasterValue = new System.Windows.Forms.Label();
            this.TrackQuestionsValue = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApplyWordsADay = new System.Windows.Forms.Button();
            this.comboWordsADay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCycleApply = new System.Windows.Forms.Button();
            this.comboCycle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFIX = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackQuestionsValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFIX);
            this.panel1.Controls.Add(this.lblActivitionStatues);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 550);
            this.panel1.TabIndex = 2;
            // 
            // lblActivitionStatues
            // 
            this.lblActivitionStatues.ForeColor = System.Drawing.Color.Green;
            this.lblActivitionStatues.Location = new System.Drawing.Point(17, 520);
            this.lblActivitionStatues.Name = "lblActivitionStatues";
            this.lblActivitionStatues.Size = new System.Drawing.Size(970, 20);
            this.lblActivitionStatues.TabIndex = 3;
            this.lblActivitionStatues.Text = "*Application is activated";
            this.lblActivitionStatues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivitionStatues.Visible = false;
            this.lblActivitionStatues.Click += new System.EventHandler(this.lblActivitionStatues_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDatabaseVersion);
            this.groupBox2.Controls.Add(this.CheckStartup);
            this.groupBox2.Controls.Add(this.lblVersion);
            this.groupBox2.Location = new System.Drawing.Point(16, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(970, 194);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program";
            // 
            // lblDatabaseVersion
            // 
            this.lblDatabaseVersion.Location = new System.Drawing.Point(6, 142);
            this.lblDatabaseVersion.Name = "lblDatabaseVersion";
            this.lblDatabaseVersion.Size = new System.Drawing.Size(958, 20);
            this.lblDatabaseVersion.TabIndex = 4;
            this.lblDatabaseVersion.Text = "Database version 1.1.0";
            this.lblDatabaseVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckStartup
            // 
            this.CheckStartup.AutoSize = true;
            this.CheckStartup.Location = new System.Drawing.Point(23, 44);
            this.CheckStartup.Name = "CheckStartup";
            this.CheckStartup.Size = new System.Drawing.Size(112, 24);
            this.CheckStartup.TabIndex = 3;
            this.CheckStartup.Text = "On Startup";
            this.CheckStartup.UseVisualStyleBackColor = true;
            this.CheckStartup.CheckedChanged += new System.EventHandler(this.CheckStartup_CheckedChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(6, 99);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(958, 20);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version 1.2.1";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.lblMasterValue);
            this.groupBox1.Controls.Add(this.TrackQuestionsValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.comboGroup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnApplyWordsADay);
            this.groupBox1.Controls.Add(this.comboWordsADay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCycleApply);
            this.groupBox1.Controls.Add(this.comboCycle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 240);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Practice";
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(415, 194);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(310, 40);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset Practices From Group Practice";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMasterValue
            // 
            this.lblMasterValue.AutoSize = true;
            this.lblMasterValue.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterValue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMasterValue.Location = new System.Drawing.Point(851, 153);
            this.lblMasterValue.Name = "lblMasterValue";
            this.lblMasterValue.Size = new System.Drawing.Size(40, 29);
            this.lblMasterValue.TabIndex = 12;
            this.lblMasterValue.Text = "20";
            // 
            // TrackQuestionsValue
            // 
            this.TrackQuestionsValue.AutoSize = false;
            this.TrackQuestionsValue.Location = new System.Drawing.Point(171, 156);
            this.TrackQuestionsValue.Maximum = 100;
            this.TrackQuestionsValue.Minimum = 1;
            this.TrackQuestionsValue.Name = "TrackQuestionsValue";
            this.TrackQuestionsValue.Size = new System.Drawing.Size(678, 32);
            this.TrackQuestionsValue.TabIndex = 11;
            this.TrackQuestionsValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackQuestionsValue.Value = 20;
            this.TrackQuestionsValue.Scroll += new System.EventHandler(this.TrackQuestionsValue_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Master Questions:";
            // 
            // btnApply
            // 
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.ForeColor = System.Drawing.Color.Green;
            this.btnApply.Location = new System.Drawing.Point(262, 194);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(147, 40);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // comboGroup
            // 
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(152, 114);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(812, 28);
            this.comboGroup.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Group Practice:";
            // 
            // btnApplyWordsADay
            // 
            this.btnApplyWordsADay.Location = new System.Drawing.Point(458, 80);
            this.btnApplyWordsADay.Name = "btnApplyWordsADay";
            this.btnApplyWordsADay.Size = new System.Drawing.Size(101, 28);
            this.btnApplyWordsADay.TabIndex = 6;
            this.btnApplyWordsADay.Text = "Apply";
            this.btnApplyWordsADay.UseVisualStyleBackColor = true;
            this.btnApplyWordsADay.Visible = false;
            this.btnApplyWordsADay.Click += new System.EventHandler(this.btnApplyWordsADay_Click);
            // 
            // comboWordsADay
            // 
            this.comboWordsADay.FormattingEnabled = true;
            this.comboWordsADay.Items.AddRange(new object[] {
            "3 Words",
            "5 Words",
            "10 Words",
            "15 Words",
            "20 Words",
            "30 Words",
            "Infinite"});
            this.comboWordsADay.Location = new System.Drawing.Point(206, 80);
            this.comboWordsADay.Name = "comboWordsADay";
            this.comboWordsADay.Size = new System.Drawing.Size(246, 28);
            this.comboWordsADay.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum words a day:";
            // 
            // btnCycleApply
            // 
            this.btnCycleApply.Location = new System.Drawing.Point(364, 46);
            this.btnCycleApply.Name = "btnCycleApply";
            this.btnCycleApply.Size = new System.Drawing.Size(101, 28);
            this.btnCycleApply.TabIndex = 3;
            this.btnCycleApply.Text = "Apply";
            this.btnCycleApply.UseVisualStyleBackColor = true;
            this.btnCycleApply.Visible = false;
            this.btnCycleApply.Click += new System.EventHandler(this.btnCycleApply_Click);
            // 
            // comboCycle
            // 
            this.comboCycle.FormattingEnabled = true;
            this.comboCycle.Items.AddRange(new object[] {
            "30 Minutes",
            "45 Minutes",
            "1 Hour",
            "2 Hours",
            "5 Hours",
            "12 Hours",
            "1 Day",
            "2 Days",
            "1 Week",
            "2 Weeks",
            "1 Month",
            "2 Months",
            "1 Year"});
            this.comboCycle.Location = new System.Drawing.Point(151, 46);
            this.comboCycle.Name = "comboCycle";
            this.comboCycle.Size = new System.Drawing.Size(207, 28);
            this.comboCycle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Practice every: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(937, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(976, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Settings";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFIX
            // 
            this.btnFIX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFIX.ForeColor = System.Drawing.Color.Orange;
            this.btnFIX.Location = new System.Drawing.Point(817, 518);
            this.btnFIX.Name = "btnFIX";
            this.btnFIX.Size = new System.Drawing.Size(170, 29);
            this.btnFIX.TabIndex = 5;
            this.btnFIX.Text = "FIX beta";
            this.btnFIX.UseVisualStyleBackColor = true;
            this.btnFIX.Click += new System.EventHandler(this.btnFIX_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackQuestionsValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ComboBox comboCycle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblActivitionStatues;
        private System.Windows.Forms.Button btnCycleApply;
        private System.Windows.Forms.CheckBox CheckStartup;
        private System.Windows.Forms.Label lblDatabaseVersion;
        private System.Windows.Forms.Button btnApplyWordsADay;
        private System.Windows.Forms.ComboBox comboWordsADay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblMasterValue;
        private System.Windows.Forms.TrackBar TrackQuestionsValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFIX;
    }
}