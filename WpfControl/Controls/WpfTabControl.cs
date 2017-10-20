using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfControl.Controls
{
    public class WpfTabControl : TabControl
    {
        static WpfTabControl()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(WpfTabControl), new FrameworkPropertyMetadata(typeof(WpfTabControl)));
        }
    }
}
