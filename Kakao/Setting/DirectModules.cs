using Prism.Ioc;
using Prism.Modularity;

namespace Kakao.Setting
{
    /// <summary>
    /// Region 을 만들어서 관리 현재 LoginContent 클래스 를 MainRegion에 연결하는 기능프리즘기능
    /// </summary>
    internal class DirectModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            ///// Resolve => 이미 관리되고 있는 인스턴스객체를 가져오거나 생성하고 관리할수있따
            //var regionManager = containerProvider.Resolve<IRegionManager>();
            ///// 프리즘 요소로서 리전이란게없지만 리전이 만들어지는과정에서 해당 뷰모델을 넣어준다?
            ///// MainRegion을 만든다
            //regionManager.RegisterViewWithRegion("MainRegion", "LoginContent");
            //// 인스턴스를 생성하고 ioc 에 넣어주지 않는다.

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
