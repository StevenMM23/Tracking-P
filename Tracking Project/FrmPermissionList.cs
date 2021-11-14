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
    public partial class FrmPermissionList : Form
    {
        private void ShowPermission()
        {
            var permision = new FrmPermission();
            this.Hide();
            permision.ShowDialog();
            this.Visible = true;
        }
        public FrmPermissionList()
        {
            InitializeComponent();
        }

        private void txtDayAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowPermission();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowPermission();
        }

        private void FrmPermissionList_Load(object sender, EventArgs e)
        {

        }
    }
}
