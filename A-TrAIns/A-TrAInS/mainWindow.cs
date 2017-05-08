using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using InariFox.OudParser;
using System.Text;

namespace A_TrAInS
{
    public partial class mainWindow : Form
    {

        const string appname = "A-TrAInS";

        TdmlConnector tcon;
        MesBox mb;

        settingStationWindow swst;

        public mainWindow()
        {
            InitializeComponent();
            this.Text = appname;
            tcon = new TdmlConnector();
            mb = new MesBox();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            ofd.Filter = "A-TrAInsData (*.tdml)|*.tdml|" +
                "OudData (*.oud)|*.oud|" +
                "All files (*.*)|*.*";
            ofd.Multiselect = false;
            ofd.Title = "ダイヤデータ読み込み";
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            bool result = false;

            this.Activate();

            tcon.empty();

            // XML読み込み
            if(Path.GetExtension(ofd.FileName) == ".tdml")
            {
                tcon.load(ofd.FileName);
                result = true;
            }
            // Oud読み込み
            else if (Path.GetExtension(ofd.FileName) == ".oud")
            {
                OudParser op = new OudParser();
                // SJISを指定して読み込まないと文字化け起こすよ！
                StreamReader sr = new StreamReader(ofd.OpenFile(), Encoding.GetEncoding("Shift_JIS"));
                if (op.load(sr.ReadToEnd()))
                {
                    op.convert();
                    tcon.load(op.getXml());
                    result = true;
                }

                sr.Close();
            }

            // 読み込んだデータを反映と読み上げ関係のボタン有効化
            if (result && tcon.parse())
            {
                Text = appname + " - " + tcon.Tp.Linename;
                swst = new settingStationWindow(tcon.Tp.Station);

                btnSettingStation.Enabled = true;
                btnSettingText.Enabled = true;
                btnPlayAnnounce.Enabled = true;
            }
            else
            {
                mb.setCode("FL002");
                mb.showMessageBox(true);

                btnSettingStation.Enabled = false;
                btnSettingText.Enabled = false;
                btnPlayAnnounce.Enabled = false;
            }

        }

        private void stripMenuItemOpen_Click(object sender, EventArgs e){ ofd.ShowDialog(); }
        private void stripMenuItemExit_Click(object sender, EventArgs e){ this.Close(); }
        private void stripMenuItemAbout_Click(object sender, EventArgs e)
        {
            VersionWindow vw = new VersionWindow();
            vw.ShowDialog();
            vw.Dispose();
        }

        private void btnSettingStation_Click(object sender, EventArgs e)
        {
            if (swst != null)
            {
                swst.ShowDialog();
            }
            else
            {
                mb.setCode("FM001");
                mb.showMessageBox(true);
            }
        }

        private void btnSettingText_Click(object sender, EventArgs e)
        {

        }
    }
}
