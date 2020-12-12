
namespace EnglishAimlessly
{
    partial class MasterResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterResults));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdateRed = new System.Windows.Forms.Button();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.pnlFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.resultItem1 = new EnglishAimlessly.ResultItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnYellow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlFlowPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnYellow);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnUpdateRed);
            this.panel1.Controls.Add(this.btnUpdateAll);
            this.panel1.Controls.Add(this.pnlFlowPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 600);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(834, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 98);
            this.label1.TabIndex = 20;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(953, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(193, 47);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnUpdateRed
            // 
            this.btnUpdateRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRed.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRed.Location = new System.Drawing.Point(953, 294);
            this.btnUpdateRed.Name = "btnUpdateRed";
            this.btnUpdateRed.Size = new System.Drawing.Size(193, 47);
            this.btnUpdateRed.TabIndex = 18;
            this.btnUpdateRed.Text = "Update Red ones";
            this.btnUpdateRed.UseVisualStyleBackColor = false;
            this.btnUpdateRed.Click += new System.EventHandler(this.btnUpdateRed_Click);
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.BackColor = System.Drawing.Color.Green;
            this.btnUpdateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAll.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAll.Location = new System.Drawing.Point(953, 241);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(193, 47);
            this.btnUpdateAll.TabIndex = 17;
            this.btnUpdateAll.Text = "Update All";
            this.btnUpdateAll.UseVisualStyleBackColor = false;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // pnlFlowPanel
            // 
            this.pnlFlowPanel.AutoScroll = true;
            this.pnlFlowPanel.Controls.Add(this.resultItem1);
            this.pnlFlowPanel.Location = new System.Drawing.Point(11, 84);
            this.pnlFlowPanel.Name = "pnlFlowPanel";
            this.pnlFlowPanel.Size = new System.Drawing.Size(817, 503);
            this.pnlFlowPanel.TabIndex = 16;
            // 
            // resultItem1
            // 
            this.resultItem1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultItem1.BackColor = System.Drawing.Color.Transparent;
            this.resultItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultItem1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultItem1.Indicator = System.Drawing.Color.DarkGreen;
            this.resultItem1.Location = new System.Drawing.Point(3, 3);
            this.resultItem1.Name = "resultItem1";
            this.resultItem1.Question = "Question 0";
            this.resultItem1.Size = new System.Drawing.Size(788, 69);
            this.resultItem1.TabIndex = 0;
            this.resultItem1.Word = "Word1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(-2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 38);
            this.panel2.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 25);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Master Results";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYellow.ForeColor = System.Drawing.Color.White;
            this.btnYellow.Location = new System.Drawing.Point(953, 347);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(193, 47);
            this.btnYellow.TabIndex = 21;
            this.btnYellow.Text = "Update Yellow ones";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // MasterResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 600);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MasterResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterResults";
            this.Load += new System.EventHandler(this.MasterResults_Load);
            this.panel1.ResumeLayout(false);
            this.pnlFlowPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlFlowPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private ResultItem resultItem1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdateRed;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYellow;
    }
}