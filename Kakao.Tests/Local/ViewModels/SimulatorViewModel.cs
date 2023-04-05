using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Evemt;
using Jamesnet.Wpf.Mvvm;
using Kakao.Core.Evnets;
using Kakao.Core.Interface;
using Kakao.Core.Talking;
using Kakao.Friends.Core.Args;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Kakao.Tests.Local.ViewModels
{
    public partial class SimulatorViewModel : ObservableBase, IViewLoadable
    {
        private readonly IEventHub _eventHub;
        private readonly TalkWindowManager _talkWindowManager;

        [ObservableProperty]
        private List<KeyValuePair<int, JamesWindow>> _talkWindows;
        [ObservableProperty]
        private string _receiveText;
        [ObservableProperty]
        private KeyValuePair<int, JamesWindow> _window;
        public SimulatorViewModel(IEventHub eventHub,TalkWindowManager talkWindowManager)
        {
            _eventHub = eventHub;
            _talkWindowManager = talkWindowManager;

            _eventHub.Subscribe<RefreshTalkWinodowEvnet, RefreshTalkWindowArgs>((args) => Refresh());
        }
        public void OnLoaded(IViewable view)
        {
            Refresh();
        }
        [RelayCommand]
        private void Refresh()
        {
            TalkWindows = _talkWindowManager.GetAllWindows();
        }
        [RelayCommand]
        private void Receive()
        {
            //if(Window.Value is IReceivedMessage receive)    
            //{
            //    receive.Receive(ReceiveText);
            //}
            var content = Window.Value.Content;
            if(content is FrameworkElement fe && fe.DataContext is IReceivedMessage received)
            {
                received.Receive(ReceiveText);
            }
        }
    }
}
