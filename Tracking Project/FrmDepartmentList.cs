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

namespace Tracking_Project
{
    
    public partial class FrmDepartmentList : Form
    {
        private void ShowDepartment()
        {
            var department = new FrmDepartment();
            this.Hide();
            department.ShowDialog();
            this.Visible = true;
        }
        public FrmDepartmentList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowDepartment();
            list = DepartmentBLL.GetDepartment();
            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowDepartment();
        }
        List<DEPARMENT> list = new();
        private void FrmDepartmentList_Load(object sender, EventArgs e)
        {
            
            list = DepartmentBLL.GetDepartment();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "Department ID";
            dataGridView1.Columns[1].HeaderText = "Department Name";
        }
    }
}
