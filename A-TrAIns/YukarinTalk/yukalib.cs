using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

// yukalib - C#でゆかりさんに読み上げてもらえるように出来るライブラリ
// 2016-11-18 @ InariFox
// Voiceroid+ 結月ゆかり EX バージョン1.7.3でのみ動作確認済

/* MEMO(ウィンドウの親子関係の例/間にかましてあるウィンドウとかもあるので実際はもっと階層が深い)
 *  984040 - 2491126 - 2165764 - 2294768 - 5900114 - 1509502 - 4851298 - 14420494 - 1770784(テキストボックス)
 *  984040 - 2491126 - 2165764 - 2294768 - 5900114 - 1509502 - 4851298 - 3869376 - 2427326(再生ボタン)
 */

namespace YukarinTalk
{
    public class yukalib
    {
        // Win32API関係
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr ptr, StringBuilder lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        const uint GW_HWNDFIRST = 0; // hWnd と同種のウィンドウでもっとも z-order が高いものを取得
        const uint GW_HWNDLAST = 1;  // hWnd と同種のウィンドウでもっとも z-order が低いものを取得
        const uint GW_HWNDNEXT = 2;  // hWnd と同種のウィンドウで z-order が次の順番のものを取得
        const uint GW_HWNDPREV = 3;  // hWnd と同種のウィンドウで z-order が前の順番のものを取得
        const uint GW_OWNER = 4;     // hWnd のオーナーを取得
        const uint GW_CHILD = 5;     // hWnd の子ウィンドウのうちもっとも z-order が高いものを取得

        // 操作関係
        const uint WM_LBUTTONDOWN = 0x0201; //左ボタン押下
        const uint WM_LBUTTONUP = 0x0202; //左ボタン離した
        //const uint EM_STREAMIN = 0x0449; // テキスト入力
        const uint WM_SETTEXT = 0x000C; // テキスト入力

        // 操作対象(ゆかりさん)
        const string titleStr = "VOICEROID＋ 結月ゆかり EX";

        // 読み上げるテキスト
        private string text;

        // コンストラクト
        public yukalib()
        {
            text = "";  // null突っ込んで何起きるか分からないので空文字で初期化しておく。
        }
        public yukalib(string str)
        {
            text = str;
        }

        // 読み上げる文章を設定
        public void setText(string str)
        {
            text = str;
        }

        // ゆかりさんに読み上げてもらう。
        // TODO:ゆかりさん探す部分は分割しておいたほうがいいかも知れない。
        // TODO:あとは万が一ゆかりさんが落ちた時用に再探索の処理とか。
        public bool Play()
        {
            // 結果リザルトを格納
            bool result = false;

            // プロセス一覧を取得してそこからゆかりさんを探し出す。
            Process[] ps = Process.GetProcesses();

            // 全プロセスを探索
            foreach (Process pitem in ps)
            {
                // 探し出せた時の処理
                if ((pitem.MainWindowHandle != IntPtr.Zero) && (pitem.MainWindowTitle.Contains(titleStr)))  //Containsなのはテキストを書き換えると*が最後につくため。
                {
                    // ちゃんと読むかまではわからないけど
                    // ゆかりさんがいることがわかったのでresultにtrueを入れる
                    result = true;

                    // ウィンドウハンドル格納用
                    IntPtr hWndButton, hWndTextbox, hWndWorkPtr1, hWndWorkPtr2;

                    // 探し出したゆかりさんのメインハンドルを取得
                    hWndWorkPtr1 = pitem.MainWindowHandle;

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
                    SetForegroundWindow(pitem.MainWindowHandle);

                    // ゆかりさんに渡す読み上げるテキストを生成
                    StringBuilder sb = new StringBuilder(text);
                    SendMessage(hWndTextbox, WM_SETTEXT, IntPtr.Zero, sb);

                    // 再生ボタンを押す
                    PostMessage(hWndButton, WM_LBUTTONDOWN, 0, 0);
                    PostMessage(hWndButton, WM_LBUTTONUP, 0, 0);
                }
            }

            return result;
        }
    }
}