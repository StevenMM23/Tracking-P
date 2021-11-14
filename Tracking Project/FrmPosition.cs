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
    public partial class FrmPosition : Form
    {
        private List<DEPARMENT> departmentList = new();
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPosition_Load(object sender, EventArgs e)
        {
            departmentList = DepartmentBLL.GetDepartment().ToList();
            comboBox1.DataSource = departmentList;
            comboBox1.DisplayMember = "DepartmentName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
                MessageBox.Show("Please fill the position name");
            else if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Please select a department");
            else
            {
                var position = new Position
                {
                    PositionName = textBox1.Text,
                    DepartmentID = Convert.ToInt32(comboBox1.SelectedValue)
                };
                PositionBLL.AddPosition(position);
                MessageBox.Show("Position was added");
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
            }

        }
    }
}
