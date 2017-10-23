using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

        #region 字段
        /// <summary>
        /// 鼠标左键是否按下
        /// </summary>
        private bool mouseDown;
        /// <summary>
        /// 图片是否已经按下
        /// </summary>
        private bool imgIsDown = false;
        /// <summary>
        /// 上一次鼠标所在位置点
        /// </summary>
        private Point mouseXY;
        /// <summary>
        /// 双击关闭事件
        /// </summary>
        public DeletgateCommand<string> DoubleClickCloseCmd { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImgPath { get; set; }
        #endregion

        #region 单例
        public static MainWindow frm = null;
        public static MainWindow Instanse
        {
            get
            {
                if (frm == null || !frm.IsLoaded)
                {
                    frm = new MainWindow();
                }
                return frm;
            }
        }

        #endregion

        #region 缩放移动
        /// <summary>
        /// 图片左键按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IMG1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var img = sender as ContentControl;
            if (img == null)
            {
                return;
            }
            img.CaptureMouse();
            mouseXY = e.GetPosition(img);
            var group = IMG.FindResource("Imageview") as TransformGroup;
            var transform = group.Children[1] as TranslateTransform;
            var transform2 = group.Children[0] as ScaleTransform;
            GeneralTransform generalTransform1 = IMG1.TransformToAncestor(borderWin);
            Point currentPoint = generalTransform1.Transform(new Point(0, 0));
            double left = currentPoint.X;
            double top = currentPoint.Y;
            double right = borderWin.ActualWidth - left - IMG1.ActualWidth * transform2.ScaleX;
            double bottom = borderWin.ActualHeight - top - IMG1.ActualHeight * transform2.ScaleY;
            if (left>=0&&right>=0&&top>=0&&bottom>=0)
            {
                mouseDown = false;

                this.DragMove();
            }
            else
            {
               
                imgIsDown = true;
                imgIsDown = true;
                mouseDown = true;
            }
        }

        /// <summary>
        /// 图片左键释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 图片鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 执行移动操作
        /// </summary>
        /// <param name="img"></param>
        /// <param name="e"></param>
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

            GeneralTransform generalTransform1 = IMG1.TransformToAncestor(borderWin);

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

        /// <summary>
        /// 在最外层执行滚轮操作，对应图片缩放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IMG1_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            var img = sender as Window;
            if (img == null)
            {
                return;
            }

            var point = new Point() { X = borderWin.ActualWidth / 2.0, Y = borderWin.ActualHeight / 2.0 };
            var group = IMG.FindResource("Imageview") as TransformGroup;
            var delta = e.Delta * 0.002;
            DowheelZoom(group, point, delta);
        }

        /// <summary>
        /// 执行缩放操作
        /// </summary>
        /// <param name="group"></param>
        /// <param name="point"></param>
        /// <param name="delta"></param>
        private void DowheelZoom(TransformGroup group, Point point, double delta)
        {
            var pointToContent = group.Inverse.Transform(point);
            var transform = group.Children[0] as ScaleTransform;
            if (transform.ScaleX + delta < 0.1) return;
            transform.ScaleX += delta;
            transform.ScaleY += delta;
            var transform1 = group.Children[1] as TranslateTransform;

            GeneralTransform generalTransform1 = IMG1.TransformToAncestor(borderWin);

            Point currentPoint = generalTransform1.Transform(new Point(0, 0));
            double left = currentPoint.X;
            double top = currentPoint.Y;
            double right = borderWin.ActualWidth - left - IMG1.ActualWidth * transform.ScaleX;
            double bottom = borderWin.ActualHeight - top - IMG1.ActualHeight * transform.ScaleY;

            if (transform.ScaleX > 1 && delta < 0)
            {
                bool XIsContinue = true;
                bool YIsContinue = true;
                //-------X
                if (right >= 0 && left < 0)
                {
                    transform1.X = borderWin.ActualWidth - IMG1.ActualWidth * transform.ScaleX;
                    XIsContinue = false;
                }

                if (left >= 0 && right < 0)
                {
                    transform1.X = 0;
                    XIsContinue = false;
                }

                if (XIsContinue)
                {
                    transform1.X = -1 * ((pointToContent.X * transform.ScaleX) - point.X);
                }

                //-------Y
                if (bottom >= 0 && top < 0)
                {
                    transform1.Y = borderWin.ActualHeight - IMG1.ActualHeight * transform.ScaleY;
                    YIsContinue = false;
                }

                if (top >= 0 && bottom < 0)
                {
                    transform1.Y = 0;
                    YIsContinue = false;
                }

                if (top < 0 && bottom < 0)
                {
                    transform1.Y = -1 * ((pointToContent.Y * transform.ScaleY) - point.Y);
                }

                if (YIsContinue)
                {
                    transform1.Y = -1 * ((pointToContent.Y * transform.ScaleY) - point.Y);
                }
            }
            else
            {
                transform1.X = -1 * ((pointToContent.X * transform.ScaleX) - point.X);
                transform1.Y = -1 * ((pointToContent.Y * transform.ScaleY) - point.Y);
            }

            this.gridProgress.Visibility = Visibility.Visible;
            int percent = (int)(transform.ScaleX * 100);
            if (percent == 100)
            {
                transform1.X = 0;
                transform1.Y = 0;
                transform.ScaleX = 1;
                transform.ScaleY = 1;
            }
            txtProgress.Text = string.Format("{0}%", percent);
            (this.Resources["ShowProgress"] as Storyboard).Begin();

        }

        private Point CPoint;
        /// <summary>
        /// 窗口移动操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackFrame_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgIsDown)
            {
                return;
            }
            this.DragMove();
            CPoint = e.GetPosition(BackFrame);
        }

        #endregion

        #region 关闭窗口，保存图片
        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="obj"></param>
        private void DoClose(string obj)
        {
            this.Close();
        }

        /// <summary>
        /// 右上角关闭操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borderClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 右键菜单关闭操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quite_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 保存图片操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = DateTime.Now.ToString("yyyy-MM-dd hhmmss");
            sf.Filter = "*.png|*.png";
            if (sf.ShowDialog() == true)
            {
                BitmapSource BS = (BitmapSource)IMG1.Source;
                PngBitmapEncoder PBE = new PngBitmapEncoder();
                PBE.Frames.Add(BitmapFrame.Create(BS));
                using (Stream stream = File.Create(sf.FileName))
                {
                    PBE.Save(stream);
                }
            }
        }
        #endregion
    }
}
