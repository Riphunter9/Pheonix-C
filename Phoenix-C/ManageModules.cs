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
    public partial class ManageModules : Form
    {
        public ManageModules()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        Module module = new Module();
        ModuleType type = new ModuleType();
        DataTable dt = new DataTable();
        public static DataTable dtLog;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            module.ModuleDesc = txtModuleDesc.Text;
            module.ModuleDuration = cmbModuleDuration.SelectedItem.ToString();
            module.ModuleTypeID = int.Parse(cmbModuleType.SelectedValue.ToString());

            int x = bll.InsertModule(module);
            dtLog = dt;
            if (x > 0)
            {
                MessageBox.Show(txtModuleDesc.Text + " was added.");
            }
        }

        private void ManageModules_Load(object sender, EventArgs e)
        {
            cmbModuleDuration.Items.Add("Year Module");
            cmbModuleDuration.Items.Add("Semester Module");
           

            cmbModuleType.DataSource = bll.LoadModuleType();
            cmbModuleType.ValueMember = "ModuleTypeID";
            cmbModuleType.DisplayMember = "ModuleTypeDescription";
        }

        private void btnListModules_Click(object sender, EventArgs e)
        {
            dgvModules.DataSource = bll.ListModules(module);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            module.ModuleDesc = txtModuleDesc.Text;
            module.ModuleDuration = cmbModuleDuration.SelectedItem.ToString();
            module.ModuleTypeID = int.Parse(cmbModuleType.SelectedValue.ToString());
            module.ModuleID = int.Parse(dgvModules.SelectedRows[0].Cells["ModuleID"].Value.ToString());

            int x = bll.DeleteModule(module);

            if (x>0)
            {
                MessageBox.Show(txtModuleDesc.Text + " is Deleted.");
                dgvModules.DataSource = bll.ListModules(module);
            }
            
        }

        private void dgvModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModules.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = bll.ListModules(module);
                txtModuleDesc.Text = dgvModules.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                cmbModuleDuration.Text = dgvModules.SelectedRows[0].Cells["ModuleDuration"].Value.ToString();
                cmbModuleType.Text = dgvModules.SelectedRows[0].Cells["ModuleTypeDescription"].Value.ToString();
            }
        }
    }
}
