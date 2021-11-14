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
using DAL.DTO;
using System.IO;

namespace Tracking_Project
{
    public partial class FrmEmployee : Form
    {

        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void txtUsername_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        EmployeeDTO dto = new EmployeeDTO();
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            cmbDepartment.DataSource = dto.Deparments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
        }

        private bool combofull;
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!combofull) return;
            int departmentID = Convert.ToInt32(cmbDepartment.SelectedIndex + 1);
            cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == departmentID).ToList();

        }
        private string fileName = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            pbPhoto.Load(openFileDialog1.FileName);
            txtImagePath.Text = openFileDialog1.FileName;
            var unique = Guid.NewGuid().ToString();
            fileName += unique + openFileDialog1.SafeFileName;
        }


        bool IsEmptyTxt(TextBox x)
        {
            return x.Text.Trim() == "";
        }

        bool IsEmptyCombo(ComboBox x)
        {
            return x.SelectedIndex == -1;
        }

        void ClearAll()
        {
            txtName.Clear();
            txtImagePath.Clear();
            txtSurname.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtSalary.Clear();
            if(!IsEmptyTxt(txtAddress)) txtAddress.Clear();
            checkBox1.Checked = false;
            pbPhoto.Image = null;
            combofull = false;
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            dateTimePicker1.Value = DateTime.Today;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            isUnique = EmployeeBLL.isUnique(Convert.ToInt32(txtUsername.Text));
            if (IsEmptyTxt(txtUsername))
                MessageBox.Show("Username is Empty");
            else if (!isUnique) MessageBox.Show("This userNo is used by another employee please change");
            else if (IsEmptyTxt(txtPassword))
                MessageBox.Show("Password is Empty");
            else if (IsEmptyTxt(txtSurname))
                MessageBox.Show("Surname is Empty");
            else if (IsEmptyTxt(txtSalary))
                MessageBox.Show("Salary is Empty");
            else if (IsEmptyTxt(txtName))
                MessageBox.Show("Name is Empty");
            else if (IsEmptyTxt(txtAddress))
                MessageBox.Show("Address is Empty");
            else if (IsEmptyCombo(cmbDepartment))
                MessageBox.Show("Department is Empty");
            else if (IsEmptyCombo(cmbPosition))
                MessageBox.Show("Position is Empty");
            else
            {
                Employee employee = new Employee();
                employee.UserNo = Convert.ToInt32(txtUsername.Text);
                employee.Password = txtPassword.Text;
                employee.isAdmin = checkBox1.Checked;
                employee.Name = txtName.Text;
                employee.Surname = txtSurname.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                employee.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedIndex + 1);
                employee.PositionID = Convert.ToInt32(cmbPosition.SelectedIndex + 1);
                employee.Adress = txtAddress.Text;
                employee.BirthDay = dateTimePicker1.Value;
                employee.ImagePath = fileName;
                EmployeeBLL.AddEmployee(employee);
                File.Copy(txtImagePath.Text, @"images\\" + fileName);
                MessageBox.Show("Employee was added");
                ClearAll();
                
            }
            

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isUnique = false;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (IsEmptyTxt(txtUsername)) MessageBox.Show("Username is Empty");
            else
            {
                isUnique = EmployeeBLL.isUnique(Convert.ToInt32(txtUsername.Text));
                if (!isUnique) MessageBox.Show("This userNo is used by another employee please change");
                else
                    MessageBox.Show("This userNo is usable");


            }
        }
    }
}
