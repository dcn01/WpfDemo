#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "346A5698E41F2F40D37D326AE50AF8E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using ViewPicture;


namespace ViewPicture
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid IMG;

#line default
#line hidden


#line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderWin;

#line default
#line hidden


#line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer BackFrame;

#line default
#line hidden


#line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IMG1;

#line default
#line hidden


#line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button borderClose;

#line default
#line hidden


#line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridProgress;

#line default
#line hidden


#line 83 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtProgress;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ViewPicture;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.win = ((ViewPicture.MainWindow)(target));

#line 8 "..\..\MainWindow.xaml"
                    this.win.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.IMG1_MouseWheel);

#line default
#line hidden
                    return;
                case 2:

#line 14 "..\..\MainWindow.xaml"
                    ((System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames)(target)).Completed += new System.EventHandler(this.DoubleAnimationUsingKeyFrames_Completed);

#line default
#line hidden
                    return;
                case 3:
                    this.IMG = ((System.Windows.Controls.Grid)(target));
                    return;
                case 4:
                    this.borderWin = ((System.Windows.Controls.Border)(target));
                    return;
                case 5:
                    this.BackFrame = ((System.Windows.Controls.ScrollViewer)(target));

#line 35 "..\..\MainWindow.xaml"
                    this.BackFrame.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BackFrame_MouseLeftButtonDown);

#line default
#line hidden
                    return;
                case 6:

#line 36 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.ContentControl)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.IMG1_MouseLeftButtonDown);

#line default
#line hidden

#line 37 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.ContentControl)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.IMG1_MouseLeftButtonUp);

#line default
#line hidden

#line 38 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.ContentControl)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.IMG1_MouseMove);

#line default
#line hidden
                    return;
                case 7:
                    this.IMG1 = ((System.Windows.Controls.Image)(target));
                    return;
                case 8:
                    this.borderClose = ((System.Windows.Controls.Button)(target));

#line 44 "..\..\MainWindow.xaml"
                    this.borderClose.Click += new System.Windows.RoutedEventHandler(this.borderClose_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.gridProgress = ((System.Windows.Controls.Grid)(target));
                    return;
                case 10:
                    this.txtProgress = ((System.Windows.Controls.TextBlock)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window win;
    }
}

