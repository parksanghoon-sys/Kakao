using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Core.Interface
{
    public interface IReceivedMessage
    {
        string Message { get; }

        void Receive(string receiveText);
    }
}
