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
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDeparment.Text.Trim() == "")
                MessageBox.Show("Please fill the name Field");
            else
            {
                DEPARMENT department = new DEPARMENT();
                department.DepartmentName = txtDeparment.Text;
                DepartmentBLL.AddDepartment(department);
                MessageBox.Show($"{txtDeparment.Text} was added");
            }
            
        }
    }
}
