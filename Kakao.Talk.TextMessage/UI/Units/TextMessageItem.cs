using System.Windows;
using System.Windows.Controls;

namespace Kakao.Talk.TextMessage.UI.Units
{
    public class TextMessageItem : Control
    {
        static TextMessageItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextMessageItem), new FrameworkPropertyMetadata(typeof(TextMessageItem)));
        }
    }
}
