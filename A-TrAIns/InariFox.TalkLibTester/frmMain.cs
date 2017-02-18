using InariFox.TalkLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InariFox.TalkLibTester
{
    public partial class frmMain : Form
    {
        private talkDriver td;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            td = new talkDriver();
            lboxEnabled.Items.AddRange(td.getNarratorList().ToArray());
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string target = lboxEnabled.SelectedItem.ToString();
            td.setText(target, "おはよう新しい私。");
            td.Play(target);
        }
    }
}
