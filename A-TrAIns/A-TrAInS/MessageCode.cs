using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_TrAInS
{
    class MessageCode
    {
        Dictionary<string , string> ec;

        public MessageCode()
        {
            ec = new Dictionary<string, string>();

            ec.Add("UN999", "不明なエラー");
            #region ファイル読み込み時エラー
            ec.Add("FL001", "指定されたファイルは存在しません。");
            ec.Add("FL002", "指定されたファイルの形式が不明です。");
            #endregion

            #region フォーム操作エラー
            ec.Add("FM001", "ファイルが読み込まれていません。");
            #endregion
        }

        public string getMessage(string code)
        {
            return ec[code];
        }
    }
}
