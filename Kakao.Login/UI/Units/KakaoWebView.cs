using Kakao.LayoutSupport.UI.Units;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Kakao.Login.UI.Units
{
    public class KakaoWebView : WebView2
    {
        public static readonly DependencyProperty LoginCompletedCommandProperty = DependencyProperty.Register("LoginCompletedCommand", typeof(ICommand), typeof(KakaoWebView));

        public ICommand LoginCompletedCommand
        {
            get => (ICommand)GetValue(LoginCompletedCommandProperty);
            set => SetValue(LoginCompletedCommandProperty, value);
        }
        public KakaoWebView()
        {
            WebMessageReceived += KakaoWebView_WebMessageReceived;
        }

        private void KakaoWebView_WebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string userEmail = e.TryGetWebMessageAsString();

            LoginCompletedCommand.Execute(userEmail);
            //throw new NotImplementedException();
        }
    }
}
