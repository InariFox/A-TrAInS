using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using oudtool;
using System.Data;
using YukarinTalk;

// A_TrAIns
// 2016-11-10 @ InariFox
namespace A_TrAIns
{
    public partial class frmRough : Form
    {
        private oudlib ol;
        private diaman dm;
        private string title;

        public frmRough()
        {
            InitializeComponent();
            ol = new oudlib();
            dm = new diaman();
            title = Text;
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
                if (!ol.readOud(data))
                {
                    MessageBox.Show("Oudiaのデータではありません！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    // 駅リストとダイヤ一覧の初期化
                    cboxStationList.Items.Clear();
                    cboxDiaList.Items.Clear();

                    // タイトルバーの設定
                    Text = title + " - " + ofdOudia.FileName;

                    // 路線データの取得
                    tboxLineName.Text = ol.getLinename();

                    // 駅リストの取得
                    cboxStationList.Items.AddRange(ol.getStations().ToArray());

                    // ダイヤグラムの取得
                    Dictionary<string, DataSet> diagrams = ol.getDiagrams();
                    dm.setDiagrams(diagrams);

                    // ダイヤ一覧の取得
                    cboxDiaList.Items.AddRange(dm.getDiagramNames());
                }
            }
        }

        // ダイヤグラムデータ読み込み
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if ((cboxDiaList.SelectedIndex != -1) || (cboxFor.SelectedIndex != -1))
            {
                string dianame = cboxDiaList.SelectedItem.ToString();
                DataSet ds = dm.getDiagram(dianame);
                if (ds != null)
                {
                    // 再初期化してからデータソースを紐付け
                    dgvDiagram.DataSource = null;
                    DataTable dt = ds.Tables[cboxFor.SelectedIndex];
                    dgvDiagram.DataSource = dt;
                }
            }
        }

        // ゆかりさんに読み上げテストしてもらう用の一時的な奴
        private void btn_test_Click(object sender, EventArgs e)
        {
            yukalib yl = new yukalib();
            yl.Play();
        }

        // 路線データ表示
        // 路線名と駅リストをMessageBoxで表示する
        //private void btnShowInfo_Click(object sender, EventArgs e)
        //{
        //    string[] info = ol.getlineinfo().ToArray();
        //    for (int i = 0; i < info.Length; i++)
        //    {
        //        tboxDiagram.Text += info[i] + "\r\n";
        //    }

        //}
    }
}
