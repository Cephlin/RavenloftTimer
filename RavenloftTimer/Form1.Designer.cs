﻿using System;
using System.Windows.Forms;

namespace RavenloftTimer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.TimerUpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time and date";
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(148, 187);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownHour.TabIndex = 3;
            this.numericUpDownHour.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownHour_KeyDown);
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Location = new System.Drawing.Point(96, 187);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.numericUpDownDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDay.TabIndex = 2;
            this.numericUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownDay_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 360000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Month";
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(44, 187);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownMonth.TabIndex = 1;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownMonth_KeyDown);
            // 
            // TimerUpdateButton
            // 
            this.TimerUpdateButton.Location = new System.Drawing.Point(200, 187);
            this.TimerUpdateButton.Name = "TimerUpdateButton";
            this.TimerUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.TimerUpdateButton.TabIndex = 4;
            this.TimerUpdateButton.Text = "Update";
            this.TimerUpdateButton.UseVisualStyleBackColor = true;
            this.TimerUpdateButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 247);
            this.Controls.Add(this.TimerUpdateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownDay);
            this.Controls.Add(this.numericUpDownHour);
            this.Controls.Add(this.label1);
            this.Name = "Ravenloft Timer";
            this.Text = "Ravenloft Timer by Cephlin";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
        private System.Windows.Forms.Timer timer1;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Test!";
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.Button TimerUpdateButton;
    }
}

