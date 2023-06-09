﻿using Kakao.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Core.Talking
{
    public class ChatStorage
    {
        private Dictionary<FriendsModel, List<MessageModel>> _chatHistory;
        public ChatStorage()
        {
            _chatHistory = new();
        }
        public void Add(FriendsModel _receiver, MessageModel message)
        {
            if(_chatHistory.ContainsKey(_receiver) == false)
            {
                _chatHistory.Add(_receiver, new());
            }
            _chatHistory[_receiver].Add(message);
        }

        public List<MessageModel> GetChatHistory(FriendsModel _receiver)
        {
            if (_chatHistory.ContainsKey(_receiver) == false)
            {
                _chatHistory.Add(_receiver, new());
            }
            return _chatHistory[_receiver];
        }
    }
}
