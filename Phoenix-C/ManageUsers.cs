using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL;
using BLL;


namespace ONT2000
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        public static string usertype;
        BusinessLogicLayer bll = new BusinessLogicLayer();
        Users user = new Users();
        DataTable dt = new DataTable();
        public static DataTable dtLog;

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnShowPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "please enter your Email");
                errorProvider1.BlinkRate = 0;
            }
            else if ((!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                errorProvider1.SetError(txtEmail, "Wrong Email Format, e.g: user@email.com");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            cmbTitle.Items.Add("Mr");
            cmbTitle.Items.Add("Ms");
            cmbTitle.Items.Add("Mrs");
            cmbTitle.Items.Add("Dr");
            cmbTitle.Items.Add("Prof");

            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");

            cmbUserStatus.Items.Add("Active");
            cmbUserStatus.Items.Add("Inactive");

            cmbDetails.Items.Add("Role");
            cmbDetails.Items.Add("Name & Surname");
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "please enter your name");
                errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errorProvider1.SetError(txtSurname, "please enter your surname");
                errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnADDUser_Click(object sender, EventArgs e)
        {
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text.ToString().Trim();
            user.Name = txtName.Text;
            user.Role = cmbRole.SelectedItem.ToString();
            user.Surname = txtSurname.Text;
            user.Title = cmbTitle.SelectedItem.ToString();
            user.UserStatus = cmbUserStatus.SelectedItem.ToString();

            int x = bll.InsertUsers(user);
            dtLog = dt;
            if (x > 0)
            {
                MessageBox.Show(txtName.Text + " was added.");
            }
            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
            cmbRole.Text = "";
            cmbTitle.Text = "";
            cmbUserStatus.Text = "";
            txtPassword.Text = "";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            user.Name = txtName.Text;
            user.Surname = txtSurname.Text;


            DataTable data = new DataTable();
            data = bll.SearchUserByName(user);
            if (data.Rows.Count > 0)
            {
                dgvUsers.DataSource = data;
            }
            else if (data.Rows.Count == 0)
            {
                MessageBox.Show(txtName.Text + " " + txtSurname.Text + " " + "was not found");
               
            }

        }

        private void cmbDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDetails.SelectedIndex == 0)
            {
                txtEmail.Enabled = false;
                txtName.Enabled = false;
                txtPassword.Enabled = false;
                cmbTitle.Enabled = false;
                cmbUserStatus.Enabled = false;
                txtSurname.Enabled = false;
                cmbRole.Enabled = true;
                cmbRole.Focus();
            }
            else if (cmbDetails.SelectedIndex == 1)
            {
                txtName.Enabled = true;
                txtSurname.Enabled = true;
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
                cmbTitle.Enabled = false;
                cmbUserStatus.Enabled = false;
                cmbRole.Enabled = false;
                txtName.Focus();
            }
            
           
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.Role = cmbRole.SelectedItem.ToString();

            dt = bll.SearchUser(user);
            if (dt.Rows.Count > 0)
            {
                dgvUsers.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin form = new Admin();
            form.Show();
            this.Close();
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
           
            dgvUsers.DataSource= bll.ListAllUsers();
        }

       

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = bll.ListAllUsers();
                txtName.Text = dgvUsers.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvUsers.SelectedRows[0].Cells["Surname"].Value.ToString();

                cmbUserStatus.Text = dgvUsers.SelectedRows[0].Cells["UserStatus"].Value.ToString();
                
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtPassword.Enabled = false;
                txtEmail.Enabled = false;
                cmbTitle.Enabled = false;
                cmbRole.Enabled = false;
            }

           
        }//showing user details you click on the dgv

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            user.UserStatus = cmbUserStatus.SelectedItem.ToString();
            user.UserID = int.Parse(dgvUsers.SelectedRows[0].Cells["UserID"].Value.ToString());
            int x = bll.UpdateUsers(user);

            if (x > 0)
            {
                MessageBox.Show(txtName.Text+" "+txtSurname.Text+ " is Updated.");
                dgvUsers.DataSource = bll.ListAllUsers();
                
            }
        }
    }
}
