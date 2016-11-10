using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oudreader
{
    public class oudreader
    {
        // クラス内共通データ
        string diagram;

        public oudreader()
        {
            diagram = "";
        }

        // readメソッド
        // - oudのデータを読み込んでstringデータとして保持
        public bool read(StreamReader sr)
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
                diagram = sr.ReadToEnd();
            }

            // 読み込んだらStreamReaderは不要なのでcloseする
            sr.Close();

            return result;
        }
    }
}
