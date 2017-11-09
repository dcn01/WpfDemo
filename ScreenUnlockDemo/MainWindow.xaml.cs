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

namespace ScreenUnlockDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public IList<string> PointArray
        {
            get { return (IList<string>)GetValue(PointArrayProperty); }
            set { SetValue(PointArrayProperty, value); }
        }
        public static readonly DependencyProperty PointArrayProperty =
            DependencyProperty.Register("PointArray", typeof(IList<string>), typeof(MainWindow), new PropertyMetadata(new List<string>() { "00", "01", "02", "12" }));
    }
}
