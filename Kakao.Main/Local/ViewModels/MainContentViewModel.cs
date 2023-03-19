using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Kakao.Core.Names;
using Prism.Ioc;
using Prism.Regions;

namespace Kakao.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        public MainContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        [RelayCommand]
        private void Friends()
        {
            // Region.Add(FriendsView 를하겠다는 커맨드
            var contentRegion = _regionManager.Regions[RegionNameManager.Contentregion];
            var friendsContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Friends);

            if (!contentRegion.Views.Contains(friendsContent))
            {
                contentRegion.Add(friendsContent);
            }
            contentRegion.Activate(friendsContent);
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
