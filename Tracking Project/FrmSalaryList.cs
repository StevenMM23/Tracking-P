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
    public partial class FrmSalaryList : Form
    {
        private void ShowSalary()
        {
            var salary = new FrmSalary();
            this.Hide();
            salary.ShowDialog();
            this.Visible = true;
        }
        public FrmSalaryList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowSalary();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowSalary();
        }
    }
}
