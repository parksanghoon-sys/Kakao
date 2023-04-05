using Kakao.Core.Interface;

namespace Kakao.Core.Models
{
    public class MessageModel : IMessage
    {
        public string Type { get; set; }
        public string Message { get; set; }

        public MessageModel DataGen(string v, string sendText)
        {
            Type = v;
            Message = sendText;
            return this;
        }
    }
}
