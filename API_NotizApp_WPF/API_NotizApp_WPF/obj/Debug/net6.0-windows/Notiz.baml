   M S B A M L   `   `   `  ����K  GAPI_NotizApp_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:API_NotizApp_WPFAPI_NotizApp_WPF  5          API_NotizApp_WPF.Notiz   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:API_NotizApp_WPF     5      ���	#FF5A5A5A.��5	      �   � ColumnDefinitions  5
   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��45 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���	#FF464646.+�5      �� -   5        $��
backButton��5      $
��Back��6'   ���	#FFD5D5D5$
��Left=�6M   $��	230,0,0,0q�6h   $��Center=�6{   $��50��6�   ���	#FF5A5A5A J� RenderTransformOrigin$ 0.5,0.5&�6�   $��25��6�   ��6�   Z� 6�   �� 5      -   5        $��Delete��5      ���	#FFD5D5D5$
��Left=�6=   $��	290,0,0,0q�6X   $��Center=�6k   $��75��6�   ���	#FF5A5A5A$ 0.5,0.5&�6�   $��25��6�   ��6�   Z� 6�   �� 5      -   5        $��titleBox��5      $
��Left=�6&   $��10,0,0,0q�6A    �� TextWrapping$
 Wrap=�6S   $��Center=�6g   $	��210��6�   $��25��6�   $��14(�6�   
����������	#FF5A5A5A �� 	MaxLength$ 15��6!   �� SelectionBrush 6�   Z�  �� SelectionTextBrush 6�   Z� ��6�   Z� 6!  5      �� 5   
   -   5        $��	inhaltBox��5      $��1��6#   
������ $��10q�6I   $��14(�6V   
�������$��0,1,0,0q�6�   $
 Wrap=�6�    �� AcceptsReturn$
 True��6�   " �� VerticalScrollBarVisibility$
 Auto=�6	   6w   Z�  6�   Z� ��6�   Z� 6.  5      5      