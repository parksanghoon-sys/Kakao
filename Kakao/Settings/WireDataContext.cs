﻿using Jamesnet.Wpf.Global.Location;
using Kakao.Forms.Local.ViewModels;
using Kakao.Friends.Local.ViewModels;
using Kakao.Login.Local.ViewModels;
using Kako.Forms.UI.Views;

namespace Kakao.Settings
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
        }
    }
}
