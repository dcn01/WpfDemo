   M S B A M L   `   `   `  ����F  BViewPicture, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ViewPictureViewPicture  5   	       ViewPicture.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ViewPicture     5   	   -   5          �Name$	  win��5   3   
������  � Topmost .   � AllowsTransparency .  � Title$ 
MainWindow��5   	   $	��411��6   $	��611��6,    � WindowStartupLocation$ CenterScreen=�6_    � ShowInTaskbar .  � SizeToContent$ WidthAndHeight=�6�    � 
ResizeMode$ NoResize=�6�    � Cursor$
 Hand��6�   	 J� IsHitTestVisible	 . 
 � WindowStyle$

 None=�6�    � 	Resources 5	       �� 
TargetType �� Property �� Value   ShowProgress �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%u  '��       &	  Z     �� 5
   
   " ��6   .�5      ��  �@J�SnapsToDevicePixels . 64   5      �� 5   
   -   5        .��5      U� $ gridProgress��6,   $ (UIElement.Opacity)�6Q   .\�5        $ 00:00:0��6'   $ 1Q�69     5      $ 	00:00:0.4��6'   $ 1Q�6;     5      $ 	00:00:0.8��6'   $ 0Q�6;   5      5      5       � ContextMenu 5      �� 5   
   .@�5      m� -   5         m�Name$
 Open��5      $��打开图片��6%   63   m� 5      -   5        $
 Save��5      $��保存图片��6%   63   m� 5      -   5        $ Quite��5      $��退出浏览��6&   64   5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      
BlurRadius$ 10Q�6      ShadowDepth$ 0Q�6+      Opacity$
 0.75Q�6;   .��5      � -   5         �Name$	 IMG��5      $
 Hand��6   $��Stretch=�6&   $��Stretch=�6B    5    
     	Imageview��%@   &	       V� 5!      .~�5"      �� T� 5#      5$      5%       J� InputBindings 5&   
   d� 5'       d� MouseAction$ LeftDoubleClicke�6C    �� Command 6   �� *DoubleClickCloseCmd+6C   .+�5)   
   �� -   5         ��Name$ 	borderWin��5)       �� CornerRadius$ 3��6%   ���	#4C000000$��5q�6M   ._�5*      �� -   5         ��Name$ 	BackFrame��5,   o   $��Stretch=�5+      $��Stretch=�67   $��Disabled=�6U   $��Disabled=�5,      $
 Hand��6O   |�.  .��5-      �� -	   5        .��50      �� -
   5        $
��IMG1��50      $��Images/img.png��6)   #z�[ 6A   $
��None=�6n   6�   51      52      53      � 54   
   -   5        $ gridProgress��54      |�.  $y�	Collapsed=�67   $��Center=�6N   $��Center=�6i   z�55      V� 56      58      .+�5:      �� |�.  $ 5��6'   $	��100��68   $��37��6D   ���	#7F0F0F0F 5;        5<      $ 3Q�6'   $ 0Q�66       Color$  	#199C9C9C��6F   5?      �� 5@      -   5        ! ��Name$! txtProgress��5@      $
��100%��6-   
�������" �� TextAlignment$" Center=�6L   $��Center=�6c   5A      �� 5C   
   -   5        # ��Name$# borderClose��5C      $ � ToolTip$$ 关闭浏览��6&   $��	0 15 10 0q�5D      $��Right=�6$   $	��Top=�6@   ��5E      �� 5F      " ��6   .�5G      ��  � �� �#393a3c63   �� 5H       � �� 5I      �� 5J      .R�5K   "   �� #��z��6)   $ 70��6S   $��35��6e   $��35��6q   ._�5L   &   �� $	! txt��60   $��×��6=   $
��Bold"�6F   
�������$��30(�6l   $��Center=�6z   $��Center=�6�   $��0 -2 0 0q�6�   5M   #   % �� Triggers% 5N   "   P� 5O   &   & P� Property& �@J�IsMouseOver' P� Value' . . �5P   *   ��  � �� �#d43f276G   5Q   '   P� 5R   &   & � ��' . . �5S   *   �� ( �� 
TargetName$	( txt��6S    � ��$ 1 0 0 0q�6C   6S   5T   '   5V      5X      5Y      5\      5_      5`      