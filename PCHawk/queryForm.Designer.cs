﻿namespace PCHawk
{
    partial class queryForm
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
            this.bttnTwoTable = new System.Windows.Forms.Button();
            this.bttnThreeTable = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.partBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnTwoTable
            // 
            this.bttnTwoTable.Location = new System.Drawing.Point(13, 159);
            this.bttnTwoTable.Name = "bttnTwoTable";
            this.bttnTwoTable.Size = new System.Drawing.Size(127, 75);
            this.bttnTwoTable.TabIndex = 0;
            this.bttnTwoTable.Text = "Two Table Join";
            this.bttnTwoTable.UseVisualStyleBackColor = true;
            // 
            // bttnThreeTable
            // 
            this.bttnThreeTable.Location = new System.Drawing.Point(12, 240);
            this.bttnThreeTable.Name = "bttnThreeTable";
            this.bttnThreeTable.Size = new System.Drawing.Size(127, 75);
            this.bttnThreeTable.TabIndex = 1;
            this.bttnThreeTable.Text = "Three Table Join";
            this.bttnThreeTable.UseVisualStyleBackColor = true;
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(12, 42);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(127, 64);
            this.bttnExit.TabIndex = 3;
            this.bttnExit.Text = "Close Page";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(145, 42);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(553, 407);
            this.displayBox.TabIndex = 4;
            this.displayBox.Text = "";
            // 
            // partBox
            // 
            this.partBox.FormattingEnabled = true;
            this.partBox.Items.AddRange(new object[] {
            "CPU",
            "Case",
            "Cooling",
            "Graphics Card",
            "Power Supply",
            "Motherboard",
            "Memory",
            "Storage"});
            this.partBox.Location = new System.Drawing.Point(13, 375);
            this.partBox.Name = "partBox";
            this.partBox.Size = new System.Drawing.Size(121, 21);
            this.partBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Average Price of Part";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CPU",
            "Case",
            "Cooling",
            "Graphics Card",
            "Power Supply",
            "Motherboard",
            "Memory",
            "Storage"});
            this.comboBox1.Location = new System.Drawing.Point(13, 415);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Part Requests";
            // 
            // queryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partBox);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnThreeTable);
            this.Controls.Add(this.bttnTwoTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "queryForm";
            this.Text = "queryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnTwoTable;
        private System.Windows.Forms.Button bttnThreeTable;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.ComboBox partBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}