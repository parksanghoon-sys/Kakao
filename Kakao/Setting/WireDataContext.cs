using Jamesnet.Wpf.Global.Location;
using Kakao.Chats.Local.ViewModels;
using Kakao.Forms.Local.ViewModels;
using Kakao.Friends.Local.ViewModels;
using Kakao.Login.Local.ViewModels;
using Kakao.Main.Local.ViewModels;
using Kakao.More.Local.ViewModels;
using Kakao.Talk.Local.ViewModels;
using Kako.Forms.UI.Views;

namespace Kakao.Setting
{
    /// <summary>
    /// View 와 ViewModel을 연결해주는 클래스
    /// </summary>
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<KakaoWindow, KakaoViewModel>();           
            items.Register<LoginContent, LoginContentViewModel>();
            items.Register<FriendsContent, FriendsContentViewModel>();
            items.Register<MainContent, MainContentViewModel>();
            items.Register<ChatsContent, ChatsContentViewModel>();
            items.Register<MoreContent, MoreContentViewModel>();

            items.Register<TalkWindow, TalkViewModel>();
            items.Register<TalkContent, TalkContentViewModel>();
        }
    }
}
