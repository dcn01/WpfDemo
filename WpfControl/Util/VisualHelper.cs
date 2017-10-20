using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace WpfControl.Util
{
    public class VisualHelper
    {
        public static T FindVisualParent<T>(DependencyObject obj) where T : class
        {
            while (obj != null)
            {
                if (obj is T)
                    return obj as T;

                obj = VisualTreeHelper.GetParent(obj);
            }

            return null;
        }

        /// <summary>
        /// 获取顶级视觉树
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DependencyObject FindVisualTop(DependencyObject obj)
        {
            while (obj != null)
            {
                if (VisualTreeHelper.GetParent(obj) == null)
                {
                    return obj;
                }
                else
                {
                    obj = VisualTreeHelper.GetParent(obj);
                }
            }
            return null;
        }

        /// <summary>
        /// 判断依赖对象的 框架节点的父级是否为Popup
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsPopup(DependencyObject obj)
        {
            DependencyObject dep = FindVisualTop(obj);
            if ((dep as FrameworkElement).Parent is Popup)
            {
                return true;
            }
            return false;
        }


        /// <summary>  
        /// 获取父可视对象中第一个指定类型的子可视对象  
        /// </summary>  
        /// <typeparam name="T">可视对象类型</typeparam>  
        /// <param name="parent">父可视对象</param>  
        /// <returns>第一个指定类型的子可视对象</returns>  
        public static T GetVisualChild<T>(Visual parent) where T : Visual
        {
            T child = default(T);
            int numVisuals = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < numVisuals; i++)
            {
                Visual v = (Visual)VisualTreeHelper.GetChild(parent, i);
                child = v as T;
                if (child == null)
                {
                    child = GetVisualChild<T>(v);
                }
                if (child != null)
                {
                    break;
                }
            }
            return child;
        }

    }
}
