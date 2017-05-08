using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_TrAInS
{
    class MessageCode
    {
        Dictionary<string, string> codelist;

        public MessageCode()
        {
            codelist = new Dictionary<string, string>();

            codelist.Add("UN999", "不明なエラー");
            #region ファイル読み込み時エラー
            codelist.Add("FL001", "指定されたファイルは存在しません。");
            codelist.Add("FL002", "指定されたファイルの形式が不明です。");
            #endregion

            #region フォーム操作エラー
            codelist.Add("FM001", "ファイルが読み込まれていません。");
            #endregion

            #region 処理成功メッセージ
            codelist.Add("OK001", "変更を適用しました。");
            #endregion
        }

        public string getMessage(string code)
        {
            return codelist[code];
        }
    }
}
