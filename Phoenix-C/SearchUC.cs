using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
     

namespace ONT2000
{
    public partial class SearchUC : UserControl
    {
        public SearchUC()
        {
            InitializeComponent();
        }
        Assessment assess = new Assessment();
        DataTable dt = new DataTable();
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void SearchUC_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Missed");
            cmbStatus.Items.Add("Extended");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            int UserID;
            Int32.TryParse(txtEmail.Text.ToString(), out UserID);
            dgvResults.DataSource = bll.SearchByID(UserID);
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            assess.AssessmentStatus = cmbStatus.SelectedItem.ToString();
            dt = bll.SearchByStatus(assess);
            if (dt.Rows.Count > 0)
            {
                dgvResults.DataSource = dt;
            }
            
        }
    }
}
