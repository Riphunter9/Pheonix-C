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
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            searchUC2.BringToFront();
            searchUC2.Show();
        }

        private void btnAddAssessment_Click_1(object sender, EventArgs e)
        {
            searchUC2.SendToBack();
            searchUC2.Hide();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            DataTable dt = Form1.dtLog;
            lblName.Text = dt.Rows[0]["Name"].ToString();
            lblSurname.Text = dt.Rows[0]["Surname"].ToString();
            lblEmail.Text = dt.Rows[0]["Email"].ToString();

            dgvLecturer.DataSource = bll.LoadThisLecModules(); 
            
            cmbType.ValueMember = "AssessmentTypeID";
            cmbType.DisplayMember = "AssessmentTypeDescription";
            cmbType.DataSource = bll.LoadAssessmentType();

            Module Module = new Module();

            cmbModule.DataSource = bll.ListModules(Module);
            cmbModule.ValueMember = "ModuleID";
            cmbModule.DisplayMember = "ModuleName";

            cmbStatus.Items.Add("Open");
            cmbStatus.Items.Add("Extended");
            cmbStatus.Items.Add("Closed");

        }
      
        private void BtnList_Click(object sender, EventArgs e)
        {
            dgvAssessment.DataSource = bll.SelectAssessments();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Assessment assess = new Assessment();
            assess.AssessmentTypeID = int.Parse(cmbType.SelectedValue.ToString());
            assess.AssessmentDescription = txtDesc.Text;
            assess.AssessmentStatus = cmbStatus.SelectedItem.ToString();
            assess.DueDate = dateTimePicker1.Text;
            assess.ModuleID = int.Parse(cmbModule.SelectedValue.ToString());

            int x = bll.InsertAssessment(assess);
            if (x > 0)
            {
                MessageBox.Show("Assessment Added");
            }
        }
    }
}
