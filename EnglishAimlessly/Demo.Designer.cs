﻿namespace EnglishAimlessly
{
    partial class Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.item_Word1 = new EnglishAimlessly.Item_Word();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 136);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 136);
            this.button2.TabIndex = 1;
            this.button2.Text = "Word of the day";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1090, 284);
            this.label1.TabIndex = 2;
            this.label1.Text = "0 Days";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // item_Word1
            // 
            this.item_Word1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.item_Word1.BackColor = System.Drawing.Color.Transparent;
            this.item_Word1.BackgroundColor = System.Drawing.Color.Yellow;
            this.item_Word1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item_Word1.Description = "fsafsadf and there sdf was yet something else bothering me\\nsomething awful";
            this.item_Word1.DescriptionColor = System.Drawing.Color.Black;
            this.item_Word1.Location = new System.Drawing.Point(228, 154);
            this.item_Word1.Name = "item_Word1";
            this.item_Word1.Size = new System.Drawing.Size(566, 104);
            this.item_Word1.TabIndex = 3;
            this.item_Word1.Title = "Conclusive";
            this.item_Word1.TitleColor = System.Drawing.Color.Black;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 479);
            this.Controls.Add(this.item_Word1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Demo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Item_Word item_Word1;
    }
}

