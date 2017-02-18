//talkDriver.cs
//読み上げソフトごとの違いを吸収して同一メソッドで操作出来るようにするDriverです。
//最低限の操作のみ出来るようにしてあります。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InariFox.TalkLib
{
    public class talkDriver
    {
        private Dictionary<string, object> narratorset;
        public talkDriver()
        {
            narratorset = new Dictionary<string, object>();
            narratorset.Add("yukari", new yukaLib());
            narratorset.Add("bouyomi", new bouyomiLib());
            //narratorset.Add("maki", new makiLib());
        }
        ~talkDriver()
        {
            foreach(object obj in narratorset)
            {
                if (obj is bouyomiLib)
                {
                    bouyomiLib o = (bouyomiLib)obj;
                    o = null;
                }
                else if (obj is yukaLib)
                {
                    yukaLib o = (yukaLib)obj;
                    o = null;
                }
            }
            narratorset = null;
        }

        /// <summary>
        /// 読み上げるテキストを設定します。
        /// 処理に成功した場合はtrueを、
        /// 処理に失敗したりリストに対象ターゲットがなかった場合はfalseを返します。
        /// </summary>
        /// <param name="target">読み上げターゲットのキー</param>
        /// <param name="text">読み上げるテキスト</param>
        /// <returns>ターゲットが存在したか</returns>
        public bool setText(string target, string text)
        {
            bool result = false;
            if (isCanNarrator(target))
            {
                if (narratorset[target] is bouyomiLib)
                {
                    bouyomiLib obj = (bouyomiLib)narratorset[target];
                    obj.setText(text);
                }
                else if (narratorset[target] is yukaLib)
                {
                    yukaLib obj = (yukaLib)narratorset[target];
                    obj.setText(text);
                }
            }

            return result;
        }

        /// <summary>
        /// 音声合成タスクを追加/再生します。
        /// 処理に成功した場合はtrueを、
        /// 処理に失敗したりリストに対象ターゲットがなかった場合はfalseを返します。
        /// </summary>
        /// <param name="target">追加/再生するターゲット</param>
        /// <returns>処理結果</returns>
        public bool Play(string target)
        {
            bool result = false;
            if (isCanNarrator(target))
            {
                if (narratorset[target] is bouyomiLib)
                {
                    bouyomiLib obj = (bouyomiLib)narratorset[target];
                    result = obj.Play();
                }
                else if (narratorset[target] is yukaLib)
                {
                    yukaLib obj = (yukaLib)narratorset[target];
                    result = obj.Play();
                }
            }

            return result;
        }

        /// <summary>
        /// 現在対応している音声合成ソフトウェアの一覧を取得します。
        /// 一覧の追加にはITalkLibインタフェースまたはVroidLibを継承したクラスを作成し
        /// コンストラクタで読み込ませる必要があります。
        /// </summary>
        /// <returns>対応している音声合成ソフトウェアの一覧</returns>
        public List<string> getNarratorList()
        {
            return narratorset.Keys.ToList();
        }

        /// <summary>
        /// 渡されたキーに合致する現在登録されている音声合成ソフトウェアがあるか調べます。
        /// 存在した場合はtrue、存在しなかった場合はfalseを返します。
        /// </summary>
        /// <param name="target">探索キー</param>
        /// <returns>探索結果</returns>
        private bool isCanNarrator(string target){ return narratorset.ContainsKey(target); }
    }
}
