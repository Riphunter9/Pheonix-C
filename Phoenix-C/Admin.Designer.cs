namespace ONT2000
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageModules = new System.Windows.Forms.Button();
            this.btnManageLect = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 91);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(553, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(-1, -1);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 91);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out\r\n";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(358, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.BackgroundImage")));
            this.btnManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageUsers.Location = new System.Drawing.Point(288, 95);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(288, 202);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage \r\nUsers";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageModules
            // 
            this.btnManageModules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageModules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageModules.BackgroundImage")));
            this.btnManageModules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageModules.FlatAppearance.BorderSize = 0;
            this.btnManageModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageModules.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageModules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageModules.Location = new System.Drawing.Point(582, 92);
            this.btnManageModules.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnManageModules.Name = "btnManageModules";
            this.btnManageModules.Size = new System.Drawing.Size(247, 205);
            this.btnManageModules.TabIndex = 0;
            this.btnManageModules.Text = "Manage\r\nModules";
            this.btnManageModules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageModules.UseVisualStyleBackColor = false;
            this.btnManageModules.Click += new System.EventHandler(this.btnManageModules_Click);
            // 
            // btnManageLect
            // 
            this.btnManageLect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageLect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageLect.BackgroundImage")));
            this.btnManageLect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageLect.FlatAppearance.BorderSize = 0;
            this.btnManageLect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLect.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageLect.Location = new System.Drawing.Point(7, 94);
            this.btnManageLect.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnManageLect.Name = "btnManageLect";
            this.btnManageLect.Size = new System.Drawing.Size(275, 205);
            this.btnManageLect.TabIndex = 0;
            this.btnManageLect.Text = "Manage\r\nLecturers";
            this.btnManageLect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageLect.UseVisualStyleBackColor = false;
            this.btnManageLect.Click += new System.EventHandler(this.btnManageLect_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageModules);
            this.Controls.Add(this.btnManageLect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageLect;
        private System.Windows.Forms.Button btnManageModules;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Label label2;
    }
}