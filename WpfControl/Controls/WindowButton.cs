using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControl.Controls
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfControl.Controls"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfControl.Controls;assembly=WpfControl.Controls"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误: 
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:WindowButton/>
    ///
    /// </summary>
    public class WindowButton : ImageButton
    {
        static WindowButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowButton), new FrameworkPropertyMetadata(typeof(WindowButton)));
        }

        /// <summary>
        /// 是否为关闭按钮
        /// </summary>
        public bool IsClose
        {
            get { return (bool)GetValue(IsCloseProperty); }
            set { SetValue(IsCloseProperty, value); }
        }

        public static readonly DependencyProperty IsCloseProperty =
            DependencyProperty.Register("IsClose", typeof(bool), typeof(WindowButton), new PropertyMetadata(false, OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(e.Property, e.NewValue);
        }

        protected override void OnClick()
        {
            base.OnClick();
            WpfWindow window = Window.GetWindow(this) as WpfWindow;
            if (window == null)
            {
                return;
            }
            RoutedEventArgs args = null;
            switch (Name)
            {
                case "_btnclose":
                    window.Close();
                    break;
                case "_btnmax":
                    window.WindowState = WindowState.Maximized;
                    break;
                case "_btnnormal":
                    window.WindowState = WindowState.Normal;
                    break;
                case "_btnmin":
                    window.WindowState = WindowState.Minimized;
                    break;
                case "_btnset":
                    args = new RoutedEventArgs(WpfWindow.ConfigButtonClickEvent, window);
                    window.RaiseEvent(args);
                    break;
            }
        }
    }
}
