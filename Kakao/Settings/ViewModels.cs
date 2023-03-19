using Jamesnet.Wpf.Controls;
using Kakao.Core.Names;
using Kako.Forms.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Kakao.Settings
{
    /// <summary>
    /// LoginContent 라는 뷰네임에 뷰를 등록해주는곳
    /// </summary>
    internal class ViewModels : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            /// ioc 에서 주입해서사용할수 있도록 하는것 싱글톤 방식으로 생성 1개만 생성이 된다
            containerRegistry.RegisterSingleton<IViewable, LoginContent>(ContentNameManager.Login);
            containerRegistry.RegisterSingleton<IViewable, FriendsContent>(ContentNameManager.Friends);
            containerRegistry.RegisterSingleton<IViewable, MainContent>(ContentNameManager.Main);

            /// 생성당시 생성된다
            //containerRegistry.RegisterInstance(typeof(ViewModels));
        }
    }
}
