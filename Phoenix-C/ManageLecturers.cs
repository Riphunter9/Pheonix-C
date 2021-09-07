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
    public partial class ManageLecturer : Form
    {
        public ManageLecturer()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        Module module = new Module();
        Users user = new Users();
       
        LecturerModule lecturer = new LecturerModule();
        DataTable dt = new DataTable();

        public static int LecturerModID;
        public static string ModuleName;

        public static DataTable dtLog;
        private void button1_Click(object sender, EventArgs e)
        {   
            Admin frm = new Admin();
            frm.Show();
            this.Hide();

        }

        private void Manage_Load(object sender, EventArgs e)
        {
            cmbModuleDesc.DataSource = bll.ListModules(module);
            cmbModuleDesc.ValueMember = "ModuleID";
            cmbModuleDesc.DisplayMember = "ModuleName";

            cmbLecturer.DataSource = bll.LoadLecturer();
            cmbLecturer .ValueMember = "UserID";
            cmbLecturer.DisplayMember = "Name";
        }

        private void btnAssignLecturer_Click(object sender, EventArgs e)
        {
            lecturer.Date = dtpModuleDate.Text;
            lecturer.UserID = int.Parse(cmbLecturer.SelectedValue.ToString());
            lecturer.ModuleID  = int.Parse(cmbModuleDesc.SelectedValue.ToString());

            
            int x = bll.AssignLecturer(lecturer);
            
            if (x > 0)
            {
                MessageBox.Show(int.Parse(cmbLecturer.SelectedValue.ToString())+" was Assigned .");
            }
        }

        private void cmbLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListLecturer_Click(object sender, EventArgs e)
        {
            dgvLecturers.DataSource = bll.ListModLecturer();
        }
        
      
        private void dgvLecturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            cmbModuleDesc.Text = (dgvLecturers.SelectedRows[0].Cells["ModuleName"].Value.ToString());

            module.ModuleDesc= (dgvLecturers.SelectedRows[0].Cells["ModuleName"].Value.ToString());
           
             
            if (dgvLecturers.SelectedRows.Count>0)
            {
                ManageStudents form2 = new ManageStudents();
                form2.Show();
                this.Hide();
                form2.label5.Text = dgvLecturers.CurrentRow.Cells["ModuleName"].Value.ToString();
                form2.dgvAddedStud.DataSource = bll.ListModStudents(module);//new update
            }

          
        }
    }
}
