using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
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
    ///     <MyNamespace:WpfWindow/>
    ///
    /// </summary>
    public class WpfWindow : Window
    {
        static WpfWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WpfWindow), new FrameworkPropertyMetadata(typeof(WpfWindow)));
        }

        public WpfWindow() : base()
        {

        }


        /// <summary>
        /// 属性变更回调函数
        /// </summary>
        static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(e.Property, e.NewValue);
        }

        /// <summary>
        /// 是否显示标题栏占位符
        /// </summary>
        public bool TitleBarPlaceHolder
        {
            get { return (bool)GetValue(TitleBarPlaceHolderProperty); }
            set { SetValue(TitleBarPlaceHolderProperty, value); }
        }

        public static readonly DependencyProperty TitleBarPlaceHolderProperty =
            DependencyProperty.Register("TitleBarPlaceHolder", typeof(bool), typeof(WpfWindow), new PropertyMetadata(true, OnPropertyChanged));

        /// <summary>
        /// 是否展示Logo
        /// </summary>
        public Visibility ShowIcon
        {
            get { return (Visibility)GetValue(ShowIconProperty); }
            set { SetValue(ShowIconProperty, value); }
        }

        public static readonly DependencyProperty ShowIconProperty =
            DependencyProperty.Register("ShowIcon", typeof(Visibility), typeof(WpfWindow), new PropertyMetadata(Visibility.Visible, OnPropertyChanged));

        /// <summary>
        /// 是否展示标题栏
        /// </summary>
        public Visibility ShowTitle
        {
            get { return (Visibility)GetValue(ShowTitleProperty); }
            set { SetValue(ShowTitleProperty, value); }
        }

        public static readonly DependencyProperty ShowTitleProperty =
            DependencyProperty.Register("ShowTitle", typeof(Visibility), typeof(WpfWindow), new PropertyMetadata(Visibility.Visible, OnPropertyChanged));


        /// <summary>
        /// 标题颜色
        /// </summary>
        public SolidColorBrush TitleColor
        {
            get { return (SolidColorBrush)GetValue(TitleColorProperty); }
            set { SetValue(TitleColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleColorProperty =
            DependencyProperty.Register("TitleColor", typeof(SolidColorBrush), typeof(WpfWindow), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(255, 255, 255)), OnPropertyChanged));



        /// <summary>
        /// 是否展示设置按钮
        /// </summary>
        public Visibility ShowConfigButton
        {
            get { return (Visibility)GetValue(ShowConfigButtonProperty); }
            set { SetValue(ShowConfigButtonProperty, value); }
        }

        public static readonly DependencyProperty ShowConfigButtonProperty =
            DependencyProperty.Register("ShowConfigButton", typeof(Visibility), typeof(WpfWindow), new PropertyMetadata(Visibility.Collapsed, OnPropertyChanged));

        /// <summary>
        /// 是否展示最小化按钮
        /// </summary>
        public Visibility ShowMinButton
        {
            get { return (Visibility)GetValue(ShowMinButtonProperty); }
            set { SetValue(ShowMinButtonProperty, value); }
        }

        public static readonly DependencyProperty ShowMinButtonProperty =
            DependencyProperty.Register("ShowMinButton", typeof(Visibility), typeof(WpfWindow), new PropertyMetadata(Visibility.Visible, OnPropertyChanged));

        /// <summary>
        /// 是否展示最大化按钮
        /// </summary>
        public Visibility ShowMaxButton
        {
            get { return (Visibility)GetValue(ShowMaxButtonProperty); }
            set { SetValue(ShowMaxButtonProperty, value); }
        }

        public static readonly DependencyProperty ShowMaxButtonProperty =
            DependencyProperty.Register("ShowMaxButton", typeof(Visibility), typeof(WpfWindow), new PropertyMetadata(Visibility.Visible, OnPropertyChanged));


        /// <summary>
        /// 是否展示正常按钮
        /// </summary>
        public Visibility ShowNormalButton
        {
            get { return (Visibility)GetValue(ShowNormalButtonProperty); }
            set { SetValue(ShowNormalButtonProperty, value); }
        }

        public static readonly DependencyProperty ShowNormalButtonProperty =
            DependencyProperty.Register("ShowNormalButton", typeof(Visibility), typeof(WpfWindow), new PropertyMetadata(Visibility.Collapsed, OnPropertyChanged));



        /// <summary>
        /// 是否展示关闭按钮
        /// </summary>
        public Visibility ShowCloseButton
        {
            get { return (Visibility)GetValue(ShowCloseButtonProperty); }
            set { SetValue(ShowCloseButtonProperty, value); }
        }

        public static readonly DependencyProperty ShowCloseButtonProperty =
            DependencyProperty.Register("ShowCloseButton", typeof(Visibility), typeof(WpfWindow), new PropertyMetadata(Visibility.Visible, OnPropertyChanged));

        /// <summary>
        /// 窗口圆角
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(WpfWindow), new PropertyMetadata(new CornerRadius(0), OnPropertyChanged));


        /// <summary>
        /// 标题栏圆角
        /// </summary>
        public CornerRadius TitleBarCornerRadius
        {
            get { return (CornerRadius)GetValue(TitleBarCornerRadiusProperty); }
            set { SetValue(TitleBarCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleBarCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleBarCornerRadiusProperty =
            DependencyProperty.Register("TitleBarCornerRadius", typeof(CornerRadius), typeof(WpfWindow), new PropertyMetadata(new CornerRadius(0), OnPropertyChanged));



        /// <summary>
        /// 背景色
        /// </summary>
        public SolidColorBrush BackgroundColor
        {
            get { return (SolidColorBrush)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        public static readonly DependencyProperty BackgroundColorProperty =
            DependencyProperty.Register("BackgroundColor", typeof(SolidColorBrush), typeof(WpfWindow), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(246, 246, 246)), OnPropertyChanged));

        /// <summary>
        /// 标题栏背景色
        /// </summary>
        public SolidColorBrush TitleBarBackground
        {
            get { return (SolidColorBrush)GetValue(TitleBarBackgroundProperty); }
            set { SetValue(TitleBarBackgroundProperty, value); }
        }

        public static readonly DependencyProperty TitleBarBackgroundProperty =
            DependencyProperty.Register("TitleBarBackground", typeof(SolidColorBrush), typeof(WpfWindow), new PropertyMetadata(null, OnPropertyChanged));

        #region 窗口拉拽
        private const int WM_NCHITTEST = 0x0084;
        private const int WM_GETMINMAXINFO = 0x0024;
        private int WidthCorner = 12;                //拐角宽度
        private int ThicknessTransparentBorder = 0; //阴影宽度
        private int ThicknessBorder = 5;           //边框宽度
        private Point PointMouse = new Point();     //鼠标坐标

        /// <summary>
        /// 是否已经暂停拖拽拉伸大小
        /// </summary>
        public bool IsStopResize
        {
            get; set;
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            if (MaxHeight == double.PositiveInfinity)
            {
                MaxHeight = SystemParameters.WorkArea.Height + 12;
            }
            else
            {
                MaxHeight += 12;
            }
            if (MaxWidth == double.PositiveInfinity)
            {
                MaxWidth = SystemParameters.WorkArea.Width + 12;
            }
            else
            {
                MaxWidth += 12;
            }

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                if (ResizeMode != ResizeMode.NoResize)
                {
                    Win32.GetDpi();

                    //建立钩子，处理无边框窗口的拉拽
                    IntPtr handle = (new WindowInteropHelper(this)).Handle;
                    HwndSource hwndSource = HwndSource.FromHwnd(handle);
                    if (hwndSource != null)
                    {
                        hwndSource.AddHook(WindowProc);
                    }
                }


            }
            base.OnSourceInitialized(e);
        }

        private IntPtr WindowProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (IsStopResize)
            {
                return IntPtr.Zero;
            }
            switch (msg)
            {
                case WM_NCHITTEST:

                    if (WindowState != WindowState.Normal)
                    {
                        break;
                    }

                    PointMouse.X = (lParam.ToInt32() & 0xFFFF);
                    PointMouse.Y = (lParam.ToInt32() >> 16);
                    double left = Left * Win32.DpiX;
                    double top = Top * Win32.DpiY;
                    double width = ActualWidth * Win32.DpiX;
                    double height = ActualHeight * Win32.DpiY;



                    //窗口左上角
                    if (PointMouse.X > left + ThicknessTransparentBorder
                        && PointMouse.X <= left + ThicknessTransparentBorder + WidthCorner
                        && PointMouse.Y > top + ThicknessTransparentBorder
                        && PointMouse.Y <= top + ThicknessTransparentBorder + WidthCorner)
                    {
                        handled = true;
                        return new IntPtr((int)HitTest.HTTOPLEFT);
                    }
                    //窗口左下角
                    else if (PointMouse.X > left + ThicknessTransparentBorder
                        && PointMouse.X <= left + ThicknessTransparentBorder + WidthCorner
                        && PointMouse.Y < top + height - ThicknessTransparentBorder
                        && PointMouse.Y >= top + height - ThicknessTransparentBorder - WidthCorner)
                    {
                        handled = true;
                        return new IntPtr((int)HitTest.HTBOTTOMLEFT);
                    }
                    //窗口右上角
                    else if (PointMouse.X < left + width - ThicknessTransparentBorder
                        && PointMouse.X >= left + width - ThicknessTransparentBorder - WidthCorner
                        && PointMouse.Y > top + ThicknessTransparentBorder
                        && PointMouse.Y <= top + ThicknessTransparentBorder + WidthCorner)
                    {
                        handled = true;
                        return new IntPtr((int)HitTest.HTTOPRIGHT);
                    }
                    //窗口右下角
                    else if (PointMouse.X < left + width - ThicknessTransparentBorder
                        && PointMouse.X >= left + width - ThicknessTransparentBorder - WidthCorner
                        && PointMouse.Y < top + height - ThicknessTransparentBorder
                        && PointMouse.Y >= top + height - ThicknessTransparentBorder - WidthCorner)
                    {
                        handled = true;
                        return new IntPtr((int)HitTest.HTBOTTOMRIGHT);
                    }
                    //窗口左侧
                    else if (PointMouse.X > left + ThicknessTransparentBorder
                        && PointMouse.X <= left + ThicknessTransparentBorder + ThicknessBorder
                        && PointMouse.Y > top + ThicknessTransparentBorder
                        && PointMouse.Y < top + height - ThicknessTransparentBorder)
                    {
                        handled = true;
                        return new IntPtr((int)HitTest.HTLEFT);
                    }
                    //窗口右侧
                    else if (PointMouse.X < left + width - ThicknessTransparentBorder
                        && PointMouse.X >= left + width - ThicknessTransparentBorder - ThicknessBorder
                        && PointMouse.Y > top + ThicknessTransparentBorder
                        && PointMouse.Y < top + height - ThicknessTransparentBorder)
                    {
                        handled = true;
                        return new IntPtr((int)HitTest.HTRIGHT);
                    }
                    //窗口上方
                    else if (PointMouse.X > left + ThicknessTransparentBorder
                        && PointMouse.X < left + width - ThicknessTransparentBorder
                        && PointMouse.Y > top + ThicknessTransparentBorder
                        && PointMouse.Y <= top + ThicknessTransparentBorder + ThicknessBorder)
                    {
                        handled = true;
                        return new IntPtr((int)HitTest.HTTOP);
                    }
                    //窗口下方
                    else if (PointMouse.X > left + ThicknessTransparentBorder
                        && PointMouse.X < left + width - ThicknessTransparentBorder
                        && PointMouse.Y < top + height - ThicknessTransparentBorder
                        && PointMouse.Y >= top + height - ThicknessTransparentBorder - ThicknessBorder)
                    {
                        handled = true;
                        return new IntPtr((int)HitTest.HTBOTTOM);
                    }
                    //其他消息
                    else
                    {
                        break;
                    }

                    //case WM_GETMINMAXINFO:
                    //    WmGetMinMaxInfo(hwnd, lParam);
                    //    handled = true;
                    //    break;
            }
            return IntPtr.Zero;
        }

        private static void WmGetMinMaxInfo(IntPtr hwnd, IntPtr lParam)
        {
            var mmi = (MINMAXINFO)Marshal.PtrToStructure(lParam, typeof(MINMAXINFO));

            // Adjust the maximized size and position to fit the work area of the correct monitor
            int MONITOR_DEFAULTTONEAREST = 0x00000002;
            IntPtr monitor = MonitorFromWindow(hwnd, MONITOR_DEFAULTTONEAREST);

            if (monitor != IntPtr.Zero)
            {
                var monitorInfo = new MONITORINFO();
                GetMonitorInfo(monitor, monitorInfo);
                RECT rcWorkArea = monitorInfo.rcWork;
                RECT rcMonitorArea = monitorInfo.rcMonitor;
                mmi.ptMaxPosition.x = Math.Abs(rcWorkArea.left - rcMonitorArea.left) - 5;
                mmi.ptMaxPosition.y = Math.Abs(rcWorkArea.top - rcMonitorArea.top) - 5;
                mmi.ptMaxSize.x = Math.Abs(rcWorkArea.right - rcWorkArea.left) + 10;
                mmi.ptMaxSize.y = Math.Abs(rcWorkArea.bottom - rcWorkArea.top) + 10;
            }

            Marshal.StructureToPtr(mmi, lParam, true);
        }


        [DllImport("user32")]
        internal static extern bool GetMonitorInfo(IntPtr hMonitor, MONITORINFO lpmi);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("User32")]
        internal static extern IntPtr MonitorFromWindow(IntPtr handle, int flags);

        #region Nested type: MINMAXINFO

        [StructLayout(LayoutKind.Sequential)]
        internal struct MINMAXINFO
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        };

        #endregion

        #region Nested type: MONITORINFO

        /// <summary>
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal class MONITORINFO
        {
            /// <summary>
            /// </summary>            
            public int cbSize = Marshal.SizeOf(typeof(MONITORINFO));

            /// <summary>
            /// </summary>            
            public RECT rcMonitor;

            /// <summary>
            /// </summary>            
            public RECT rcWork;

            /// <summary>
            /// </summary>            
            public int dwFlags;
        }

        #endregion

        #region Nested type: POINT

        /// <summary>
        /// POINT aka POINTAPI
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal struct POINT
        {
            /// <summary>
            /// x coordinate of point.
            /// </summary>
            public int x;

            /// <summary>
            /// y coordinate of point.
            /// </summary>
            public int y;

            /// <summary>
            /// Construct a point of coordinates (x,y).
            /// </summary>
            public POINT(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        #endregion

        #region Nested type: RECT

        /// <summary> Win32 </summary>
        [StructLayout(LayoutKind.Sequential, Pack = 0)]
        internal struct RECT
        {
            /// <summary> Win32 </summary>
            public int left;

            /// <summary> Win32 </summary>
            public int top;

            /// <summary> Win32 </summary>
            public int right;

            /// <summary> Win32 </summary>
            public int bottom;

            /// <summary> Win32 </summary>
            public static readonly RECT Empty;

            /// <summary> Win32 </summary>
            public int Width
            {
                get { return Math.Abs(right - left); } // Abs needed for BIDI OS
            }

            /// <summary> Win32 </summary>
            public int Height
            {
                get { return bottom - top; }
            }

            /// <summary> Win32 </summary>
            public RECT(int left, int top, int right, int bottom)
            {
                this.left = left;
                this.top = top;
                this.right = right;
                this.bottom = bottom;
            }


            /// <summary> Win32 </summary>
            public RECT(RECT rcSrc)
            {
                left = rcSrc.left;
                top = rcSrc.top;
                right = rcSrc.right;
                bottom = rcSrc.bottom;
            }

            /// <summary> Win32 </summary>
            public bool IsEmpty
            {
                get
                {
                    // BUGBUG : On Bidi OS (hebrew arabic) left > right
                    return left >= right || top >= bottom;
                }
            }

            /// <summary> Return a user friendly representation of this struct </summary>
            public override string ToString()
            {
                if (this == Empty)
                {
                    return "RECT {Empty}";
                }
                return "RECT { left : " + left + " / top : " + top + " / right : " + right + " / bottom : " + bottom +
                       " }";
            }

            /// <summary> Determine if 2 RECT are equal (deep compare) </summary>
            public override bool Equals(object obj)
            {
                if (!(obj is Rect))
                {
                    return false;
                }
                return (this == (RECT)obj);
            }

            /// <summary>Return the HashCode for this struct (not garanteed to be unique)</summary>
            public override int GetHashCode()
            {
                return left.GetHashCode() + top.GetHashCode() + right.GetHashCode() + bottom.GetHashCode();
            }


            /// <summary> Determine if 2 RECT are equal (deep compare)</summary>
            public static bool operator ==(RECT rect1, RECT rect2)
            {
                return (rect1.left == rect2.left && rect1.top == rect2.top && rect1.right == rect2.right &&
                        rect1.bottom == rect2.bottom);
            }

            /// <summary> Determine if 2 RECT are different(deep compare)</summary>
            public static bool operator !=(RECT rect1, RECT rect2)
            {
                return !(rect1 == rect2);
            }
        }

        #endregion

        #endregion

        #region 点击窗体后拖动窗口
        Point _startPoint;
        bool _isMaxToNormalDraging = false, _isDoubleClick = false, _isDraging = false;

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            if (e.ButtonState == MouseButtonState.Pressed)
            {
                _startPoint = e.GetPosition(null);
                _isDraging = true;
            }
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);
            _isDraging = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.LeftButton == MouseButtonState.Pressed && _isDraging)
            {
                Point position = e.GetPosition(null);

                if (Math.Abs(position.X - _startPoint.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(position.Y - _startPoint.Y) > SystemParameters.MinimumVerticalDragDistance)
                {
                    if (!_isDoubleClick)
                    {
                        if (WindowState == WindowState.Maximized)
                        {
                            _isMaxToNormalDraging = true;

                            WindowState = WindowState.Normal;
                        }
                        DragMove();

                        _isMaxToNormalDraging = false;
                        _isDraging = false;
                    }
                    else
                    {
                        _isDoubleClick = false;
                    }
                }
            }
        }

        protected override void OnMouseDoubleClick(MouseButtonEventArgs e)
        {
            base.OnMouseDoubleClick(e);


            if (e.GetPosition(null).Y <= 26 && !VisualHelper.IsPopup(e.OriginalSource as DependencyObject) && e.LeftButton == MouseButtonState.Pressed)
            {
                if (ShowMaxButton == Visibility.Visible || ShowNormalButton == Visibility.Visible)
                {
                    _isDoubleClick = true;

                    if (WindowState == WindowState.Maximized)
                    {
                        WindowState = WindowState.Normal;
                    }
                    else
                    {
                        WindowState = WindowState.Maximized;
                    }
                }
            }
        }
        #endregion

        #region 窗口状态变化时的操作
        protected override void OnStateChanged(EventArgs e)
        {
            base.OnStateChanged(e);

            if (ShowMaxButton == Visibility.Visible || ShowNormalButton == Visibility.Visible)
            {
                if (WindowState == WindowState.Maximized)
                {
                    //HideShadow();
                    ShowMaxButton = Visibility.Collapsed;
                    ShowNormalButton = Visibility.Visible;
                }
                else if (WindowState == WindowState.Normal)
                {
                    //ShowShadow();
                    ShowMaxButton = Visibility.Visible;
                    ShowNormalButton = Visibility.Collapsed;
                }
            }
            if (_isMaxToNormalDraging && WindowState == WindowState.Normal)
            {
                Left = _startPoint.X - (Width / SystemParameters.PrimaryScreenWidth * _startPoint.X);
                Top = _startPoint.Y - 25;
            }
        }

        void ShowShadow()
        {
            Border border = Template.FindName("PART_Border", this) as Border;

            if (border != null)
            {
                //圆角
                border.CornerRadius = CornerRadius;

                //阴影
                border.Margin = new Thickness(10);//为了能显示出阴影
            }
        }

        void HideShadow()
        {
            Border border = Template.FindName("PART_Border", this) as Border;

            if (border != null)
            {
                //无圆角
                border.CornerRadius = new CornerRadius(0);

                //无阴影
                border.Margin = new Thickness(0);//为了隐藏阴影
            }
        }
        #endregion

        #region 自定义操作事件
        /// <summary>
        /// 配置按钮点击事件
        /// </summary>
        public event RoutedEventHandler ConfigButtonClick
        {
            add { AddHandler(ConfigButtonClickEvent, value); }
            remove { RemoveHandler(ConfigButtonClickEvent, value); }
        }
        public static readonly RoutedEvent ConfigButtonClickEvent =
            EventManager.RegisterRoutedEvent("ConfigButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WpfWindow));

        #endregion

    }

    public enum HitTest : int
    {
        HTERROR = -2,
        HTTRANSPARENT = -1,
        HTNOWHERE = 0,
        HTCLIENT = 1,
        HTCAPTION = 2,
        HTSYSMENU = 3,
        HTGROWBOX = 4,
        HTSIZE = HTGROWBOX,
        HTMENU = 5,
        HTHSCROLL = 6,
        HTVSCROLL = 7,
        HTMINBUTTON = 8,
        HTMAXBUTTON = 9,
        HTLEFT = 10,
        HTRIGHT = 11,
        HTTOP = 12,
        HTTOPLEFT = 13,
        HTTOPRIGHT = 14,
        HTBOTTOM = 15,
        HTBOTTOMLEFT = 16,
        HTBOTTOMRIGHT = 17,
        HTBORDER = 18,
        HTREDUCE = HTMINBUTTON,
        HTZOOM = HTMAXBUTTON,
        HTSIZEFIRST = HTLEFT,
        HTSIZELAST = HTBOTTOMRIGHT,
        HTOBJECT = 19,
        HTCLOSE = 20,
        HTHELP = 21,
    }
}
