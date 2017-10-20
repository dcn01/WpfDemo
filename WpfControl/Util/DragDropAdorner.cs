using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace WpfControl.Util
{
    public class DragDropAdorner : Adorner
    {


        Win32Drag.POINT tempCursorPoint = new Win32Drag.POINT();
        public DragDropAdorner(UIElement parent)
            : base(parent)
        {
            IsHitTestVisible = false; // Seems Adorner is hit test visible?
            mDraggedElement = parent as FrameworkElement;
            Win32Drag.GetCursorPos(ref tempCursorPoint);
        }


        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (mDraggedElement != null)
            {
                Win32Drag.POINT screenPos = new Win32Drag.POINT();

                if (Win32Drag.GetCursorPos(ref screenPos))
                {
                    tempCursorPoint = screenPos;
                    Point pos = PointFromScreen(new Point(screenPos.X, screenPos.Y));
                    Rect rect = new Rect(pos.X, pos.Y, mDraggedElement.ActualWidth, mDraggedElement.ActualHeight);
                    drawingContext.PushOpacity(0.5);
                    Brush highlight = mDraggedElement.TryFindResource(SystemColors.ControlDarkColorKey) as Brush;
                    if (highlight != null)
                        drawingContext.DrawRectangle(highlight, new Pen(Brushes.Transparent, 0), rect);
                    drawingContext.DrawRectangle(new VisualBrush(mDraggedElement),
                        new Pen(Brushes.Transparent, 0), rect);
                    drawingContext.Pop();
                }
            }
        }

        FrameworkElement mDraggedElement = null;
    }

    public static class Win32Drag
    {
        public struct POINT { public Int32 X; public Int32 Y; }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref POINT point);
    }
}
