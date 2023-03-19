using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Kako.Forms.UI.Views
{
    public class FriendsContent : JamesContent
    {
        static FriendsContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsContent), new FrameworkPropertyMetadata(typeof(FriendsContent)));
        }
        public FriendsContent()
        {

        }
    }
}
