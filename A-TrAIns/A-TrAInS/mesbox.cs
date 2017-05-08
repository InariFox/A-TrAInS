using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_TrAInS
{
    public class MesBox
    {
        MessageCode mc;
        string code;

        public MesBox(){
            mc = new MessageCode();
            code = "";
        }

        public void setCode(string code){ this.code = code;}

        public void showMessageBox(bool e)
        {
            // eがtrueの場合はエラーボックスを表示
            // eがfalseの場合は情報ボックスを表示
            if (e){ MessageBox.Show(mc.getMessage(code) + "\r\nCode:" + code, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            else{ MessageBox.Show(mc.getMessage(code), "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        }
    }
}
