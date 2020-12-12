
namespace EnglishAimlessly
{
    partial class ResultItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlIndicator = new System.Windows.Forms.Panel();
            this.lblQuestionCounter = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlIndicator
            // 
            this.pnlIndicator.BackColor = System.Drawing.Color.Green;
            this.pnlIndicator.Location = new System.Drawing.Point(734, -1);
            this.pnlIndicator.Name = "pnlIndicator";
            this.pnlIndicator.Size = new System.Drawing.Size(54, 71);
            this.pnlIndicator.TabIndex = 5;
            // 
            // lblQuestionCounter
            // 
            this.lblQuestionCounter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCounter.Location = new System.Drawing.Point(15, 35);
            this.lblQuestionCounter.Name = "lblQuestionCounter";
            this.lblQuestionCounter.Size = new System.Drawing.Size(604, 29);
            this.lblQuestionCounter.TabIndex = 4;
            this.lblQuestionCounter.Text = "Question 0";
            this.lblQuestionCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(14, 5);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(604, 29);
            this.lblWord.TabIndex = 3;
            this.lblWord.Text = "Word (Type)";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ResultItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlIndicator);
            this.Controls.Add(this.lblQuestionCounter);
            this.Controls.Add(this.lblWord);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ResultItem";
            this.Size = new System.Drawing.Size(788, 69);
            this.Load += new System.EventHandler(this.ResultItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIndicator;
        private System.Windows.Forms.Label lblQuestionCounter;
        private System.Windows.Forms.Label lblWord;
    }
}
