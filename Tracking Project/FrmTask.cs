﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;

namespace Tracking_Project
{
    public partial class FrmTask : Form
    {
        public FrmTask()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TaskDTO dto = new TaskDTO();
        private bool combofull = false;
        private void FrmTask_Load(object sender, EventArgs e)
        {
            label9.Visible = false;
            cmbTaskState.Visible = false;
            dto = TaskBLL.GetAll();
            dataGridView1.DataSource = dto.Employee;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            
            dataGridView1.Columns[5].Visible = false;
            
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            combofull = false;
            dto = TaskBLL.GetAll();
            cmbDepartment.DataSource = dto.Deparments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbPosition.DataSource = dto.Position;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!combofull) return;
            cmbPosition.DataSource =
                dto.Position.Where(x => x.DepartmentID == cmbDepartment.SelectedIndex + 1).ToList();
            var list = dto.Employee;
            dataGridView1.DataSource = list.Where(x => x.DeparmentID == cmbDepartment.SelectedIndex + 1).ToList();

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUserNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!combofull) return;
            var list = dto.Employee;
            dataGridView1.DataSource = list.Where(x => x.PositionID == cmbPosition.SelectedIndex + 1).ToList();

        }
    }
}
