using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Kako.Forms.UI.Views
{
    public class TalkContent : JamesContent
    {
        static TalkContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TalkContent), new FrameworkPropertyMetadata(typeof(TalkContent)));
        }
  
    }
}
