using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Oud2Xml
{
    public partial class Form1 : Form
    {
        private OudParser op;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            op = new OudParser();

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // SJISを指定して読み込まないと文字化け起こすよ！
                StreamReader data = new StreamReader(ofd.OpenFile(), Encoding.GetEncoding("Shift_JIS"));
                if (op.load(data.ReadToEnd()))
                {
                    lbox1.Items.AddRange(op.getlist());
                }
                else { MessageBox.Show("Oudiaのデータではありません！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                data.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd.FileName = "*.oud";
            ofd.Filter = "Oudiaダイヤデータ|*.oud";
            ofd.Title = "開く";

            sfd.FileName = "*.xml";
            sfd.Filter = "XML|*.xml";
            sfd.Title = "名前をつけて保存";
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            op.convert();
            XmlDocument data = op.getXml();
            MemoryStream ms = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(ms, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            data.Save(writer);

            tbox.Text = Encoding.UTF8.GetString(ms.ToArray());
            //tbox.Text = string.Join("\r\n", op.getlist());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、
                //選択された名前で新しいファイルを作成し、
                //読み書きアクセス許可でそのファイルを開く。
                //既存のファイルが選択されたときはデータが消える恐れあり。
                Stream stream;
                stream = sfd.OpenFile();
                if (stream != null)
                {
                    //ファイルに書き込む
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(stream);
                    sw.Write(tbox.Text);
                    //閉じる
                    sw.Close();
                    stream.Close();
                }
            }
        }
    }
}
