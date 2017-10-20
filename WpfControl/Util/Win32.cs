using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WpfControl.Util
{
    public class Win32
    {
        static Win32()
        {
            DpiX = 1;
            DpiY = 1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public POINT(Point pt)
            {
                X = Convert.ToInt32(pt.X);
                Y = Convert.ToInt32(pt.Y);
            }
        };

        [DllImport("user32.dll")]
        internal static extern bool ClientToScreen(IntPtr hWnd, ref POINT lpPoint);

        [DllImport("user32.dll")]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        static extern bool SetProcessDPIAware();

        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr ptr);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

        [DllImport("gdi32.dll")]
        public static extern int GetDeviceCaps(
            IntPtr hdc, // handle to DC
            int nIndex // index of capability
        );

        public static double DpiX
        {
            get; set;
        }

        public static double DpiY
        {
            get; set;
        }

        public static void GetDpi()
        {
            try
            {
                SetProcessDPIAware();

                const int LOGPIXELSX = 88;
                const int LOGPIXELSY = 90;

                IntPtr screenDC = GetDC(IntPtr.Zero);
                int dpi_x = GetDeviceCaps(screenDC, /*DeviceCap.*/LOGPIXELSX);
                int dpi_y = GetDeviceCaps(screenDC, /*DeviceCap.*/LOGPIXELSY);
                DpiX = dpi_x / 96.0;
                DpiY = dpi_y / 96.0;
                ReleaseDC(IntPtr.Zero, screenDC);
            }
            catch (Exception) { }
        }
    }
}
