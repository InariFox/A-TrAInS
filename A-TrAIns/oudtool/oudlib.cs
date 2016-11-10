using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oudtool
{
    public class oudlib
    {
        // クラス内共通データ

        // 駅リスト
        private List<string> stations;
        private string linename;

        public oudlib()
        {
            stations = new List<string>();
        }

        // readメソッド
        // - oudファイルを読み込んでデータを整形
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

                }
            }

            // 読み込んだらStreamReaderは不要なのでcloseする
            sr.Close();

            return result;
        }

        // getLinenameメソッド
        // 読み込んだデータの路線名を返す
        public string getLinename()
        {
            return linename;
        }

        // getStationsメソッド
        // 読み込んだデータの駅リストを返す
        public List<string> getStations()
        {
            return stations;
        }
    }
}
