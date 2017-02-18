using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Runtime.Remoting;

namespace InariFox.TalkLib
{
    class bouyomiLib : IDisposable
    {
        private string text;
        protected IpcClientChannel ClientChannel;
        protected BouyomiChanRemoting RemotingObject;

        /// <summary>
        /// オブジェクト生成。
        /// 利用後にはDispose()で開放してください。
        /// </summary>
        public bouyomiLib()
        {
            string chname = DateTime.Now.ToLongTimeString();
            ClientChannel = new IpcClientChannel(chname, null);
            ChannelServices.RegisterChannel(ClientChannel, false);
            RemotingObject = (BouyomiChanRemoting)Activator.GetObject(typeof(BouyomiChanRemoting), "ipc://BouyomiChan/Remoting");
        }
        /// <summary>
        /// ファイナライザ（Dispose Finalizeパターン実装）
        /// </summary>
        ~bouyomiLib()
        {
            Dispose(false);
        }

        /// <summary>
        /// オブジェクト開放。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// オブジェクト開放。(Dispose Finalizeパターン実装)
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (ClientChannel != null)
            {
                ChannelServices.UnregisterChannel(ClientChannel);
                ClientChannel = null;
            }
        }

        /// <summary>
        /// 読み上げたいテキストをセットします。
        /// 棒読みちゃんに音声合成タスクとして追加するには、セットした後にPlay()で追加して下さい。
        /// </summary>
        /// <param name="str">喋らせたい文章</param>
        public void setText(string str)
        {
            text = str;
        }

        /// <summary>
        /// 棒読みちゃんに音声合成タスクを追加します。
        /// </summary>
        public bool Play()
        {
            try
            {
                RemotingObject.AddTalkTask(text);
                return true;
            }
            catch (RemotingException)
            {
                return false;
            }
        }

        /// <summary>
        /// 棒読みちゃんの残りのタスクを全て消去します。
        /// </summary>
        public void clearrTalkTasks()
        {
            RemotingObject.ClearTalkTasks();
        }

        /// <summary>
        /// 棒読みちゃんが現在、音声を再生している最中かどうかを取得します。
        /// </summary>
        public bool NowPlaying
        {
            get { return RemotingObject.NowPlaying; }
        }
    }

    /// <summary>
    /// .NET Remotingのためのクラス。（本クラスの内容を変更してしまうと通信できなくなってしまいます）
    /// </summary>
    class BouyomiChanRemoting : MarshalByRefObject
    {
        public void AddTalkTask(string sTalkText) { }
        public void AddTalkTask(string sTalkText, int iSpeed, int iVolume, int vType) { }
        public void AddTalkTask(string sTalkText, int iSpeed, int iTone, int iVolume, int vType) { }
        public int AddTalkTask2(string sTalkText) { throw null; }
        public int AddTalkTask2(string sTalkText, int iSpeed, int iTone, int iVolume, int vType) { throw null; }
        public void ClearTalkTasks() { }
        public void SkipTalkTask() { }

        public int TalkTaskCount { get { throw null; } }
        public int NowTaskId { get { throw null; } }
        public bool NowPlaying { get { throw null; } }
        public bool Pause { get { throw null; } set { } }
    }
}
