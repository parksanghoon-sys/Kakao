using Jamesnet.Wpf.Controls;
using Kako.Forms.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Settings
{
    internal class ViewModels : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            /// ioc 에서 주입해서사용할수 있도록 하는것 싱글톤 방식으로 생성 1개만 생성이 된다
            containerRegistry.RegisterSingleton<IViewable, LoginContent>("LoginContent");
            
            /// 생성당시 생성된다
            //containerRegistry.RegisterInstance(typeof(ViewModels));
        }
    }
}
