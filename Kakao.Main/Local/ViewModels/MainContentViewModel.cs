using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Kakao.Core.Models;
using Kakao.Core.Names;
using Prism.Ioc;
using Prism.Regions;
using System.Collections.Generic;

namespace Kakao.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        [ObservableProperty]
        private List<MenuModel> _menus;

        [ObservableProperty]
        private MenuModel _menu;
        public MainContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;

            Menus = GetMenus();
        }
        partial void OnMenuChanged(MenuModel value)
        {
            var contentRegion = _regionManager.Regions[RegionNameManager.Contentregion];
            var content = _containerProvider.Resolve<IViewable>(value.Id);

            if (!contentRegion.Views.Contains(content))
            {
                contentRegion.Add(content);
            }
            contentRegion.Activate(content);
        }
        private List<MenuModel> GetMenus()
        {
            List<MenuModel> sourse = new();
            sourse.Add(new MenuModel().DataGetId(ContentNameManager.Chats));
            sourse.Add(new MenuModel().DataGetId(ContentNameManager.Friends));
            sourse.Add(new MenuModel().DataGetId(ContentNameManager.More));
            return sourse;
        }

        [RelayCommand]
        private void Login()
        {
            // Region.Add(FriendsView 를하겠다는 커맨드
            var mainRegion = _regionManager.Regions[RegionNameManager.Mainregion];
            var LoginContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Login);

            if (!mainRegion.Views.Contains(LoginContent))
            {
                mainRegion.Add(LoginContent);
            }
            mainRegion.Activate(LoginContent);
        }

    }
}
