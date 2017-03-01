using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_TrAInS
{
    class ErrorCode
    {
        Dictionary<string , string> ec;

        public ErrorCode()
        {
            ec = new Dictionary<string, string>();

            ec.Add("UN999", "不明なエラー");
            #region ファイル読み込み時エラー
            ec.Add("FL001", "指定されたファイルは存在しません。");
            ec.Add("FL002", "指定されたファイルの形式が不明です。");
            #endregion
        }

        public string getMessage(string code)
        {
            return ec[code];
        }
    }
}
