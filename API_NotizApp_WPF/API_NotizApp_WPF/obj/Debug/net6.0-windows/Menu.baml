   M S B A M L   `   `   `  ����K  GAPI_NotizApp_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:API_NotizApp_WPFAPI_NotizApp_WPF  5          API_NotizApp_WPF.Menu   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:API_NotizApp_WPF     5      ���	#FF5A5A5A  � 	Resources  5
         ButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name�� 5   
   %
  &	        �� 5      " ��6)   .�5      ��  � �� �	#FF4646466/   �� 5       � �� �	#FFD5D5D56/   �� 5       � ��$ 16(�6-   �� 5       � ��$ 10, 20 ,10 ,0q�6+   �� 5       � ��$	 150��6+   �� 5       � �� 5      �� 5      " ��6*   .R�5      �� $ 8��6%   ���	#FF464646���	#FF464646$��1q�6e   ._�5   "   �� $ contentPresenter��63   #��z��6M   #��z��6�   #��z��6�   #��z��6�   #��z��6  5      5      5      5      5      .��5#      �  � ShowGridLines$ False��6    � ColumnDefinitions 5$   
   �� 5%      $��* �6   	 � RowDefinitions	 5'   
   �� 5(      $��45 �6   �� 5)      $��* �6   .+�5,   
   � $��0��6   ���	#FF464646.+�5-      �� -   5        $��Add Note��5-      ���	#FFD5D5D5$
��Left=�6T   $��10,0,0,0q�6o   $��Center=�6�   $	��100��6�   ���	#FF5A5A5A
 J� RenderTransformOrigin$
 0.5,0.5&�6�   $��25��6�   ��6�   Z� 6�   5.      �� 50   
   $��1��6   .��51      � -   5         �Name$
 grid��51      $ False��6!   $��0��67   $��1��6G    52      �� 53      �� 54      �� 55      �� 56      �� 57      	 59      �� 5:      �� 5;      �� 5<      �� 5=      �� 5>      5@      5A      5D      5E      