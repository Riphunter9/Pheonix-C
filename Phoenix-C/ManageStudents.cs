using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ONT2000
{
    public partial class ManageStudents : Form
    {
        public ManageStudents()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        Module Module = new Module();
        StudentModule stud = new StudentModule();
        DataTable dt = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            lblModuleHeading.Text = "";
            ManageLecturer lect = new ManageLecturer();
            lect.Show();
            this.Hide();
        }

        StudentModule student = new StudentModule();
        private void ManageStudents_Load(object sender, EventArgs e)
        {

            
            cmbModuleDesc.DataSource = bll.ListModLecturer();
            cmbModuleDesc.ValueMember = "LecturerModuleID";
            cmbModuleDesc.DisplayMember = "ModuleName";

            cmbStudent.ValueMember = "UserID";
            cmbStudent.DisplayMember = "Name";
            cmbStudent.DataSource = bll.loadStudents();

            DataTable dt = ManageLecturer.dtLog;

         

            dgvAllStud.DataSource = bll.LoadAllStudents();

        }

        private void btnAddStudtoModule_Click(object sender, EventArgs e)
        {
            student.Date = dtpStudModuleDate.Text;
            student.UserID = int.Parse(cmbStudent.SelectedValue.ToString());
            student.LecturerModuleID = int.Parse(cmbModuleDesc.SelectedValue.ToString());
            int x = bll.AssignStudent(student);
            if (x > 0)
            {
                MessageBox.Show(int.Parse(cmbStudent.SelectedValue.ToString()) + " was Assigned .");
            }
        }

        
        private void btnDisplayStudFromMod_Click(object sender, EventArgs e)
        {
            Module.ModuleDesc = cmbModuleDesc.SelectedItem.ToString();

            dt = bll.Refresh(Module);
            if (dt.Rows.Count > 0)
            {
                dgvAddedStud.DataSource = dt;
            }
        }
    }
}
