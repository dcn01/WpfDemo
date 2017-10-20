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
using WpfControl.Util;

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
    ///     <MyNamespace:ImageButton/>
    ///
    /// </summary>
    public class ImageButton : Button
    {
        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            d.SetValue(e.Property, e.NewValue);
        }

        /// <summary>
        /// 图标
        /// </summary>
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set
            {
                SetValue(IconProperty, value);
            }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(ImageSource), typeof(ImageButton), new PropertyMetadata(null, OnPropertyChanged));


        /// <summary>
        /// 是否显示图标
        /// </summary>
        public Visibility IconVisibility
        {
            get { return (Visibility)GetValue(IconVisibilityProperty); }
            set { SetValue(IconVisibilityProperty, value); }
        }


        public static readonly DependencyProperty IconVisibilityProperty =
            DependencyProperty.Register("IconVisibility", typeof(Visibility), typeof(ImageButton), new PropertyMetadata(Visibility.Visible, OnPropertyChanged));


        /// <summary>
        /// 是否显示文本
        /// </summary>
        public Visibility TextVisibility
        {
            get { return (Visibility)GetValue(TextVisibilityProperty); }
            set { SetValue(TextVisibilityProperty, value); }
        }

        public static readonly DependencyProperty TextVisibilityProperty =
            DependencyProperty.Register("TextVisibility", typeof(Visibility), typeof(ImageButton), new PropertyMetadata(Visibility.Visible, OnPropertyChanged));


        /// <summary>
        /// 图标边距
        /// </summary>
        public Thickness IconPadding
        {
            get { return (Thickness)GetValue(IconPaddingProperty); }
            set { SetValue(IconPaddingProperty, value); }
        }


        public static readonly DependencyProperty IconPaddingProperty =
            DependencyProperty.Register("IconPadding", typeof(Thickness), typeof(ImageButton), new PropertyMetadata(new Thickness(2), OnPropertyChanged));

        /// <summary>
        /// 按钮文本
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ImageButton), new PropertyMetadata("", OnPropertyChanged));



        /// <summary>
        /// 文本边距
        /// </summary>
        public Thickness TextPadding
        {
            get { return (Thickness)GetValue(TextPaddingProperty); }
            set { SetValue(TextPaddingProperty, value); }
        }


        public static readonly DependencyProperty TextPaddingProperty =
            DependencyProperty.Register("TextPadding", typeof(Thickness), typeof(ImageButton), new PropertyMetadata(new Thickness(3), OnPropertyChanged));



        /// <summary>
        /// 图标位置
        /// </summary>
        public Dock IconDock
        {
            get { return (Dock)GetValue(IconDockProperty); }
            set { SetValue(IconDockProperty, value); }
        }

        public static readonly DependencyProperty IconDockProperty =
            DependencyProperty.Register("IconDock", typeof(Dock), typeof(ImageButton), new PropertyMetadata(Dock.Top, OnPropertyChanged));


        /// <summary>
        /// 按钮图标宽度
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(ImageButton), new PropertyMetadata(double.Parse("10"), OnPropertyChanged));


        /// <summary>
        /// 按钮图标高度
        /// </summary>
        public double IconHeigth
        {
            get { return (double)GetValue(IconHeigthProperty); }
            set { SetValue(IconHeigthProperty, value); }
        }

        public static readonly DependencyProperty IconHeigthProperty =
            DependencyProperty.Register("IconHeigth", typeof(double), typeof(ImageButton), new PropertyMetadata(double.Parse("10"), OnPropertyChanged));

        /// <summary>
        /// 按钮圆角
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ImageButton), new PropertyMetadata(new CornerRadius(0), OnPropertyChanged));

        protected override void OnClick()
        {
            base.OnClick();

            if (!string.IsNullOrEmpty(Name) && Name == "PART_Close_TabItem")
            {
                TabItemClose itemclose = VisualHelper.FindVisualParent<TabItemClose>(this);
                (itemclose.Parent as TabControl).Items.Remove(itemclose);
                RoutedEventArgs args = new RoutedEventArgs(TabItemClose.CloseItemEvent, itemclose);
                itemclose.RaiseEvent(args);
            }

        }
    }
}
