﻿using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Kako.Forms.UI.Views
{
    public class TalkWindow : JamesWindow
    {
        static TalkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TalkWindow), new FrameworkPropertyMetadata(typeof(TalkWindow)));
        }
        public TalkWindow()
        {
            //WindowStyle = WindowStyle.None;
            //AllowsTransparency = true;
        }
    }
}
