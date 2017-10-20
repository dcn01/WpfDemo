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
using WpfControl;

namespace ViewPicture
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleClickCloseCmd = new DeletgateCommand<string>(DoClose);
            this.DataContext = this;
        }

        private bool mouseDown;
        private bool imgIsDown = false;
        private Point mouseXY;

        private void DoClose(string obj)
        {
            this.Close();
        }


        public DeletgateCommand<string> DoubleClickCloseCmd { get; set; }

        private void IMG1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var img = sender as ContentControl;
            if (img == null)
            {
                return;
            }
            img.CaptureMouse();
            mouseDown = true;
            imgIsDown = true;
            mouseXY = e.GetPosition(img);
        }

        private void IMG1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var img = sender as ContentControl;
            if (img == null)
            {
                return;
            }
            img.ReleaseMouseCapture();
            mouseDown = false;
            imgIsDown = false;
        }

        private void IMG1_MouseMove(object sender, MouseEventArgs e)
        {
            var img = sender as ContentControl;
            if (img == null)
            {
                return;
            }
            if (mouseDown)
            {
                Domousemove(img, e);
            }
        }

        private void Domousemove(ContentControl img, MouseEventArgs e)
        {
            if (e.LeftButton != MouseButtonState.Pressed)
            {
                return;
            }
            var group = IMG.FindResource("Imageview") as TransformGroup;
            var transform = group.Children[1] as TranslateTransform;
            var transform2 = group.Children[0] as ScaleTransform;
            var position = e.GetPosition(img);

            // Return the general transform for the specified visual object.
            GeneralTransform generalTransform1 = IMG1.TransformToAncestor(borderWin);
            // Retrieve the point value relative to the parent.
            Point currentPoint = generalTransform1.Transform(new Point(0, 0));
            double left = currentPoint.X;
            double top = currentPoint.Y;
            double right = borderWin.ActualWidth - left - IMG1.ActualWidth * transform2.ScaleX;
            double bottom = borderWin.ActualHeight - top - IMG1.ActualHeight * transform2.ScaleY;
            bool IsFresh = false;

            if ((mouseXY.X - position.X < 0 && left < 0) || (mouseXY.X - position.X > 0 && right < 0))
            {
                if (mouseXY.X - position.X < 0 && transform.X - mouseXY.X + position.X > 0)
                    transform.X = 0;
                else if (mouseXY.X - position.X > 0 && transform.X - mouseXY.X + position.X < borderWin.ActualWidth - IMG1.ActualWidth * transform2.ScaleX)
                    transform.X = borderWin.ActualWidth - IMG1.ActualWidth * transform2.ScaleX;
                else
                {
                    transform.X -= mouseXY.X - position.X;
                }

                IsFresh = true;
            }


            if ((mouseXY.Y - position.Y < 0 && top < 0) || (mouseXY.Y - position.Y > 0 && bottom < 0))
            {
                if (mouseXY.Y - position.Y < 0 && transform.Y - mouseXY.Y + position.Y > 0)
                    transform.Y = 0;
                else if (mouseXY.Y - position.Y > 0 && transform.Y - mouseXY.Y + position.Y < borderWin.ActualHeight - IMG1.ActualHeight * transform2.ScaleY)
                    transform.Y = borderWin.ActualHeight - IMG1.ActualHeight * transform2.ScaleY;
                else
                {
                    transform.Y -= mouseXY.Y - position.Y;
                }
                IsFresh = true;
            }

            if (IsFresh)
            {
                mouseXY = position;
            }

        }

        private void IMG1_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            var img = sender as ContentControl;
            if (img == null)
            {
                return;
            }
            //var point = e.GetPosition(img);
            var point = new Point() { X = borderWin.ActualWidth / 2.0, Y = borderWin.ActualHeight / 2.0 };
            var group = IMG.FindResource("Imageview") as TransformGroup;
            var delta = e.Delta * 0.002;
            DowheelZoom(group, point, delta);
        }

        private void DowheelZoom(TransformGroup group, Point point, double delta)
        {
            var pointToContent = group.Inverse.Transform(point);
            var transform = group.Children[0] as ScaleTransform;
            if (transform.ScaleX + delta < 0.1) return;
            transform.ScaleX += delta;
            transform.ScaleY += delta;
            var transform1 = group.Children[1] as TranslateTransform;
            // Return the general transform for the specified visual object.
            GeneralTransform generalTransform1 = IMG1.TransformToAncestor(borderWin);
            // Retrieve the point value relative to the parent.
            Point currentPoint = generalTransform1.Transform(new Point(0, 0));
            double left = currentPoint.X;
            double top = currentPoint.Y;
            double right = borderWin.ActualWidth - left - IMG1.ActualWidth * transform.ScaleX;
            double bottom = borderWin.ActualHeight - top - IMG1.ActualHeight * transform.ScaleY;
            transform1.X = -1 * ((pointToContent.X * transform.ScaleX) - point.X);
            transform1.Y = -1 * ((pointToContent.Y * transform.ScaleY) - point.Y);
            //if (left >= 0&&left!=right)
            //    transform1.X = 5;
            //if (right >= 0 && left != right)
            //    transform1.X = borderWin.ActualWidth-IMG1.ActualWidth;
            //if (top >= 0 && top != bottom)
            //    transform1.Y = 5;
            //if (bottom >= 0 && top != bottom)
            //    transform1.Y = borderWin.ActualHeight - IMG1.ActualHeight;
        }

        private void BackFrame_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgIsDown)
            {
                return;
            }
            //int this.IMG1
            this.DragMove();
        }

        private void borderClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
