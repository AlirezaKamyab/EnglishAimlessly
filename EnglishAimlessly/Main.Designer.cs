namespace EnglishAimlessly
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lnkExamples = new System.Windows.Forms.LinkLabel();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblPracticed = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.pnlAnswers = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.WebBrowser();
            this.BackgroundLoader = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Controls.Add(this.lblGroup);
            this.pnlMain.Controls.Add(this.lnkExamples);
            this.pnlMain.Controls.Add(this.txtExample);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnNext);
            this.pnlMain.Controls.Add(this.btnSkip);
            this.pnlMain.Controls.Add(this.btnContinue);
            this.pnlMain.Controls.Add(this.lblPracticed);
            this.pnlMain.Controls.Add(this.lblWord);
            this.pnlMain.Controls.Add(this.pnlAnswers);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1400, 650);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Black;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(-3, 8);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(247, 38);
            this.pnlTitle.TabIndex = 16;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 38);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Learn Normal Mode";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroup
            // 
            this.lblGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(30, 98);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(1336, 33);
            this.lblGroup.TabIndex = 9;
            this.lblGroup.Text = "Group";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkExamples
            // 
            this.lnkExamples.AutoSize = true;
            this.lnkExamples.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkExamples.Location = new System.Drawing.Point(30, 559);
            this.lnkExamples.Name = "lnkExamples";
            this.lnkExamples.Size = new System.Drawing.Size(238, 23);
            this.lnkExamples.TabIndex = 1;
            this.lnkExamples.TabStop = true;
            this.lnkExamples.Text = "Inspect My Previous Examples";
            this.lnkExamples.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExamples_LinkClicked);
            // 
            // txtExample
            // 
            this.txtExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExample.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExample.ForeColor = System.Drawing.Color.Blue;
            this.txtExample.Location = new System.Drawing.Point(34, 496);
            this.txtExample.Multiline = true;
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(1332, 60);
            this.txtExample.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Make your own example:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Teal;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1114, 562);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 44);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(1028, 562);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(80, 44);
            this.btnSkip.TabIndex = 4;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Green;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(1224, 562);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(142, 44);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblPracticed
            // 
            this.lblPracticed.AutoSize = true;
            this.lblPracticed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPracticed.Location = new System.Drawing.Point(30, 617);
            this.lblPracticed.Name = "lblPracticed";
            this.lblPracticed.Size = new System.Drawing.Size(98, 23);
            this.lblPracticed.TabIndex = 4;
            this.lblPracticed.Text = "Practiced: 0";
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(29, 63);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(1337, 35);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Word (Type)";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAnswers.Controls.Add(this.lblDescription);
            this.pnlAnswers.Location = new System.Drawing.Point(34, 137);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Size = new System.Drawing.Size(1332, 333);
            this.pnlAnswers.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AllowNavigation = false;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.IsWebBrowserContextMenuEnabled = false;
            this.lblDescription.Location = new System.Drawing.Point(0, 0);
            this.lblDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(1330, 331);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Url = new System.Uri("", System.UriKind.Relative);
            this.lblDescription.WebBrowserShortcutsEnabled = false;
            // 
            // BackgroundLoader
            // 
            this.BackgroundLoader.Interval = 300;
            this.BackgroundLoader.Tick += new System.EventHandler(this.BackgroundLoader_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 650);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlAnswers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblPracticed;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Panel pnlAnswers;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer BackgroundLoader;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkExamples;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.WebBrowser lblDescription;
    }
}