using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ONT2000
{
    public partial class RegisterUserControl : UserControl
    {
        public RegisterUserControl()
        {
            InitializeComponent();
        }
        Users user = new Users();
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            user.Name = txtName.Text;
            user.Surname = txtSurname.Text;
            user.Email = txtEmail.Text;
            user.Role = cmbRole.SelectedItem.ToString();
            user.Title = cmbTitle.SelectedItem.ToString();
            user.UserStatus = cmbUserStatus.SelectedItem.ToString();
            user.Password = txtPassword.Text.Trim();

            int x = bll.InsertUsers(user);
            if (x > 0)
            {
                MessageBox.Show(txtName.Text + " was added successfully");
            }

            txtName.Text="";
            txtSurname.Text="";
            txtEmail.Text="";
            cmbRole.Text = "";
            cmbTitle.Text = "";
            cmbUserStatus.Text = "";
             txtPassword.Text = "";
        }

        private void RegisterUserControl_Load(object sender, EventArgs e)
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
            
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "please enter your name");
                errorProvider1.BlinkRate=0;
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

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "please enter your Email");
                errorProvider1.BlinkRate = 0;
            }
            else if((!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                errorProvider1.SetError(txtEmail, "Wrong Email Format, e.g: user@email.com");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';

        }

        private void btnShowPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
