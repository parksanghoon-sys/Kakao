using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Kakao.LayoutSupport.UI.Units
{
    public class FriendsBox : ListBox
    {
        public static readonly DependencyProperty DoubleClickCommandProperty =
            DependencyProperty.Register(
                "DoubleClickCommand",
                typeof(ICommand),
                typeof(FriendsBox), new PropertyMetadata(null));
        public ICommand DoubleClickCommand
        {
            get => (ICommand)GetValue(DoubleClickCommandProperty);
            set => SetValue(DoubleClickCommandProperty, value);
        }
        public FriendsBox()
        {
            
        }
        protected override void OnMouseDoubleClick(MouseButtonEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            if(e.OriginalSource is FrameworkElement fe && fe.DataContext != null)
            {
                DoubleClickCommand?.Execute(fe.DataContext);
            }
        }
        static FriendsBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsBox), new FrameworkPropertyMetadata(typeof(FriendsBox)));
        }
    }
}
