using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Kako.Forms.UI.Views
{
    public class SimulatorWindow : JamesWindow
    {
        static SimulatorWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SimulatorWindow), new FrameworkPropertyMetadata(typeof(SimulatorWindow)));
        }
        public SimulatorWindow()
        {
            //WindowStyle = WindowStyle.None;
            //AllowsTransparency = true;
        }
    }
}
