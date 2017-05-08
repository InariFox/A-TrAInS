using InariFox.TalkLib;
using System;
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
            bool result = false;

            if(td.setText(target, "こんにちは"))
            {
                result = td.Play(target);
            }

            if (!result)
            {
                MessageBox.Show("処理時にエラーが発生しました。", "音声合成タスク処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
