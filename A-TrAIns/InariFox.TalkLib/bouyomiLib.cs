using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Runtime.Remoting;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.IO;

namespace InariFox.TalkLib
{
    public class bouyomiLib : ITalkLib
    {
        private string text;
        private string host;
        private int port;
        private TcpClient tc;

        // コンストラクタ
        /// <summary>
        /// デフォルト値でインスタンスを生成します。
        /// </summary>
        public bouyomiLib()
        {
            host = "127.0.0.1";
            port = 50001;
        }
        /// <summary>
        /// ホスト名/ポート番号を指定してインスタンスを生成します。
        /// デフォルト値を使用する場合はnullまたは-1を指定して下さい
        /// </summary>
        /// <param name="host">ホスト名</param>
        /// <param name="port">ポート番号</param>
        public bouyomiLib(string host, int port)
        {
            this.host = "127.0.0.1";
            this.port = 50001;

            if (host != null){
                this.host = host;
            }
            if (port != -1)
            {
                this.port = port;
            }
        }

        /// <summary>
        /// Socket通信で棒読みちゃんに音声合成タスクを送信します。
        /// 通信に失敗場合はfalseを、送信が出きた場合はtrueを返します。
        /// </summary>
        /// <returns>送信結果</returns>
        public bool Play()
        {
            bool result = false;
            byte[] message = Encoding.UTF8.GetBytes(text);
            Int32 length = message.Length;

            if(connect(host, port) && tc != null)
            {
                //メッセージ送信
                using (NetworkStream ns = tc.GetStream())
                {
                    using (BinaryWriter bw = new BinaryWriter(ns))
                    {
                        byte bCode = 0;
                        Int16 iVoice = 1;
                        Int16 iVolume = -1;
                        Int16 iSpeed = -1;
                        Int16 iTone = -1;
                        Int16 iCommand = 0x0001;

                        bw.Write(iCommand); //コマンド（ 0:メッセージ読み上げ）
                        bw.Write(iSpeed);   //速度    （-1:棒読みちゃん画面上の設定）
                        bw.Write(iTone);    //音程    （-1:棒読みちゃん画面上の設定）
                        bw.Write(iVolume);  //音量    （-1:棒読みちゃん画面上の設定）
                        bw.Write(iVoice);   //声質    （ 0:棒読みちゃん画面上の設定、1:女性1、2:女性2、3:男性1、4:男性2、5:中性、6:ロボット、7:機械1、8:機械2、10001～:SAPI5）
                        bw.Write(bCode);    //文字列のbyte配列の文字コード(0:UTF-8, 1:Unicode, 2:Shift-JIS)
                        bw.Write(length);  //文字列のbyte配列の長さ
                        bw.Write(message); //文字列のbyte配列
                    }
                }
                result = true;

                //切断
                disconnect();
            }

            return result;
        }

        public void setText(string text)
        {
            this.text = text;
        }

        private bool connect(string host, int port)
        {
            bool result = false;

            try
            {
                tc = new TcpClient(host, port);
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("接続失敗");
                Console.WriteLine(ex);
            }

            return result;
        }

        private void disconnect()
        {
            if(tc != null)
            {
                tc.Close();
            }

            tc = null;
        }
    }
}
