namespace Gym_System.Forms
{
    partial class EmployeeForm
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
            this.viewMembersInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewMembersWithClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewMembersInfo
            // 
            this.viewMembersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMembersInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMembersInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.viewMembersInfo.Location = new System.Drawing.Point(37, 35);
            this.viewMembersInfo.Name = "viewMembersInfo";
            this.viewMembersInfo.Size = new System.Drawing.Size(198, 84);
            this.viewMembersInfo.TabIndex = 0;
            this.viewMembersInfo.Text = "view members";
            this.viewMembersInfo.UseVisualStyleBackColor = true;
            this.viewMembersInfo.Click += new System.EventHandler(this.viewMembersInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.Location = new System.Drawing.Point(395, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 605);
            this.dataGridView1.TabIndex = 1;
            // 
            // viewMembersWithClass
            // 
            this.viewMembersWithClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMembersWithClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMembersWithClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.viewMembersWithClass.Location = new System.Drawing.Point(37, 150);
            this.viewMembersWithClass.Name = "viewMembersWithClass";
            this.viewMembersWithClass.Size = new System.Drawing.Size(198, 83);
            this.viewMembersWithClass.TabIndex = 2;
            this.viewMembersWithClass.Text = "view members in a specific class\r\n";
            this.viewMembersWithClass.UseVisualStyleBackColor = true;
            this.viewMembersWithClass.Click += new System.EventHandler(this.viewMembersWithClass_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1387, 764);
            this.Controls.Add(this.viewMembersWithClass);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewMembersInfo);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewMembersInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewMembersWithClass;
    }
}