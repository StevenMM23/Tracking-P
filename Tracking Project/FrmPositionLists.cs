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
using DAL.DTO;

namespace Tracking_Project
{
    public partial class FrmPositionLists : Form
    {
        private void ShowPosition()
        {
            var position = new FrmPosition();
            this.Hide();
            position.ShowDialog();
            this.Visible = true;
            FillGrid();
        }
        public FrmPositionLists()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowPosition();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowPosition();
        }

        private List<PositionDTO> positionList = new();

        void FillGrid()
        {
            positionList = PositionBLL.GetPosition();
            dataGridView1.DataSource = positionList;
        }
        private void FrmPositionLists_Load(object sender, EventArgs e)
        {
            FillGrid();
            positionList = PositionBLL.GetPosition();
            dataGridView1.DataSource = positionList;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Department ID";
            dataGridView1.Columns[2].HeaderText = "Position Name";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
