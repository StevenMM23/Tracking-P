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
    public partial class FrmTaskList : Form
    {
        private void ShowTask()
        {
            FrmTask task = new FrmTask();
            this.Hide();
            task.ShowDialog();
            this.Visible = true;
        }
        public FrmTaskList()
        {
            InitializeComponent();
        }

        private void txtUserNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            pnlForAdmin.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowTask();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowTask();
        }
    }
}
