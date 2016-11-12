using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// diaman - ダイヤデータ管理クラス
// 2016-11-12 @ InariFox
namespace A_TrAIns
{
    class diaman
    {
        // -- ダイヤデータ
        private Dictionary<string, DataSet> diagrams;

        public diaman()
        {
            diagrams = new Dictionary<string, DataSet>();
        }

        public void setDiagrams(Dictionary<string, DataSet> dia)
        {
            diagrams = dia;
        }

        public string[] getDiagramNames()
        {
            return diagrams.Keys.ToArray();
        }

        public DataSet getDiagram(string keyname)
        {
            DataSet ds = null;

            if (diagrams.ContainsKey(keyname)){
                ds = diagrams[keyname];
            }

            return ds;
        }
    }
}
/* TODO:Diagramのデータ構造を考える

ダイヤ1
- 上り
- 下り

ダイヤ2
- 上り
- 下り

※下りは必須
※上りは任意


Dictionary<string,Dataset> diagrams()
 - diagrams["(ダイヤグラム名)"]
    - datatable diagram["下り" or "上り"]

※ダイヤグラムの名前が統一されないことも考えてDictionary型で管理
※でも中身自体はDatasetとDatatableで管理するよ。
 */
