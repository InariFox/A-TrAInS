using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_TrAIns
{
    public class AnGen
    {
        public AnGen()
        {
            this.dr = null;
            this.dc = null;
        }
        public AnGen(DataRow dr)
        {
            this.dr = dr;
        }
        public AnGen(DataColumn dc)
        {
            this.dc = dc;
        }

        private DataRow dr;
        private DataColumn dc;
        private string str;

        public void genTest()
        {
            string text = "";
            if(dr != null)
            {
                /* 列車ごとの読み上げテキストを生成 */
                text += "この電車は、" + dr.ItemArray[1].ToString() + "、" + dr.ItemArray[2].ToString() + "、行きです。";
                text += "停車駅は、";

                for(int i=3;i < dr.ItemArray.Count(); i++)
                {
                    if (!dr.ItemArray[i].ToString().Equals("") && !dr.ItemArray[i].ToString().Equals("通過"))
                    {
                        text += dr.Table.Columns[i].ToString().Split('#')[1] + "、";
                    }
                }

                text += "です。";
            }
            else if(dc != null)
            {
                /* 駅ごとの読み上げテキストを生成 */
            }

            setText(text);
        }

        private void setText(string str)
        {
            this.str = str;
        }
        public string getText()
        {
            return str;
        }
    }
}
