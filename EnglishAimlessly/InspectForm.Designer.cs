namespace EnglishAimlessly
{
    partial class InspectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblGroup = new System.Windows.Forms.Label();
            this.btnExamples = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblPracticed = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.pnlAnswers = new System.Windows.Forms.Panel();
            this.lblEquivalent = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlAnswers.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Controls.Add(this.lblGroup);
            this.pnlMain.Controls.Add(this.btnExamples);
            this.pnlMain.Controls.Add(this.btnContinue);
            this.pnlMain.Controls.Add(this.lblPracticed);
            this.pnlMain.Controls.Add(this.lblWord);
            this.pnlMain.Controls.Add(this.pnlAnswers);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1300, 620);
            this.pnlMain.TabIndex = 1;
            // 
            // lblGroup
            // 
            this.lblGroup.Location = new System.Drawing.Point(30, 98);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(1225, 33);
            this.lblGroup.TabIndex = 10;
            this.lblGroup.Text = "Group";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExamples
            // 
            this.btnExamples.BackColor = System.Drawing.Color.White;
            this.btnExamples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamples.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnExamples.Location = new System.Drawing.Point(969, 530);
            this.btnExamples.Name = "btnExamples";
            this.btnExamples.Size = new System.Drawing.Size(142, 44);
            this.btnExamples.TabIndex = 6;
            this.btnExamples.Text = "My Examples";
            this.btnExamples.UseVisualStyleBackColor = false;
            this.btnExamples.Click += new System.EventHandler(this.btnExamples_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Green;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(1117, 530);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(142, 44);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "OK";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblPracticed
            // 
            this.lblPracticed.AutoSize = true;
            this.lblPracticed.Location = new System.Drawing.Point(40, 574);
            this.lblPracticed.Name = "lblPracticed";
            this.lblPracticed.Size = new System.Drawing.Size(99, 20);
            this.lblPracticed.TabIndex = 4;
            this.lblPracticed.Text = "Practiced: 0";
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(29, 58);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(1230, 40);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Word (Type)";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAnswers.Controls.Add(this.lblEquivalent);
            this.pnlAnswers.Controls.Add(this.lblDescription);
            this.pnlAnswers.Location = new System.Drawing.Point(34, 134);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Size = new System.Drawing.Size(1225, 390);
            this.pnlAnswers.TabIndex = 0;
            // 
            // lblEquivalent
            // 
            this.lblEquivalent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquivalent.Location = new System.Drawing.Point(3, 0);
            this.lblEquivalent.Name = "lblEquivalent";
            this.lblEquivalent.Size = new System.Drawing.Size(1215, 32);
            this.lblEquivalent.TabIndex = 5;
            this.lblEquivalent.Text = "Equivalent";
            this.lblEquivalent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(21, 41);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(1185, 343);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Black;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(-4, 11);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(247, 38);
            this.pnlTitle.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 38);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Inspect #1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InspectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 620);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InspectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InspectForm";
            this.Load += new System.EventHandler(this.InspectForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlAnswers.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblPracticed;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Panel pnlAnswers;
        private System.Windows.Forms.Label lblEquivalent;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnExamples;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}