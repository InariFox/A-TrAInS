using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using oudtool;

namespace A_TrAIns
{
    public partial class frmRough : Form
    {
        private oudlib ol;

        public frmRough()
        {
            InitializeComponent();
            ol = new oudlib();
        }

        private bool is_oudia(string head)
        {
            bool result = false;
            String[] data = head.Split('=');
            if(data.Length == 2)
            {
                result = data[1].Contains("OuDia");
            }
            return result;
        }

        // 閉じるボタン処理
        // 基本的に閉じるだけ....のはず
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 開くボタン処理
        // - Oudiaダイヤデータ読み込みウィンドウを表示させる
        // - 読み込みができたらtextboxに表示させる
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofdOudia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // SJISを指定して読み込まないと文字化け起こすよ！
                StreamReader data = new StreamReader(ofdOudia.OpenFile(), Encoding.GetEncoding("Shift_JIS"));
                if (!ol.read(data))
                {
                    MessageBox.Show("Oudiaのデータではありません！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    //tboxDiagram.Text = ol.load();
                }
            }
        }

        // 路線データ表示
        // 路線名と駅リストをMessageBoxで表示する
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            string[] info = ol.getlineinfo().ToArray();
            for (int i = 0; i < info.Length; i++)
            {
                tboxDiagram.Text += info[i] + "\r\n";
            }

        }
    }
}
