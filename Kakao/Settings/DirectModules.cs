using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Settings
{
    internal class DirectModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            /// Resolve => 이미 관리되고 있는 인스턴스객체를 가져오거나 생성하고 관리할수있따
            var regionManager = containerProvider.Resolve<IRegionManager>();
            /// 프리즘 요소로서 리전이란게없지만 리전이 만들어지는과정에서 해당 뷰모델을 넣어준다?
            /// 
            regionManager.RegisterViewWithRegion("MainRegion", "LoginContent");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
