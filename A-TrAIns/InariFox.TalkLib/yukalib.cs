using System;
using System.Text;

// yukalib - C#でゆかりさんに読み上げてもらえるように出来るライブラリ
// 2016-11-18 @ InariFox
// Voiceroid+ 結月ゆかり EX バージョン1.7.3でのみ動作確認済

namespace InariFox.TalkLib
{
    class yukaLib : VroidLib
    {
        public yukaLib()
        {
            text = "";  // null突っ込んで何起きるか分からないので空文字で初期化しておく。
            setTargetTitle("VOICEROID＋ 結月ゆかり EX");
        }

        /// <summary>
        /// 読み上げメソッド。
        /// </summary>
        new public bool Play()
        {
            bool result = searchTarget();

            if (result)
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

            return result;
        }
    }
}