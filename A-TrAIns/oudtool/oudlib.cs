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
                        //列の定義
                        // 3列定義します。
                        dt.Columns.Add("TrainID", Type.GetType("System.String"));
                        dt.Columns.Add("TrainType", Type.GetType("System.String"));
                        dt.Columns.Add("TrainName", Type.GetType("System.String"));

                        //駅数分
                        foreach(string station in stations)
                        {
                            dt.Columns.Add(station, Type.GetType("System.String"));
                        }

                        ds.Tables.Add(dt);
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
