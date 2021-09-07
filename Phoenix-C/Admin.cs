using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT2000
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        ManageLecturer manageForm = new ManageLecturer();
       


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

      

        private void btnManageLect_Click(object sender, EventArgs e)
        {
            ManageLecturer lectForm = new ManageLecturer();
            lectForm.Show();
            this.Hide();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            DataTable dt = Form1.dtLog;
            label2.Text = "WELCOME: "+dt.Rows[0]["Name"].ToString().ToUpper() + " " + dt.Rows[0]["Surname"].ToString().ToUpper();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers users = new ManageUsers();
            users.Show();
            this.Hide();
        }

        private void btnManageModules_Click(object sender, EventArgs e)
        {
            ManageModules modules = new ManageModules();
            modules.Show();
            this.Hide();
        }
    }
}
