using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;

namespace Kakao.Login.Local.ViewModels
{
    public partial class LoginContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public LoginContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }
        [RelayCommand]
        private void Login()
        {
            // Region.Add(FriendsView 를하겠다는 커맨드
            var mainRegion = _regionManager.Regions["MainRegion"];
            var friendsContent = _containerProvider.Resolve<IViewable>("FriendsContent");

            if(!mainRegion.Views.Contains(friendsContent))
            {
                mainRegion.Add(friendsContent);
            }
            mainRegion.Activate(friendsContent);
        }
    }
}
