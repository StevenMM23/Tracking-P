using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracking_Project
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void OpenHide(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenHide(new FrmEmployeeList());
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            OpenHide(new FrmTaskList());
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            OpenHide(new FrmSalaryList());
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            OpenHide(new FrmPermissionList());
        }

        private void btnDeparment_Click(object sender, EventArgs e)
        {
            OpenHide(new FrmDepartmentList());
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
           OpenHide(new FrmPositionLists());
        }

        
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
