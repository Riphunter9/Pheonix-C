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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public static string usertype;
        public static string userStatus;
        BusinessLogicLayer bll = new BusinessLogicLayer();
        Users user = new Users();
        DataTable dt = new DataTable();
        public static DataTable dtLog ;

        private void Form1_Load(object sender, EventArgs e)
        {
            registerUserControl1.Hide();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            registerUserControl1.Show();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
         
             if(string.IsNullOrEmpty(txtPassword.Text))
             {
                 errorProvider1.SetError(txtPassword, "please enter your Password");
                 errorProvider1.BlinkRate = 0;
             }

            user.Email = txtUserName.Text;
            user.Password = txtPassword.Text.ToString().Trim();

             dt= bll.Login(user);
                 dtLog = dt;

            if (dt.Rows.Count>0)

             { 
                userStatus = dt.Rows[0]["UserStatus"].ToString();
                if (userStatus=="Active")
                {

                    usertype = dt.Rows[0]["Role"].ToString();
                    if (usertype == "Admin")
                    {

                        Admin frm = new Admin();
                        frm.Show();
                        this.Hide();
                    }
                    else if (usertype == "Lecturer")
                    {

                        Lecturer frm = new Lecturer();
                        frm.Show();
                        this.Hide();
                    }
                    else if (usertype == "Student")
                    {

                        Student frm = new Student();
                        frm.Show();
                        this.Hide();
                    }
                }
                else if(userStatus=="Inactive")
                {
                    MessageBox.Show("Login failed,Your account was deactivated");
                }

            }
            else
            {
                    MessageBox.Show("Wrong Password or Email");
            }

           
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            registerUserControl1.Hide();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "please enter your Email");
                errorProvider1.BlinkRate = 0;
            }
            else if ((!Regex.IsMatch(txtUserName.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                errorProvider1.SetError(txtUserName, "Wrong Email Format ,e.g : user@email.com");
                errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
