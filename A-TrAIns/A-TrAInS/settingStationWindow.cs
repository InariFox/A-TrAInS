using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_TrAInS
{
    public partial class settingStationWindow : Form
    {
        public settingStationWindow()
        {
            InitializeComponent();
        }
        public settingStationWindow(DataTable dt)
        {
            InitializeComponent();
            dgvStations.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Properties.Resources.CanRead.Equals(dgvStations[2, e.RowIndex].Value))
            {
                cboxRead.Checked = true;
            } else
            {
                cboxRead.Checked = false;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cboxRead.Checked){ dgvStations[2, dgvStations.CurrentRow.Index].Value = Properties.Resources.CanRead; }
            else { dgvStations[2, dgvStations.CurrentRow.Index].Value = Properties.Resources.CantRead; }
        }
    }
}
