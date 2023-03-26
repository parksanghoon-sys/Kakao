using Jamesnet.Wpf.Controls;
using Kakao.Core.Names;
using Prism.Ioc;
using Prism.Regions;

namespace Kakao.Forms.Local.ViewModels
{
    public partial class KakaoViewModel : IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        public KakaoViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }
        public void OnLoaded(IViewable view)
        {
            var mainRegion = _regionManager.Regions[RegionNameManager.Mainregion];
            var loginConetnt = _containerProvider.Resolve<IViewable>(ContentNameManager.Login);

            if (!mainRegion.Views.Contains(loginConetnt))
            {
                mainRegion.Add(loginConetnt);
            }
            mainRegion.Activate(loginConetnt);
        }
    }
}
