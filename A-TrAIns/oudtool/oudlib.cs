using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// oudlib - oudファイルローダ
// 2016-11-10 @ InariFox
namespace oudtool
{
    public class oudlib
    {
        // クラス内共通データ
        // -- ダイヤ以外の奴
        private List<string> stations; //駅リスト
        private List<string> traintype; //列車種別
        private string linename; //路線名

        // -- ダイヤ関係
        private Dictionary<string, DataSet> diagrams;

        // コンストラクタ
        public oudlib()
        {
            stations = new List<string>();
            traintype = new List<string>();
            diagrams = new Dictionary<string, DataSet>();
        }

        // readメソッド
        /// <summary>
        /// oudファイルを読み込んで路線名、駅リスト、ダイヤデータに分割します。
        /// 読み込みに成功したらtrueを、読み込みに失敗した場合falseが返ります。
        /// </summary>
        /// <param name="sr">読み込むファイルのStreamReader</param>
        /// <returns></returns>
        public bool readOud(StreamReader sr)
        {
            // 読み込み処理フラグ
            // 読み込めなかったりOudiaのデータじゃなかったらfalseを返す
            // 読み込めたらtrueを返す
            bool result = false;

            // ヘッダーチェック
            // 一行分読み込んでデータ部分だけ分割してOudiaのデータかどうか照合する
            string head = sr.ReadLine();
            result = head.Contains("FileType=OuDia");

            // ヘッダーチェックで問題なければとりあえず読み込む
            if (result)
            {
                // データ格納先の再初期化
                diagrams.Clear();
                stations.Clear();
                traintype.Clear();

                // 読み込みできる文字がなくなるまで繰り返す
                while (sr.Peek() >= 0)
                {
                    // ファイルを 1 行ずつ読み込む
                    string data = sr.ReadLine();

                    // 路線名
                    if (data.Contains("Rosenmei="))
                    {
                        string[] line = data.Split('=');
                        linename = line[1];
                    }

                    // 駅名
                    if (data.Contains("Ekimei="))
                    {
                        string[] station = data.Split('=');
                        stations.Add(station[1]);
                    }

                    // 列車種別
                    if (data.Contains("Syubetsumei="))
                    {
                        string[] traintypes = data.Split('=');
                        traintype.Add(traintypes[1]);
                    }

                    // ダイヤ名
                    if (data.Contains("DiaName="))
                    {
                        string[] dianames = data.Split('=');
                        string dianame = dianames[1];
                        DataSet ds = new DataSet();

                        diagrams.Add(dianame, ds);
                    }

                    // ダイヤ情報(下り / 上り)
                    if (data.Contains(@"Kudari.") || data.Contains(@"Nobori."))
                    {
                        data = data.Replace(".", "");
                        DataSet ds = diagrams.Last().Value;

                        DataTable dt = new DataTable(data);
                        //基本列の定義
                        // 3列定義します。
                        dt.Columns.Add("列車番号", Type.GetType("System.String"));
                        dt.Columns.Add("列車種別", Type.GetType("System.String"));
                        dt.Columns.Add("行先", Type.GetType("System.String"));

                        // 駅数分列を追加する
                        // データの仕様上駅名の重複があるので駅名の頭文字に(数字#)を付与
                        if (data.Contains(@"Kudari"))
                        {
                            foreach (var station in stations.Select((value, index) => new { value, index }))
                            {
                                dt.Columns.Add((station.index + 1) + "#" + station.value, Type.GetType("System.String"));
                            }
                        }
                        else if (data.Contains(@"Nobori"))
                        {
                            stations.Reverse();
                            foreach (var station in stations.Select((value, index) => new { value, index }))
                            {
                                dt.Columns.Add((station.index + 1) + "#" + station.value, Type.GetType("System.String"));
                            }
                            stations.Reverse();
                        }

                        ds.Tables.Add(dt);
                    }

                    // ダイヤデータ
                    if (data.Contains(@"Ressya."))
                    {
                        // 列車の方向を取得
                        data = sr.ReadLine();

                        /*
                         * 方向別で何か処理行うならここで。
                         */

                        // 種別取得
                        data = sr.ReadLine();
                        string traintype = data.Split('=')[1];

                        // 列車番号:ついていれば取得
                        data = sr.ReadLine();
                        string trainid = "";
                        if (data.Split('=')[0].Contains("Ressyabangou"))
                        {
                            trainid = data.Split('=')[1];
                            data = sr.ReadLine();
                        }

                        // 列車名：ついていれば取得
                        string trainname = "";
                        if (data.Split('=')[0].Contains("Ressyamei"))
                        {
                            trainname = data.Split('=')[1];
                            data = sr.ReadLine();
                        }

                        // 号数：ついていれば取得
                        string trainno = "";
                        if (data.Split('=')[0].Contains("Gousuu"))
                        {
                            trainno = data.Split('=')[1];
                            data = sr.ReadLine();
                        }

                        // ダイヤデータ
                        string[] diagrams = data.Split('=')[1].Split(',');

                        // データをカラムに挿入
                        DataSet ds = this.diagrams.Last().Value;
                        DataRow dr = ds.Tables[ds.Tables.Count - 1].NewRow();
                        dr[0] = trainid;
                        if (!string.IsNullOrEmpty(trainno))
                        {
                            dr[1] = this.traintype[int.Parse(traintype)] + " " + trainno + "号";
                        } else
                        {
                            dr[1] = this.traintype[int.Parse(traintype)];
                        }
                        dr[2] = trainname;

                        // ダイヤデータ整形
                        foreach (var diagram in diagrams.Select((value, index) => new { value, index }))
                        {
                            string dia = "";
                            if (diagram.value.Equals("2") || diagram.value.Split(';')[0].Equals("2"))
                            {
                                dia = "通過";
                            }
                            else if (diagram.value.Split(';')[0].Equals("1"))
                            {
                                if (diagram.value.Split('/').Count().Equals(2))
                                {
                                    if (!string.IsNullOrEmpty(diagram.value.Split('/')[1]))
                                    {
                                        dia = diagram.value.Split('/')[1];
                                    } else
                                    {
                                        dia = diagram.value.Split(';')[1].Split('/')[0];
                                    }
                                } else
                                {
                                    dia = diagram.value.Split(';')[1];
                                }
                                
                            } else
                            {
                                dia = diagram.value;
                            }

                            // 発着時刻が3桁の場合0を付与
                            if(dia.Count() == 3)
                            {
                                dia = "0" + dia;
                            }

                            dr[3 + diagram.index] = dia;
                        }

                        // データ追加
                        ds.Tables[ds.Tables.Count - 1].Rows.Add(dr);
                    }
                }
            }

            // 読み込んだらStreamReaderは不要なのでcloseする
            sr.Close();

            return result;
        }

        // getLinenameメソッド
        /// <summary>
        /// 読み込んだデータの路線名を返します
        /// </summary>
        /// <returns></returns>
        public string getLinename()
        {
            return linename;
        }

        // getStationsメソッド
        /// <summary>
        /// 読み込んだデータの駅リストを返します
        /// </summary>
        /// <returns></returns>
        public List<string> getStations()
        {
            return stations;
        }

        // getDiagramsメソッド
        /// <summary>
        /// 読み込んだデータのダイヤグラムを返します
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, DataSet> getDiagrams()
        {
            return diagrams;
        }
    }
}
