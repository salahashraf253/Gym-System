﻿namespace Gym_System.Forms
{
    partial class AdministratorForm
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
            this.addTrainerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTrainerBtn
            // 
            this.addTrainerBtn.Location = new System.Drawing.Point(355, 259);
            this.addTrainerBtn.Name = "addTrainerBtn";
            this.addTrainerBtn.Size = new System.Drawing.Size(277, 158);
            this.addTrainerBtn.TabIndex = 0;
            this.addTrainerBtn.Text = "Add trainer";
            this.addTrainerBtn.UseVisualStyleBackColor = true;
            this.addTrainerBtn.Click += new System.EventHandler(this.addTrainerBtn_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1300, 723);
            this.Controls.Add(this.addTrainerBtn);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTrainerBtn;
    }
}