﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Kakao.Core.Models;
using Kakao.Core.Names;
using Prism.Ioc;
using Prism.Regions;
using System.Collections.ObjectModel;

namespace Kakao.Talk.Local.ViewModels
{
    public partial class TalkContentViewModel : ObservableBase
    {
        [ObservableProperty]
        private string _sendText;
        [ObservableProperty]
        private ObservableCollection<MessageModel> _chats;
        public TalkContentViewModel()
        {
            SendText = "";
            Chats = new();
        }
        [RelayCommand]
        private void Send()
        {
            Chats.Add(new MessageModel().DataGen("Send",SendText));
            SendText = "";
        }
    }
}
