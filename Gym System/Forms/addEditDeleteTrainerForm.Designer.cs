namespace Gym_System.Forms
{
    partial class addEditDeleteTrainerForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.editTrainerBtn = new System.Windows.Forms.Button();
            this.deleteTrainerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.button1.Location = new System.Drawing.Point(171, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "add trainer ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editTrainerBtn
            // 
            this.editTrainerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTrainerBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTrainerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.editTrainerBtn.Location = new System.Drawing.Point(171, 189);
            this.editTrainerBtn.Name = "editTrainerBtn";
            this.editTrainerBtn.Size = new System.Drawing.Size(135, 75);
            this.editTrainerBtn.TabIndex = 1;
            this.editTrainerBtn.Text = "edit trainer";
            this.editTrainerBtn.UseVisualStyleBackColor = false;
            // 
            // deleteTrainerBtn
            // 
            this.deleteTrainerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTrainerBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTrainerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.deleteTrainerBtn.Location = new System.Drawing.Point(171, 295);
            this.deleteTrainerBtn.Name = "deleteTrainerBtn";
            this.deleteTrainerBtn.Size = new System.Drawing.Size(135, 75);
            this.deleteTrainerBtn.TabIndex = 2;
            this.deleteTrainerBtn.Text = "delete trainer";
            this.deleteTrainerBtn.UseVisualStyleBackColor = false;
            // 
            // addEditDeleteTrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(472, 517);
            this.Controls.Add(this.deleteTrainerBtn);
            this.Controls.Add(this.editTrainerBtn);
            this.Controls.Add(this.button1);
            this.Name = "addEditDeleteTrainerForm";
            this.Text = "add Edit Delete Trainer Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editTrainerBtn;
        private System.Windows.Forms.Button deleteTrainerBtn;
    }
}