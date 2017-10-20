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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfControl.Controls
{
    /// <summary>
    /// frmOnlyShowMessageBox.xaml 的交互逻辑
    /// </summary>
    public partial class frmOnlyShowMessageBox : Window
    {
        public frmOnlyShowMessageBox()
        {
            InitializeComponent();
            this.DataContext = new model() { YOffSet = -300d };
            this.Loaded += (y, k) =>
            {
                this.Top = 41;
                this.Left = (SystemParameters.WorkArea.Width) / 2 - this.ActualWidth / 2;
                if (iserror)
                {
                    this.grid2.Visibility = Visibility.Collapsed;
                }
                else { this.grid2.Visibility = Visibility.Collapsed; }
            (this.Resources["ShowSb"] as Storyboard).Begin();
            };
        }

        private bool iserror = false;
        public void Show(string messageBoxText, bool iserror = false)
        {
            this.iserror = iserror;

            this.Message = messageBoxText;
            this.Show();
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }
        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(frmOnlyShowMessageBox), new PropertyMetadata("失败信息", OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(e.Property, e.NewValue);
        }
    }
    public class model : ViewModelBase
    {
        private double YOffset;
        public double YOffSet
        {
            get { return YOffset; }
            set
            {
                YOffset = value;
                RaisePropertyChanged(() => YOffSet);
            }
        }
    }
}
