using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ONT2000
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        Assessment assessment = new Assessment();
        private void Student_Load(object sender, EventArgs e)
        {
            
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Missed");
            cmbStatus.Items.Add("Extended");

            DataTable dt = Form1.dtLog;
            lblName.Text = dt.Rows[0]["Name"].ToString();
            lblSurname.Text = dt.Rows[0]["Surname"].ToString();
            lblEmail.Text = dt.Rows[0]["Email"].ToString();

            cmbAssessmentDesc.DataSource = bll.ListAssessments(assessment);
            cmbAssessmentDesc.ValueMember = "AssessmentID";
            cmbAssessmentDesc.DisplayMember = "AssessmentDescription";


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Assessment assess = new Assessment();
            assess.DueDate = dateTimePicker1.Text;
            assess.AssessmentStatus = cmbStatus.SelectedItem.ToString();
            assess.AssessmentID = int.Parse(cmbAssessmentDesc.SelectedValue.ToString());


            int x = bll.UpdateStudent(assess);
            if (x > 0)
            {
                MessageBox.Show(cmbAssessmentDesc.Text + " Updated.");
            }
        }
    }
}
