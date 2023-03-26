using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Kako.Forms.UI.Views
{
    public class KakaoWindow : JamesWindow
    {
        static KakaoWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KakaoWindow), new FrameworkPropertyMetadata(typeof(KakaoWindow)));
        }
        public KakaoWindow()
        {
            //WindowStyle = WindowStyle.None;
            //AllowsTransparency = true;
        }
    }
}
