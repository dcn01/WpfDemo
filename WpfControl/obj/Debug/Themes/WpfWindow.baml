   M S B A M L   `   `   `  ����E  AWpfControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfControl.ControlsWpfControl.Controls  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089#    WpfControl.Controls.WpfWindow  �� 
TargetType �� Property �� Value&   System.Windows.Media.TextOptions �� 
TargetType    CornerRadius �� CornerRadius �� EndPoint �� 
StartPoint � Color	 � Offset
 J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   
BlurRadius   Color   Opacity ��Name ��Name    TitleBarCornerRadius ]�Name ��Name �� RelativeSource ��Name � Title J� Opacity �� Padding �� Orientation&    WpfControl.Controls.WindowButton  Name � ToolTip   IsClose%   WpfControl.Controls.ImageButton   Icon �� Triggers P� Property  P� Value! �� 
TargetName" ]� 
Conditions# �� Property$ �� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .Controls!clr-namespace:WpfControl.Controls  5      %�  '         �� 5      "    6   .�5   
   ��  � ��$ 50��6&   �� 5   
    � ��$ 50��6%   �� 5   
    �@�AllowsTransparency . 6/   �� 5	   
    � ��
 ���� 6'   �� 5
   
    �@�WindowStyle$
 None=�6(   �� 5   
    �@J�SnapsToDevicePixels . 60   �� 5   
    �@ TextFormattingMode$ Display=�6;   �� 5   
    �@ TextRenderingMode$ 	ClearType=�6:   �� 5   
    �@��BitmapScalingMode$ HighQuality=�6<   �� 5   
    �@�UseLayoutRounding . 6.   �� 5   
    �@  
TitleColor$ White��6'   �� 5   
    �@  BackgroundColor$ #21262E��6,   �� 5   
    � �� 5      �� 5      "   6#   .R�5      �� $��5q�6   # z 6(   #��z��6Y   #��z��6�   ��5      �� 5      $ 0.5,1&�62   $ 0.5,0&�6C   .��5   "   � $ 	#FF1DC1A5��6/   $	 0Q�6A   � 5   "   $ 	#FF20B4A6��6/   $		 0.5Q�6A   � 5   "   $ 	#FF23AAA7��6/   $	 0.736Q�6A   � 5   "   $ 	#FF24A6A8��6/   $	 1Q�6A   5      
 5        5      $ 1Q�6/   $ 5Q�6?   $ Black��6N   $
 0.75Q�6\   ._�5!      � .+�5"      �� $ _content��61   �� 5#      $ 	borderTop��6I   $��25��6%   $	��Top=�61   # z 6]   ._�5$   "   ]� $ _dockbar��6,   $��Center=�6>   ��.  .+�5%   &   �� $ _icon��6B   $
��Left=�6,   $��5 0 0 0q�6Q   $��Center=�6b   $��Uniform=�6}   $��16��6�   $A��;pack://application:,,,/BoxControl;component/Images/logo.png��6�   y�6�   �� *
ShowIcon+ �� *TemplatedParent+�� 5&   &   $ _title��60   $��5 0 0 0q�6@   $
��Left=�6�   $��Center=�6�   #��z 6�   ��6S   �� *
TitleColor+ �� *TemplatedParent+y�6�   �� *	ShowTitle+ �� *TemplatedParent+�� 5'   &   $ 	borderbtn��6-   $��Right=�6B   $	��Top=�6Y   $��53��6q   $��25��6�   $��0 0 0 0q�6�   ._�5(   *   � .+�5)   .   �� 
�������$	 0.1Q�6H   $ 	 0 0 0 30��6W   �� 5*   .   $ 25 0 5 0q�69   ._�5+   2   �� $��RightToLeft=�6=   $��Center=�6Y   $ 
Horizontal=�6v   .+�5,   6     $ 	_btnclose��6L   $ 关闭��6`   $��Right=�6m    . 
���  ��$B <pack://application:,,,/WpfControl;component/Images/close.png��6�   y�6�   �� *ShowCloseButton+ �� *TemplatedParent+6�     5-   6   $ _btnmax��6L   $ 	最大化��6]   $��Right=�6k   $@ :pack://application:,,,/WpfControl;component/Images/max.png��6�   y�6�   �� *ShowMaxButton+ �� *TemplatedParent+6�     5.   6   $ 
_btnnormal��6L   $ 还原��6`   $��Right=�6m   $B <pack://application:,,,/WpfControl;component/Images/max-x.png��6�   y�6�   �� *ShowNormalButton+ �� *TemplatedParent+6�     5/   6   $ _btnmin��6L   $ 	最小化��6]   $��Right=�6k   
���  ��$@ :pack://application:,,,/WpfControl;component/Images/min.png��6�   y�6�   �� *ShowMinButton+ �� *TemplatedParent+6�     50   6   $ _btnset��6L   $ 设置��6^   $��Right=�6k   
���  ��$@ :pack://application:,,,/WpfControl;component/Images/set.png��6�   y�6�   �� *ShowConfigButton+ �� *TemplatedParent+6�   51   3   52   /   53   +   54   '   55   #   56      58      59       5:      P� 5;       �@  TitleBarPlaceHolder  . . �5<      �� $! _content��6%    � ��$ 0 25 0 0q�6M   �� 5=      $! 	borderTop��6%    6R   �� *TitleBarBackground+ �� *TemplatedParent+ � ��5>      P� 5?       �@  ShowCloseButton$  Hidden=�6=   . �5@      �� $! 	_btnclose��6%    � y�$ 	Collapsed=�6R   5A      P� 5B       �@  ShowMaxButton$  Hidden=�6;   . �5C      �� $! _btnmax��6%    � y�$ 	Collapsed=�6P   5D      P� 5E       �@  ShowNormalButton$  Hidden=�6>   . �5F      �� $! 
_btnnormal��6%    � y�$ 	Collapsed=�6S   5G      P� 5H       �@  ShowMinButton$  Hidden=�6;   . �5I      �� $! _btnmin��6%    � y�$ 	Collapsed=�6P   5J      P� 5K       �@  ShowConfigButton$  Hidden=�6>   . �5L      �� $! _btnset��6%    � y�$ 	Collapsed=�6P   5M      ]� 5N      " 5O      �� 5P   "   # �@  ShowCloseButton$$ 	Collapsed=�6G   �� 5Q   "   # �@  ShowMaxButton$$ 	Collapsed=�6E   �� 5R   "   # �@  ShowNormalButton$$ 	Collapsed=�6H   �� 5S   "   # �@  ShowMinButton$$ 	Collapsed=�6E   �� 5T   "   # �@  ShowConfigButton$$ 	Collapsed=�6H   ./�5V      �� $! 	borderbtn��6%    � y�$ 	Collapsed=�6R   5W      5Y      5[      5\      5^      