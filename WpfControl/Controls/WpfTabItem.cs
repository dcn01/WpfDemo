using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfControl.Controls
{
    public class WpfTabItem : TabItem
    {
        public static readonly DependencyProperty MyMoverBrushProperty;
        public static readonly DependencyProperty MyEnterBrushProperty;
        public Brush MyMoverBrush
        {
            get
            {
                return base.GetValue(WpfTabItem.MyMoverBrushProperty) as Brush;
            }
            set
            {
                base.SetValue(WpfTabItem.MyMoverBrushProperty, value);
            }
        }
        public Brush MyEnterBrush
        {
            get
            {
                return base.GetValue(WpfTabItem.MyEnterBrushProperty) as Brush;
            }
            set
            {
                base.SetValue(WpfTabItem.MyEnterBrushProperty, value);
            }
        }
        static WpfTabItem()
        {
            WpfTabItem.MyMoverBrushProperty = DependencyProperty.Register("MyMoverBrush", typeof(Brush), typeof(WpfTabItem), new PropertyMetadata(null));
            WpfTabItem.MyEnterBrushProperty = DependencyProperty.Register("MyEnterBrush", typeof(Brush), typeof(WpfTabItem), new PropertyMetadata(null));
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(WpfTabItem), new FrameworkPropertyMetadata(typeof(WpfTabItem)));
        }
        public WpfTabItem()
        {
            base.Header = "";
            base.Background = Brushes.Blue;
        }
    }
}
