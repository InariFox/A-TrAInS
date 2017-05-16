using System;
using System.Data;
using System.Windows.Forms;

namespace A_TrAInS
{
    public partial class settingStationWindow : Form
    {
        MesBox mb;

        public settingStationWindow()
        {
            InitializeComponent();
            mb = new MesBox();
        }
        public settingStationWindow(DataTable dt)
        {
            InitializeComponent();
            dgvStations.DataSource = dt;
            mb = new MesBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(InariFox.TdmlLib.Properties.Resources.CanRead.Equals(dgvStations[2, e.RowIndex].Value))
            {
                cboxRead.Checked = true;
            } else
            {
                cboxRead.Checked = false;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cboxRead.Checked){ dgvStations[2, dgvStations.CurrentRow.Index].Value = InariFox.TdmlLib.Properties.Resources.CanRead; }
            else { dgvStations[2, dgvStations.CurrentRow.Index].Value = InariFox.TdmlLib.Properties.Resources.CantRead; }

            mb.setCode("OK001");
            mb.showMessageBox(false);
        }
    }
}
