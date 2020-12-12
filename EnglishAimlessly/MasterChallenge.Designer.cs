
namespace EnglishAimlessly
{
    partial class MasterChallenge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterChallenge));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDunno = new System.Windows.Forms.Button();
            this.btnNotSure = new System.Windows.Forms.Button();
            this.btnIKnow = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.loader = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnDunno);
            this.panel1.Controls.Add(this.btnNotSure);
            this.panel1.Controls.Add(this.btnIKnow);
            this.panel1.Controls.Add(this.lblCounter);
            this.panel1.Controls.Add(this.lblWord);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 553);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(-3, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 41);
            this.panel2.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 41);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Master Challenge";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDunno
            // 
            this.btnDunno.BackColor = System.Drawing.Color.Red;
            this.btnDunno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDunno.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDunno.ForeColor = System.Drawing.Color.White;
            this.btnDunno.Location = new System.Drawing.Point(367, 380);
            this.btnDunno.Name = "btnDunno";
            this.btnDunno.Size = new System.Drawing.Size(142, 47);
            this.btnDunno.TabIndex = 13;
            this.btnDunno.Text = "I don\'t know";
            this.btnDunno.UseVisualStyleBackColor = false;
            this.btnDunno.Click += new System.EventHandler(this.btnDunno_Click);
            // 
            // btnNotSure
            // 
            this.btnNotSure.BackColor = System.Drawing.Color.Orange;
            this.btnNotSure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotSure.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotSure.ForeColor = System.Drawing.Color.White;
            this.btnNotSure.Location = new System.Drawing.Point(515, 380);
            this.btnNotSure.Name = "btnNotSure";
            this.btnNotSure.Size = new System.Drawing.Size(142, 47);
            this.btnNotSure.TabIndex = 12;
            this.btnNotSure.Text = "Not Sure";
            this.btnNotSure.UseVisualStyleBackColor = false;
            this.btnNotSure.Click += new System.EventHandler(this.btnNotSure_Click);
            // 
            // btnIKnow
            // 
            this.btnIKnow.BackColor = System.Drawing.Color.Green;
            this.btnIKnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIKnow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIKnow.ForeColor = System.Drawing.Color.White;
            this.btnIKnow.Location = new System.Drawing.Point(663, 380);
            this.btnIKnow.Name = "btnIKnow";
            this.btnIKnow.Size = new System.Drawing.Size(142, 47);
            this.btnIKnow.TabIndex = 11;
            this.btnIKnow.Text = "I know";
            this.btnIKnow.UseVisualStyleBackColor = false;
            this.btnIKnow.Click += new System.EventHandler(this.btnIKnow_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.Location = new System.Drawing.Point(18, 217);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(1152, 27);
            this.lblCounter.TabIndex = 10;
            this.lblCounter.Text = "Question 0 out of 0";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(12, 130);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(1158, 57);
            this.lblWord.TabIndex = 9;
            this.lblWord.Text = "Word (Type)";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1120, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // loader
            // 
            this.loader.Interval = 500;
            this.loader.Tick += new System.EventHandler(this.loader_Tick);
            // 
            // MasterChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MasterChallenge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterChallenge";
            this.Load += new System.EventHandler(this.MasterChallenge_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnDunno;
        private System.Windows.Forms.Button btnNotSure;
        private System.Windows.Forms.Button btnIKnow;
        private System.Windows.Forms.Timer loader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
    }
}