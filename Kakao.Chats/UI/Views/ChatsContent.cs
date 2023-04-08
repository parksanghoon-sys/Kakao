using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Kako.Forms.UI.Views;

public class ChatsContent : JamesContent
{
    static ChatsContent()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ChatsContent), new FrameworkPropertyMetadata(typeof(ChatsContent)));
    }
    public ChatsContent()
    {

    }
}
