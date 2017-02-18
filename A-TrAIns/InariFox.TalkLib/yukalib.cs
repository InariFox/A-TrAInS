using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

// yukalib - C#でゆかりさんに読み上げてもらえるように出来るライブラリ
// 2016-11-18 @ InariFox
// Voiceroid+ 結月ゆかり EX バージョン1.7.3でのみ動作確認済

namespace InariFox.TalkLib
{
    class yukaLib
    {
        // Win32API関係
        /// <summary>
        /// ウィンドウハンドルの探索と取得
        /// </summary>
        /// <param name="hWnd">探索対象</param>
        /// <param name="uCmd">探索対象からの関係</param>
        /// <returns>探知したウィンドウハンドル</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

        /// <summary>
        /// 対象のウィンドウハンドルにメッセージを送ります。(ボタン制御)
        /// </summary>
        /// <param name="hWnd">対象のウィンドウハンドル</param>
        /// <param name="Msg">送信するメッセージ</param>
        /// <param name="wParam">メッセージ特有の追加情報(何も無ければ0)</param>
        /// <param name="lParam">メッセージ特有の追加情報(何も無ければ0)</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        /// <summary>
        /// 対象のウィンドウハンドルにメッセージを送ります。(テキスト送信)
        /// </summary>
        /// <param name="hWnd">対象のウィンドウハンドル</param>
        /// <param name="Msg">送信するメッセージ</param>
        /// <param name="ptr">メッセージ特有の追加情報(何も無ければ0)</param>
        /// <param name="lParam">送信するテキスト</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr ptr, StringBuilder lParam);

        /// <summary>
        /// 特定のウィンドウをフォアグラウンドにします。
        /// </summary>
        /// <param name="hWnd">対象のウィンドウハンドル</param>
        /// <returns>操作結果</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        // ウィンドウハンドル探索関係
        private const uint GW_HWNDFIRST = 0; // hWnd と同種のウィンドウでもっとも z-order が高いものを取得
        private const uint GW_HWNDLAST = 1;  // hWnd と同種のウィンドウでもっとも z-order が低いものを取得
        private const uint GW_HWNDNEXT = 2;  // hWnd と同種のウィンドウで z-order が次の順番のものを取得
        private const uint GW_HWNDPREV = 3;  // hWnd と同種のウィンドウで z-order が前の順番のものを取得
        private const uint GW_OWNER = 4;     // hWnd のオーナーを取得
        private const uint GW_CHILD = 5;     // hWnd の子ウィンドウのうちもっとも z-order が高いものを取得

        // 操作関係
        private const uint WM_LBUTTONDOWN = 0x0201; //左ボタン押下
        private const uint WM_LBUTTONUP = 0x0202; //左ボタン離した
        private const uint WM_SETTEXT = 0x000C; // テキスト入力

        // 操作対象(ゆかりさん)
        private string titleStr;
        private IntPtr target;

        // 読み上げるテキスト
        private string text;

        /* -------------------------------------------------------------------------- */

        public yukaLib()
        {
            text = "";  // null突っ込んで何起きるか分からないので空文字で初期化しておく。
            setTargetTitle("VOICEROID＋ 結月ゆかり EX");
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
        private void setTargetHandle(IntPtr target)
        {
            this.target = target;
        }

        /// <summary>
        /// 制御対象のウィンドウハンドルを取得
        /// </summary>
        /// <returns>制御対象のウィンドウハンドル</returns>
        private IntPtr getTargetHandle()
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
        /// <param name="title">制御対象の探索</param>
        /// <returns>探索結果</returns>
        public bool searchTarget()
        {
            bool result = false;

            // プロセス一覧を取得してそこからゆかりさんを探し出す。
            Process[] ps = Process.GetProcesses();

            // 全プロセスを探索
            foreach (Process pitem in ps)
            {
                // 探し出せた時の処理
                if ((pitem.MainWindowHandle != IntPtr.Zero) && (pitem.MainWindowTitle.Contains(titleStr)))
                {
                    // ちゃんと読むかまではわからないけど
                    // ゆかりさんがいることがわかったのでresultにtrueを入れる
                    result = true;

                    // 探し出したゆかりさんのメインハンドルを取得
                    setTargetHandle(pitem.MainWindowHandle);

                }
            }

            return result;
        }

        /// <summary>
        /// 読み上げメソッド。
        /// </summary>
        public void Play()
        {
            // ウィンドウハンドル格納用
            IntPtr hWndButton, hWndTextbox, hWndWorkPtr1, hWndWorkPtr2;

            // 探し出したゆかりさんのメインハンドルを取得
            hWndWorkPtr1 = getTargetHandle();

            // 操作する部分を親ハンドルからたどる
            // 共通部分
            hWndWorkPtr1 = GetWindow(hWndWorkPtr1, GW_CHILD);
            hWndWorkPtr1 = GetWindow(hWndWorkPtr1, GW_CHILD);
            hWndWorkPtr1 = GetWindow(hWndWorkPtr1, GW_HWNDNEXT);
            hWndWorkPtr1 = GetWindow(hWndWorkPtr1, GW_CHILD);
            hWndWorkPtr1 = GetWindow(hWndWorkPtr1, GW_CHILD);
            hWndWorkPtr1 = GetWindow(hWndWorkPtr1, GW_CHILD);
            hWndWorkPtr1 = GetWindow(hWndWorkPtr1, GW_CHILD);
            hWndWorkPtr1 = GetWindow(hWndWorkPtr1, GW_CHILD);

            // もう一度たどるのは面倒臭いので共通部分までのウィンドウハンドルを保持
            hWndWorkPtr2 = hWndWorkPtr1;

            // テキストボックスのウィンドウハンドル
            hWndWorkPtr1 = GetWindow(hWndWorkPtr1, GW_CHILD);
            hWndTextbox = hWndWorkPtr1;

            // ボタンのウィンドウハンドル
            hWndWorkPtr2 = GetWindow(hWndWorkPtr2, GW_HWNDNEXT);
            hWndWorkPtr2 = GetWindow(hWndWorkPtr2, GW_CHILD);
            hWndButton = hWndWorkPtr2;

            // 実処理
            // ゆかりさんのフォーカスをアクティブにする
            SetForegroundWindow(getTargetHandle());

            // ゆかりさんに渡す読み上げるテキストを生成
            StringBuilder sb = new StringBuilder(text);
            SendMessage(hWndTextbox, WM_SETTEXT, IntPtr.Zero, sb);

            // 再生ボタンを押す
            PostMessage(hWndButton, WM_LBUTTONDOWN, 0, 0);
            PostMessage(hWndButton, WM_LBUTTONUP, 0, 0);

        }
    }
}