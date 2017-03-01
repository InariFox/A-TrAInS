﻿using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using InariFox.OudParser;
using System.Text;

namespace A_TrAInS
{
    public partial class mainWindow : Form
    {
        TdmlContainer tlc;
        ErrorCode ec;

        public mainWindow()
        {
            InitializeComponent();
            tlc = new TdmlContainer();
            ec = new ErrorCode();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            ofd.Filter = "A-TrAInsData (*.tdml)|*.tdml|" +
                "OudData (*.oud)|*.oud|" +
                "All files (*.*)|*.*";
            ofd.Multiselect = false;
            ofd.Title = "ダイヤデータ読み込み";
        }

        private void stripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            bool result = false;

            this.Activate();

            // XML読み込み
            if(Path.GetExtension(ofd.FileName) == ".tdml")
            {
                tlc.load(ofd.FileName);
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
                    tlc.load(op.getXml());
                    result = true;
                }

                sr.Close();
            }

            if (result)
            {
            }
            else
            {
                string code = "FL002";
                MessageBox.Show(ec.getMessage(code), code, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stripMenuItemOpen_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
        }
    }
}
