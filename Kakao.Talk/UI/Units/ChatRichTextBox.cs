using Kakao.LayoutSupport.UI.Units;
using Kakao.Talk.TextMessage.UI.Units;
using System.Windows.Controls;

namespace Kakao.Talk.UI.Units
{
    public class ChatRichTextBox : CustomRichTextBox
    {
        protected override Control GetContainerForItemOverride()
        {
            return new TextMessageItem();
        }
    }
}
