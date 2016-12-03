using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using FNF.Utility;

namespace BouyomiTalk
{
    public class boulib
    {

        //棒読みちゃんに接続するためのオブジェクト
        private BouyomiChanClient BouyomiChan;

        private string text;

        public boulib()
        {
            //棒読みちゃんに接続
            BouyomiChan = new BouyomiChanClient();
        }
        ~boulib()
        {
            //棒読みちゃんへの接続を解除
            BouyomiChan.Dispose();
        }

        public void setText(string str)
        {
            text = str;
        }

        public bool Play()
        {
            try
            {
                BouyomiChan.AddTalkTask(text);
                return true;
            }
            catch (RemotingException)
            {
                return false;
            }
        }

        public void Close()
        {
            //棒読みちゃんへの接続を解除
            BouyomiChan.Dispose();
        }
    }
}
