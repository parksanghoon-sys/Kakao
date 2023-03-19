using Jamesnet.Wpf.Controls;
using Kakao.Login.Local.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Kako.Forms.UI.Views
{
    public class LoginContent : JamesContent
    {
        static LoginContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoginContent), new FrameworkPropertyMetadata(typeof(LoginContent)));
        }
        public LoginContent()
        {
            
        }
    }    
}
