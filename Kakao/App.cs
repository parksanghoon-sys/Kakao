using Kako.Forms.UI.Views;
using System.Windows;

namespace Kakao
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            KakaoWindow window = new KakaoWindow();
            window.Show();
        }
    }
}
