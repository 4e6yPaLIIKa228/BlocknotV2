   M S B A M L   `   `   `  ����C  ?Samostoi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SamostoiSamostoi  5          Samostoi.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      (localclr-namespace:Samostoi     5        �� 	Resources  5         MenuItemControlTemplate1 �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value  MenuItemControlTemplate2
 �Name � ColumnDefinitions z� SharedSizeGroup ��Name m� Icon F�Name �� HeaderStringFormat �� ContentStringFormat ��Name J� Opacity m� InputGestureText �Name � AllowsTransparency � HorizontalOffset � VerticalOffset �� RelativeSource �� Padding ��Name �� 
ResourceId �� TypeInTargetAssembly �� ClearTypeHint ��Name  ��Name! �� ElementName" ��Name-  'System.Windows.Input.KeyboardNavigation#   DirectionalNavigation$ � IsSharedSizeScope%   TabNavigation& P� 
SourceName  
GridStyle1' �� 
TargetType  MenuItemControlTemplate3��%�  &	        &	 ?    &	 �    &	 �    �� 5   
   " m�6;   .R�5	      �� $ templateRoot��6   #��z��6+   #��z��6W   #��z��6�    . 6�    5
      P� 5      " �@m�IsSuspendingPopupAnimation . 6@   P� 5       6*   Z�  �@m�IconP� 5       �@m�	IsChecked . 6/   P� 5       �@m�IsHighlighted . . �5      �� $ templateRoot��63    � ��
	 ���� 6M   �� 5      $ templateRoot��64    � ��	 �	#FF26A0DA6N   5      P� 5       � {� .  . �5      �� $ templateRoot��6?    � ��	 �	#FF7070706Y   5      5      �� 5   
   " m�6;   .R�5      �� $ templateRoot��6   #��z��6+   #��z��6W   #��z��6�    . ._�5      � $

 Grid��6   $��-1q�6%    5      �� 5      $��22��6+   $ MenuItemIconColumnGroup��69   $
��Auto �6c   �� 5      $��13 �6+   �� 5      $��* �6+   �� 5      $��30 �6+   �� 5      $ MenuItemIGTColumnGroup��6+   $
��Auto �6T   �� 5       $��20 �6+   .+�5"      �� $
 Icon��6'   #��z 65   $
��Icon��6V   $��Center=�6k   $��16��6�   $��3q�6�   # z 6�   $��Center=�6�   $��16��6�   �� 5#      $ 
GlyphPanel��6   ���	#FF26A0DA$��1q�6I   ���	#3D26A0DA$��22��6t   $��-1,0,0,0q�6�   $y�Hidden=�6�   $��Center=�6�   $��22��6�   ._�5$      F� $ Glyph��6   T������� �O �`�G �ڊ � �D �ڊ �    �XO � � �g5 ���A  ] ������� @    р�� �O ���	#FF212121$��LeftToRight=�6�   $��11��6�   $��9��6�   5%      �� 5&      $ ContentPresenter��6'   #��z��6A   #��z��6t   $��2��6�   # z 6�   $��Header��6�   $
��Left=�6�   #��z��6  ��. # z 6R  $��Center=�6�  �� 5'      $ 	TextBlock��6    $��4��63   #��z��6C   $	 0.7Q�6f   #��z 6t   $��Center=�6�   F� 5(      $ 
RightArrow��6   $��5��6/   "����        � 	= �g5 �    ��j 	���	#FF212121$
��Left=�6g   $��10,0,0,0q�6�   $��Center=�6�   � 5)      $ 
PART_Popup��6    . |�.  $ -2��6\   #��� -�6�   $��Right=�6  $ -3��6+  ��6r   �� *IsSubmenuOpen+ �� *TemplatedParent+.��5*      �� $ SubMenuBorder��6!   ���	#FF999999$��1q�6P   ���	#FFF0F0F0$ 2q�6{   ._�5+      �� $ SubMenuScrollViewer��6+   ��6H   C� *�� $ MenuScrollViewer��" �+.��5,   "   � $
 Grid1��6'   $ Enabled=�66   .+�5-   &   �� $ Canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5.   *   �� $  
OpaqueRect��64   ��6H   �� *
Background+$! SubMenuBorder����6   �� *ActualHeight+$! SubMenuBorder����6�   �� *ActualWidth+$! SubMenuBorder��5/   '   �� 50   &   $  	Rectangle��60   #��� ��6C   $
��Left=�6�   $��29,2,0,2q�6�   $��1��6�   �� 51   &   $" ItemsPresenter��65   $# Cycle=�6M   $ . # z 6�   $% Cycle=�6�   52   #   53      54      55      56      57       58      P� 59      " �@m�IsSuspendingPopupAnimation . . �5:      �� $ 
PART_Popup��67    � ��$
	 None=�6O   5;      P� 5<       6*   Z�  �@m�Icon. �5=      �� $
 Icon��63    � y�$	 	Collapsed=�6E   5>      P� 5@       �@m�	IsChecked . . �5A      �� $ 
