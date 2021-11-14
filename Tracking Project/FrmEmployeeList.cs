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
    public partial class FrmEmployeeList : Form
    {
        private protected void ShowEmployee()
        {
            FrmEmployee employee = new FrmEmployee();
            this.Hide();
            employee.ShowDialog();
            this.Visible = true;
        }

        public FrmEmployeeList()
        {
            InitializeComponent();
        }
        
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }   
}       
