namespace ONT2000
{
    partial class ManageStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudents));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStudModuleDate = new System.Windows.Forms.DateTimePicker();
            this.cmbModuleDesc = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplayStudFromMod = new System.Windows.Forms.Button();
            this.btnAddStudtoModule = new System.Windows.Forms.Button();
            this.lblModuleHeading = new System.Windows.Forms.Label();
            this.dgvAddedStud = new System.Windows.Forms.DataGridView();
            this.dgvAllStud = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStud)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 70);
            this.panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(0, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 70);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(295, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Students";
            // 
            // dtpStudModuleDate
            // 
            this.dtpStudModuleDate.Location = new System.Drawing.Point(246, 165);
            this.dtpStudModuleDate.Name = "dtpStudModuleDate";
            this.dtpStudModuleDate.Size = new System.Drawing.Size(217, 20);
            this.dtpStudModuleDate.TabIndex = 34;
            // 
            // cmbModuleDesc
            // 
            this.cmbModuleDesc.FormattingEnabled = true;
            this.cmbModuleDesc.Location = new System.Drawing.Point(198, 128);
            this.cmbModuleDesc.Name = "cmbModuleDesc";
            this.cmbModuleDesc.Size = new System.Drawing.Size(265, 21);
            this.cmbModuleDesc.TabIndex = 32;
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(198, 87);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(265, 21);
            this.cmbStudent.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Module Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Student";
            // 
            // btnDisplayStudFromMod
            // 
            this.btnDisplayStudFromMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDisplayStudFromMod.FlatAppearance.BorderSize = 0;
            this.btnDisplayStudFromMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayStudFromMod.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayStudFromMod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDisplayStudFromMod.Location = new System.Drawing.Point(306, 228);
            this.btnDisplayStudFromMod.Name = "btnDisplayStudFromMod";
            this.btnDisplayStudFromMod.Size = new System.Drawing.Size(135, 43);
            this.btnDisplayStudFromMod.TabIndex = 27;
            this.btnDisplayStudFromMod.Text = "List Students";
            this.btnDisplayStudFromMod.UseVisualStyleBackColor = false;
            this.btnDisplayStudFromMod.Click += new System.EventHandler(this.btnDisplayStudFromMod_Click);
            // 
            // btnAddStudtoModule
            // 
            this.btnAddStudtoModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddStudtoModule.FlatAppearance.BorderSize = 0;
            this.btnAddStudtoModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudtoModule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudtoModule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddStudtoModule.Location = new System.Drawing.Point(71, 228);
            this.btnAddStudtoModule.Name = "btnAddStudtoModule";
            this.btnAddStudtoModule.Size = new System.Drawing.Size(138, 43);
            this.btnAddStudtoModule.TabIndex = 28;
            this.btnAddStudtoModule.Text = "Add Student";
            this.btnAddStudtoModule.UseVisualStyleBackColor = false;
            this.btnAddStudtoModule.Click += new System.EventHandler(this.btnAddStudtoModule_Click);
            // 
            // lblModuleHeading
            // 
            this.lblModuleHeading.AutoSize = true;
            this.lblModuleHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleHeading.Location = new System.Drawing.Point(491, 113);
            this.lblModuleHeading.Name = "lblModuleHeading";
            this.lblModuleHeading.Size = new System.Drawing.Size(121, 25);
            this.lblModuleHeading.TabIndex = 26;
            this.lblModuleHeading.Text = "Students for ";
            // 
            // dgvAddedStud
            // 
            this.dgvAddedStud.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAddedStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedStud.Location = new System.Drawing.Point(496, 141);
            this.dgvAddedStud.Name = "dgvAddedStud";
            this.dgvAddedStud.Size = new System.Drawing.Size(441, 316);
            this.dgvAddedStud.TabIndex = 25;
            // 
            // dgvAllStud
            // 
            this.dgvAllStud.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAllStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStud.Location = new System.Drawing.Point(14, 286);
            this.dgvAllStud.Name = "dgvAllStud";
            this.dgvAllStud.Size = new System.Drawing.Size(449, 171);
            this.dgvAllStud.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(637, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "label5";
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 470);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvAllStud);
            this.Controls.Add(this.dtpStudModuleDate);
            this.Controls.Add(this.cmbModuleDesc);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisplayStudFromMod);
            this.Controls.Add(this.btnAddStudtoModule);
            this.Controls.Add(this.lblModuleHeading);
            this.Controls.Add(this.dgvAddedStud);
            this.Controls.Add(this.panel1);
            this.Name = "ManageStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudents";
            this.Load += new System.EventHandler(this.ManageStudents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpStudModuleDate;
        private System.Windows.Forms.ComboBox cmbModuleDesc;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisplayStudFromMod;
        private System.Windows.Forms.Button btnAddStudtoModule;
        private System.Windows.Forms.DataGridView dgvAllStud;
        public System.Windows.Forms.Label lblModuleHeading;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.DataGridView dgvAddedStud;
    }
}