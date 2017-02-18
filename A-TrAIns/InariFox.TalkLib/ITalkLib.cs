using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InariFox.TalkLib
{
    interface ITalkLib
    {
        void setText(string str);
        bool Play();
    }
}
