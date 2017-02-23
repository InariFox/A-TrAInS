using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace InariFox.TalkLib
{
    public class VroidLib : ITalkLib
    {
        // Win32API関係
        /// <summary>
        /// ウィンドウハンドルの探索と取得
        /// </summary>
        /// <param name="hWnd">探索対象</param>
        /// <param name="uCmd">探索対象からの関係</param>
        /// <returns>探知したウィンドウハンドル</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        protected static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

        /// <summary>
        /// 対象のウィンドウハンドルにメッセージを送ります。(ボタン制御)
        /// </summary>
        /// <param name="hWnd">対象のウィンドウハンドル</param>
        /// <param name="Msg">送信するメッセージ</param>
        /// <param name="wParam">メッセージ特有の追加情報(何も無ければ0)</param>
        /// <param name="lParam">メッセージ特有の追加情報(何も無ければ0)</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        protected static extern int PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        /// <summary>
        /// 対象のウィンドウハンドルにメッセージを送ります。(テキスト送信)
        /// </summary>
        /// <param name="hWnd">対象のウィンドウハンドル</param>
        /// <param name="Msg">送信するメッセージ</param>
        /// <param name="ptr">メッセージ特有の追加情報(何も無ければ0)</param>
        /// <param name="lParam">送信するテキスト</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        protected static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr ptr, StringBuilder lParam);

        /// <summary>
        /// 特定のウィンドウをフォアグラウンドにします。
        /// </summary>
        /// <param name="hWnd">対象のウィンドウハンドル</param>
        /// <returns>操作結果</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        protected static extern bool SetForegroundWindow(IntPtr hWnd);

        // ウィンドウハンドル探索関係
        protected const uint GW_HWNDFIRST = 0; // hWnd と同種のウィンドウでもっとも z-order が高いものを取得
        protected const uint GW_HWNDLAST = 1;  // hWnd と同種のウィンドウでもっとも z-order が低いものを取得
        protected const uint GW_HWNDNEXT = 2;  // hWnd と同種のウィンドウで z-order が次の順番のものを取得
        protected const uint GW_HWNDPREV = 3;  // hWnd と同種のウィンドウで z-order が前の順番のものを取得
        protected const uint GW_OWNER = 4;     // hWnd のオーナーを取得
        protected const uint GW_CHILD = 5;     // hWnd の子ウィンドウのうちもっとも z-order が高いものを取得

        // 操作関係
        protected const uint WM_LBUTTONDOWN = 0x0201; //左ボタン押下
        protected const uint WM_LBUTTONUP = 0x0202; //左ボタン離した
        protected const uint WM_SETTEXT = 0x000C; // テキスト入力

        // 操作対象(ゆかりさん)
        protected string titleStr;
        protected IntPtr target;

        // 読み上げるテキスト
        protected string text;

        /* -------------------------------------------------------------------------- */

        protected VroidLib()
        {
            text = "";  // null突っ込んで何起きるか分からないので空文字で初期化しておく。
            setTargetTitle("");
        }

        /// <summary>
        /// 読み上げる文章を設定します。実際の読み上げはPlay()で行います。
        /// </summary>
        /// <param name="str">読み上げる文章</param>
        public void setText(string str)
        {
            text = str;
        }

        /// <summary>
        /// 制御対象のウィンドウハンドルをセット
        /// </summary>
        /// <param name="target">制御対象のウィンドウハンドル</param>
        protected void setTargetHandle(IntPtr target)
        {
            this.target = target;
        }

        /// <summary>
        /// 制御対象のウィンドウハンドルを取得
        /// </summary>
        /// <returns>制御対象のウィンドウハンドル</returns>
        protected IntPtr getTargetHandle()
        {
            return target;
        }

        /// <summary>
        /// 探索対象のウィンドウ名をセット
        /// </summary>
        /// <param name="title">探索対象のウィンドウ名</param>
        public void setTargetTitle(string title)
        {
            this.titleStr = title;
        }

        /// <summary>
        /// 制御対象の探索。見つかればターゲットのセットを行いtrueを、見つからなければfalseを返します。
        /// </summary>
        /// <returns>探索結果</returns>
        protected bool searchTarget()
        {
            bool result = false;

            // プロセス一覧を取得してそこから探し出す。
            Process[] ps = Process.GetProcesses();
            foreach (Process pitem in ps)
            {
                // 探し出せた時の処理
                if ((pitem.MainWindowHandle != IntPtr.Zero) && (pitem.MainWindowTitle.Contains(titleStr)))
                {
                    result = true;

                    // メインハンドルを取得
                    setTargetHandle(pitem.MainWindowHandle);

                }
            }

            return result;
        }

        /// <summary>
        /// 読み上げメソッド。
        /// </summary>
        public bool Play()
        {
            bool result = searchTarget();

            if (result)
            {
                //読み上げ処理をここに記述
            }
            return result;
        }
    }
}
