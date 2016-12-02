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

namespace A_TrAIns
{
    public partial class frmSender : Form
    {
        public frmSender()
        {
            InitializeComponent();

            yl = new yukalib();
        }
        public frmSender(AnGen data)
        {
            InitializeComponent();

            // 指定されたオブジェクトを解析メソッドに投げてその返り値をセット
            setData(data);
            yl = new yukalib();
        }

        private AnGen ag;
        private yukalib yl;

        private void setData(AnGen data)
        {
            ag = data;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSender_Load(object sender, EventArgs e)
        {
            ag.genTest();
            tBoxText.Text = ag.getText();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            yl.setText(tBoxText.Text);
            yl.Play();
        }
    }
}