GlyphPanel��63    � y�$	 Visible=�6K   �� 5B      $
 Icon��63    � y�$	 	Collapsed=�6E   5C      P� 5D       �@m�IsHighlighted . . �5E      �� $ templateRoot��63    � ��
	 ���� 6M   �� 5F      $ templateRoot��64    � ��	 �	#FF26A0DA6N   5G      P� 5H       � {� .  . �5I      �� $ templateRoot��6?    � ��	 �	#FF7070706Y   �� 5J      $ Glyph��6-    � ��	 �	#FF7070706@   �� 5K      $ 
RightArrow��6-    � ��	 �	#FF7070706E   5L      P� 5M      $& SubMenuScrollViewer��66    � �� .  . �5N      �� $ 
OpaqueRect��63   	 6K   �� *VerticalOffset+$! SubMenuScrollViewer�� �@��Top�� 5O      $ 
OpaqueRect��64   	 6L   �� *HorizontalOffset+$! SubMenuScrollViewer�� �@��Left5P      5R      �� 5S   
   "' �6#   �� 5T   
   " m�6;   .R�5U      �� $ templateRoot��6   #��z��6+   #��z��6W   #��z��6�    . ._�5V      � $

 Grid��6   $��Center=�6%    5W      �� 5X      $
��Auto �6+   �� 5Y      $
��Auto �6+   .+�5[      �� $
 Icon��6'   #��z 65   $
��Icon��6V   $��Center=�6k   $��16��6�   $��3q�6�   # z 6�   $��Center=�6�   $��16��6�   F� 5\      $ 
GlyphPanel��6   T������� �O �`�G �ڊ � �D �ڊ �    �XO � � �g5 ���A  ] ������� @    р�� �O #��z��6t   $��LeftToRight=�6�   $��3q�6�   $y�	Collapsed=�6�   $��Center=�6�   �� 5]      $ ContentPresenter��6'   #��z��6A   #��z��6t   $��1��6�   # z 6�   $��Header��6�   #��z��6�   ��. # z 67  � 5^      $ 
PART_Popup��6    . |�.  #��� -�6�   $��Bottom=�6  ��6\   �� *IsSubmenuOpen+ �� *TemplatedParent+.��5_      �� $ SubMenuBorder��6!   ���	#FF999999$��1q�6P   ���	#FFF0F0F0$ 2q�6{   ._�5`      �� $ SubMenuScrollViewer��6+   ��6H   C� *�� $ MenuScrollViewer��" �+.��5a   "   � $
 Grid1��6'   $ Enabled=�66   .+�5b   &   �� $ Canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5c   *   �� $  
OpaqueRect��64   ��6H   �� *
Background+$! SubMenuBorder����6   �� *ActualHeight+$! SubMenuBorder����6�   �� *ActualWidth+$! SubMenuBorder��5d   '   �� 5e   &   $  	Rectangle��60   ���	#FFD7D7D7$
��Left=�6T   $��29,2,0,2q�6o   $��1��6�   �� 5f   &   $" ItemsPresenter��65   $# Cycle=�6M   $ . # z 6�   $% Cycle=�6�   5g   #   5h      5i      5j      5k      5l       5m      P� 5n      " �@m�IsSuspendingPopupAnimation . . �5o      �� $ 
PART_Popup��67    � ��$
	 None=�6O   5p      P� 5q       6*   Z�  �@m�Icon. �5r      �� $
 Icon��63    � y�$	 	Collapsed=�6E   5s      P� 5t       �@m�	IsChecked . . �5u      �� $ 
GlyphPanel��63    � y�$	 Visible=�6K   �� 5v      $
 Icon��63    � y�$	 	Collapsed=�6E   5w      P� 5x       �@m�IsHighlighted . . �5y      �� $ templateRoot��63    � ��	 �	#3D26A0DA6M   �� 5z      $ templateRoot��64    � ��	 �	#FF26A0DA6N   5{      P� 5|       � {� .  . �5}      �� $ templateRoot��6?    � ��	 �	#FF7070706Y   �� 5~      $ 
GlyphPanel��6-    � ��	 �	#FF7070706E   5      P� 5�      $& SubMenuScrollViewer��66    � �� .  . �5�      �� $ 
OpaqueRect��63   	 6K   �� *VerticalOffset+$! SubMenuScrollViewer�� �@��Top�� 5�      $ 
OpaqueRect��64   	 6L   �� *HorizontalOffset+$! SubMenuScrollViewer�� �@��Left5�      5�      5�      5�      