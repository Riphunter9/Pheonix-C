namespace ONT2000
{
    partial class ManageLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLecturer));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpModuleDate = new System.Windows.Forms.DateTimePicker();
            this.dgvLecturers = new System.Windows.Forms.DataGridView();
            this.btnAssignLecturer = new System.Windows.Forms.Button();
            this.cmbModuleDesc = new System.Windows.Forms.ComboBox();
            this.btnListLecturer = new System.Windows.Forms.Button();
            this.cmbLecturer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 67);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(266, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage\r\nLecturers\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(508, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 386);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // dtpModuleDate
            // 
            this.dtpModuleDate.Location = new System.Drawing.Point(302, 159);
            this.dtpModuleDate.Name = "dtpModuleDate";
            this.dtpModuleDate.Size = new System.Drawing.Size(200, 20);
            this.dtpModuleDate.TabIndex = 17;
            // 
            // dgvLecturers
            // 
            this.dgvLecturers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturers.Location = new System.Drawing.Point(12, 235);
            this.dgvLecturers.Name = "dgvLecturers";
            this.dgvLecturers.Size = new System.Drawing.Size(490, 232);
            this.dgvLecturers.TabIndex = 16;
            this.dgvLecturers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLecturers_CellClick);
            // 
            // btnAssignLecturer
            // 
            this.btnAssignLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAssignLecturer.FlatAppearance.BorderSize = 0;
            this.btnAssignLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignLecturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignLecturer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAssignLecturer.Location = new System.Drawing.Point(181, 194);
            this.btnAssignLecturer.Name = "btnAssignLecturer";
            this.btnAssignLecturer.Size = new System.Drawing.Size(135, 33);
            this.btnAssignLecturer.TabIndex = 14;
            this.btnAssignLecturer.Text = "Assign Lecturer";
            this.btnAssignLecturer.UseVisualStyleBackColor = false;
            this.btnAssignLecturer.Click += new System.EventHandler(this.btnAssignLecturer_Click);
            // 
            // cmbModuleDesc
            // 
            this.cmbModuleDesc.FormattingEnabled = true;
            this.cmbModuleDesc.Location = new System.Drawing.Point(200, 122);
            this.cmbModuleDesc.Name = "cmbModuleDesc";
            this.cmbModuleDesc.Size = new System.Drawing.Size(302, 21);
            this.cmbModuleDesc.TabIndex = 12;
            // 
            // btnListLecturer
            // 
            this.btnListLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListLecturer.FlatAppearance.BorderSize = 0;
            this.btnListLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListLecturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListLecturer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListLecturer.Location = new System.Drawing.Point(342, 194);
            this.btnListLecturer.Name = "btnListLecturer";
            this.btnListLecturer.Size = new System.Drawing.Size(160, 33);
            this.btnListLecturer.TabIndex = 15;
            this.btnListLecturer.Text = "List Lecturers";
            this.btnListLecturer.UseVisualStyleBackColor = false;
            this.btnListLecturer.Click += new System.EventHandler(this.btnListLecturer_Click);
            // 
            // cmbLecturer
            // 
            this.cmbLecturer.FormattingEnabled = true;
            this.cmbLecturer.Location = new System.Drawing.Point(200, 81);
            this.cmbLecturer.Name = "cmbLecturer";
            this.cmbLecturer.Size = new System.Drawing.Size(302, 21);
            this.cmbLecturer.TabIndex = 13;
            this.cmbLecturer.SelectedIndexChanged += new System.EventHandler(this.cmbLecturer_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Module Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lecturer";
            // 
            // ManageLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 486);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dtpModuleDate);
            this.Controls.Add(this.dgvLecturers);
            this.Controls.Add(this.btnAssignLecturer);
            this.Controls.Add(this.cmbModuleDesc);
            this.Controls.Add(this.btnListLecturer);
            this.Controls.Add(this.cmbLecturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageLecturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Lecturers";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpModuleDate;
        private System.Windows.Forms.Button btnAssignLecturer;
        private System.Windows.Forms.ComboBox cmbModuleDesc;
        private System.Windows.Forms.Button btnListLecturer;
        private System.Windows.Forms.ComboBox cmbLecturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView dgvLecturers;
    }
}