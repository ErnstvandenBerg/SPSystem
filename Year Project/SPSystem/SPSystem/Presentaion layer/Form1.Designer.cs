﻿namespace SPSystem
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
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxTotalDuration = new System.Windows.Forms.TextBox();
            this.tboxTimeOUT = new System.Windows.Forms.TextBox();
            this.tboxTimeIN = new System.Windows.Forms.TextBox();
            this.tboxNumberPlate = new System.Windows.Forms.TextBox();
            this.tboxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Light", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(712, 40);
            this.label7.TabIndex = 53;
            this.label7.Text = "Welcome to Smart Parking System";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 290);
            this.listBox1.TabIndex = 52;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 30);
            this.button1.TabIndex = 51;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 21);
            this.label6.TabIndex = 50;
            this.label6.Text = "Total Duration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Time Out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Time In:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Number plate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "User:";
            // 
            // tboxTotalDuration
            // 
            this.tboxTotalDuration.Location = new System.Drawing.Point(621, 334);
            this.tboxTotalDuration.Name = "tboxTotalDuration";
            this.tboxTotalDuration.Size = new System.Drawing.Size(169, 20);
            this.tboxTotalDuration.TabIndex = 45;
            // 
            // tboxTimeOUT
            // 
            this.tboxTimeOUT.Location = new System.Drawing.Point(621, 294);
            this.tboxTimeOUT.Name = "tboxTimeOUT";
            this.tboxTimeOUT.Size = new System.Drawing.Size(169, 20);
            this.tboxTimeOUT.TabIndex = 44;
            // 
            // tboxTimeIN
            // 
            this.tboxTimeIN.Location = new System.Drawing.Point(621, 259);
            this.tboxTimeIN.Name = "tboxTimeIN";
            this.tboxTimeIN.Size = new System.Drawing.Size(169, 20);
            this.tboxTimeIN.TabIndex = 43;
            // 
            // tboxNumberPlate
            // 
            this.tboxNumberPlate.Location = new System.Drawing.Point(621, 217);
            this.tboxNumberPlate.Name = "tboxNumberPlate";
            this.tboxNumberPlate.Size = new System.Drawing.Size(169, 20);
            this.tboxNumberPlate.TabIndex = 42;
            // 
            // tboxUser
            // 
            this.tboxUser.Location = new System.Drawing.Point(621, 177);
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(169, 20);
            this.tboxUser.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Parking System Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxTotalDuration);
            this.Controls.Add(this.tboxTimeOUT);
            this.Controls.Add(this.tboxTimeIN);
            this.Controls.Add(this.tboxNumberPlate);
            this.Controls.Add(this.tboxUser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxTotalDuration;
        private System.Windows.Forms.TextBox tboxTimeOUT;
        private System.Windows.Forms.TextBox tboxTimeIN;
        private System.Windows.Forms.TextBox tboxNumberPlate;
        private System.Windows.Forms.TextBox tboxUser;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

