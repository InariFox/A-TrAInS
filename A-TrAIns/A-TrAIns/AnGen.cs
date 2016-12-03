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
            this.str = null;
        }
        public AnGen(DataRow dr)
        {
            this.dr = dr;
            this.str = new List<string>();
        }
        public AnGen(DataColumn dc)
        {
            this.dc = dc;
            this.str = new List<string>();
        }

        private DataRow dr;
        private DataColumn dc;
        private List<string> str;

        public void genTest()
        {
            clsText();
            string text ="";
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
                addText(text);

                /* 各駅ごとの案内 */
                for (int i = 3; i < dr.ItemArray.Count(); i++)
                {
                    if (!dr.ItemArray[i].ToString().Equals("") && !dr.ItemArray[i].ToString().Equals("通過"))
                    {
                        text = "次は、" + dr.Table.Columns[i].ToString().Split('#')[1] + "、" + dr.Table.Columns[i].ToString().Split('#')[1] + "です。";
                        string text2 = "まもなく、" + dr.Table.Columns[i].ToString().Split('#')[1] + "、" + dr.Table.Columns[i].ToString().Split('#')[1] + "です。";
                        bool flag = false;
                        for (int j = i; j < dr.ItemArray.Count(); j++)
                        {
                            if (!dr.ItemArray[j].ToString().Equals("") && !dr.ItemArray[j].ToString().Equals("通過") && i < j && !flag)
                            {
                                text += dr.Table.Columns[i].ToString().Split('#')[1] + "を出ますと次は、" + dr.Table.Columns[j].ToString().Split('#')[1] + "に停まります。";
                                text2 += dr.Table.Columns[i].ToString().Split('#')[1] + "を出ますと次は、" + dr.Table.Columns[j].ToString().Split('#')[1] + "に停まります。";
                                text2 += "お降りのさい、お忘れ物ございませんようご注意下さい。";
                                flag = true;
                            }
                        }
                        addText(text);
                        addText(text2);
                    }
                }
                addText("この列車はこの駅までです。どなた様もお降り下さい。お降りのさい、お忘れ物ございませんようご注意下さい。");

            }
            else if(dc != null)
            {
                /* 駅ごとの読み上げテキストを生成 */
            }
        }

        private void clsText()
        {
            this.str.Clear();
        }
        private void addText(string str)
        {
            this.str.Add(str);
        }
        public List<string> getText()
        {
            return str;
        }
    }
}
