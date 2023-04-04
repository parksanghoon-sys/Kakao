﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Kakao.Core.Models;
using Kakao.Core.Names;
using Kako.Forms.UI.Views;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Kakao.Friends.Local.ViewModels
{

    public partial class FriendsContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        [ObservableProperty]
        private List<FriendsModel> _favorites;
        public FriendsContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
            Favorites = GetFavorites();
        }

        private List<FriendsModel> GetFavorites()
        {
            List<FriendsModel> source = new();
            source.Add(new FriendsModel().DataGen(1, "James"));
            source.Add(new FriendsModel().DataGen(2, "Vicky"));
            source.Add(new FriendsModel().DataGen(3, "Lucky"));

            return source;
        }
        [RelayCommand]
        private void DoubleClick(FriendsModel data)
        {

            TalkWindow talkWindow = new();
            talkWindow.Title = data.Name;
            talkWindow.Width = 360;
            talkWindow.Height = 500;
            talkWindow.ShowDialog();
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
    }
}
