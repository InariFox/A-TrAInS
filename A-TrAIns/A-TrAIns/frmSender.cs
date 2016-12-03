using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukarinTalk;
using BouyomiTalk;

namespace A_TrAIns
{
    public partial class frmSender : Form
    {
        public frmSender()
        {
            InitializeComponent();
        }
        public frmSender(AnGen data)
        {
            InitializeComponent();

            // 指定されたオブジェクトを解析メソッドに投げてその返り値をセット
            setData(data);
        }

        private AnGen ag;
        private yukalib yl;
        private boulib bl;

        private void setData(AnGen data)
        {
            ag = data;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            bl.Close();

            yl = null;
            bl = null;
            this.Close();
        }

        private void frmSender_Load(object sender, EventArgs e)
        {
            yl = new yukalib();
            bl = new boulib();

            ag.genTest();
            lboxAnnounce.Items.AddRange(ag.getText().ToArray());
            if(lboxAnnounce.Items.Count > 0)
            {
                lboxAnnounce.SelectedIndex = 0;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(lboxAnnounce.SelectedIndex >= 0)
            {
                sendText(lboxAnnounce.SelectedItem.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lboxAnnounce.SelectedIndex >= 0 && lboxAnnounce.SelectedIndex + 1 < lboxAnnounce.Items.Count)
            {
                lboxAnnounce.SelectedIndex++;
                sendText(lboxAnnounce.SelectedItem.ToString());
            }
        }

        private void sendText(string text)
        {
            bool result = false;

            if (rBtnYukari.Checked)
            {
                yl.setText(text);
                result = yl.Play();
            } else if (rBtnBouyomi.Checked)
            {
                bl.setText(text);
                result = bl.Play();
            }
            else
            {
                MessageBox.Show("読み上げソフトが指定されていません！", "読み上げエラー！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = true;
            }

            if (!result)
            {
                MessageBox.Show("読み上げ処理中にエラーが発生しました！", "読み上げエラー！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
