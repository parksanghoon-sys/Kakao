using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Evemt;
using Jamesnet.Wpf.Mvvm;
using Kakao.Core.Args;
using Kakao.Core.Evnets;
using Kakao.Core.Interface;
using Kakao.Core.Models;
using Kakao.Core.Names;
using Kakao.Core.Talking;
using Kakao.Friends.Core.Args;
using Kakao.Receiver;
using Kako.Forms.UI.Views;
using Microsoft.AspNetCore.SignalR.Client;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kakao.Friends.Local.ViewModels
{

    public partial class FriendsContentViewModel : ObservableBase
    {
        private readonly HubManager _hubManager;
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        private readonly TalkWindowManager _talkWindowManager;
        private readonly IEventHub _evntHub;
        [ObservableProperty]
        private List<FriendsModel> _favorites;
        public FriendsContentViewModel(HubManager hubManager, IEventHub evntHub ,IRegionManager regionManager, IContainerProvider containerProvider, TalkWindowManager talkWindowManager)
        {
            _hubManager = hubManager;
            _regionManager = regionManager;
            _containerProvider = containerProvider;
            _talkWindowManager = talkWindowManager;
            _evntHub = evntHub;

            _talkWindowManager.WindowCountChanged += _talkWIndowManager_WindowCountChanged;
            //Favorites = GetFavorites();
            _evntHub.Subscribe<SyncFriendsPubSub, SyncFriendsArgs>(SyncFriendsReceived);
            _hubManager.Start(evntHub);
        }

        private void SyncFriendsReceived(SyncFriendsArgs obj)
        {
            Favorites = obj.Friends;
        }

        private void _talkWIndowManager_WindowCountChanged(object? sender, EventArgs e)
        {
            RefreshTalkWindowArgs arg = new();
            _evntHub.Publish<RefreshTalkWinodowEvnet, RefreshTalkWindowArgs>(arg);
        }

        private List<FriendsModel> GetFavorites()
        {
            List<FriendsModel> source = new();
            source.Add(new FriendsModel().DataGen("1", "James"));
            source.Add(new FriendsModel().DataGen("2", "Vicky"));
            source.Add(new FriendsModel().DataGen("3", "Lucky"));

            return source;
        }
        [RelayCommand]
        private void DoubleClick(FriendsModel data)
        {
            TalkContent talkContent = new TalkContent();
            TalkWindow talkWindow = _talkWindowManager.ResolveWindow<TalkWindow>(data.Id);
            talkWindow.Content = talkContent;
            talkWindow.Title = data.Name;
            talkWindow.Width = 360;
            talkWindow.Height = 500;
            if(talkContent.DataContext is IReceiverInfo info)
            {
                info.InitReceiver(data);
            }
            talkWindow.Show();
        }
        [RelayCommand]
        private void Logout()
        {
            // Region.Add(FriendsView 를하겠다는 커맨드
            var mainRegion = _regionManager.Regions[RegionNameManager.Mainregion];
            var loginContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Login);
            
            if(!mainRegion.Views.Contains(loginContent))
            {
                mainRegion.Add(loginContent);
            }
            mainRegion.Activate(loginContent);
        }
        [RelayCommand]
        private void ShowSimulator()
        {
            var simulatorWIndow = _containerProvider.Resolve<IViewable>(ContentNameManager.Simulator);
            if(simulatorWIndow is JamesWindow win) 
            {
                win.Show();
            }
        }

        [RelayCommand]
        private async Task SyncFriendsAsync()
        {
            await _hubManager.Connection.InvokeAsync("SyncFriends", new RequestInfo());
        }
    }
}
