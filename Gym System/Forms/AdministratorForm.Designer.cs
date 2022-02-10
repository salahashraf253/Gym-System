namespace Gym_System.Forms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewAllMemberInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addTrainerBtn
            // 
            this.addTrainerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTrainerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.addTrainerBtn.Location = new System.Drawing.Point(12, 12);
            this.addTrainerBtn.Name = "addTrainerBtn";
            this.addTrainerBtn.Size = new System.Drawing.Size(277, 158);
            this.addTrainerBtn.TabIndex = 0;
            this.addTrainerBtn.Text = "Add / Edit / Delete trainer";
            this.addTrainerBtn.UseVisualStyleBackColor = true;
            this.addTrainerBtn.Click += new System.EventHandler(this.addTrainerBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(399, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 616);
            this.dataGridView1.TabIndex = 1;
            // 
            // viewAllMemberInfo
            // 
            this.viewAllMemberInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllMemberInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.viewAllMemberInfo.Location = new System.Drawing.Point(12, 198);
            this.viewAllMemberInfo.Name = "viewAllMemberInfo";
            this.viewAllMemberInfo.Size = new System.Drawing.Size(277, 158);
            this.viewAllMemberInfo.TabIndex = 2;
            this.viewAllMemberInfo.Text = "View all members";
            this.viewAllMemberInfo.UseVisualStyleBackColor = true;
            this.viewAllMemberInfo.Click += new System.EventHandler(this.viewAllMemberInfo_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1300, 723);
            this.Controls.Add(this.viewAllMemberInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addTrainerBtn);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTrainerBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewAllMemberInfo;
    }
}