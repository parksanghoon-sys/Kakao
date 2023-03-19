using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Kako.Forms.UI.Views
{
    public class MoreContent : JamesContent
    {
        static MoreContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MoreContent), new FrameworkPropertyMetadata(typeof(MoreContent)));
        }
        public MoreContent()
        {

        }
    }
}
