   M S B A M L   `   `   `  ����D  @Test_Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Test_Demo	Test_Demo  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6/   #    Test_Demo.ListProductAuthUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Test_Demo     5   	   6sys&clr-namespace:System;assembly=mscorlib     6/     � Title$  ListProductAuthUser��5   	   $	��600��6%   $
��1000��62    � 	Resources 5	         NullImg��%R   &	        ��5
   
   0,pack://application:,,,/Resources/picture.png��5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      $��1* �6   6*   �� 5      $	��10* �6   6+   .+�5   
   � $��0��6   .+�5      �� ���	#FF3EFF046+   �� 5      $��
Выход��6   $
��Left=�6%   $��	910,4,0,0q�6@   $	��Top=�6S   $��70��6k   ���	#FF498C53
�������$��Comic Sans MS)�6�   $��24��6�   �� 5      $
��Left=�6   $��82��6/   $��Bottom=�6;   $��83��6V   $��10,0,0,4q�6b   $��/Resources/logo.png��6t   �� 5      $��ООО «Ткани»��6   $
��Left=�6*   $��	120,9,0,0q�6E   $	��Top=�6X   $��Center=�6p   $��Center=�6�   $��Comic Sans MS)�6�   $
��Bold"�6�   $��14(�6�   �� 5      $!��Список товаров��6   $
��Left=�6-   $��
120,44,0,0q�6H   $	��Top=�6\    J� RenderTransformOrigin$ 0,0.194&�6t   $��Comic Sans MS)�6�   $��18(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5      $��Вы вошли как:��6   $
��Left=�6,   $��
721,45,0,0q�6G   $	��Top=�6[   $��Comic Sans MS)�6s   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5      $��ФИО��6   $
��Left=�6"   $��
820,45,0,0q�6=   $	��Top=�6Q   $��Comic Sans MS)�6i   5      �� 5   
   -   5         ��Name$ ListProducts��5       $��2��6   $��Center=�66   ��. ��5      �� 5       .R�5!      �� 5#      5$      ��5&      �� 5'      .R�5(      �� $��1q�6   
���   �._�5)      � $	��300��6   $	��200��6+    � ColumnDefinitions 5*      �� 5+   "   $
��1.5* �63   6B   �� 5,   "   $
��1.5* �63   6B   �� 5-   "   $��3* �63   6@   �� 5.   "   $
��1.5* �63   6B   .+�50      �� $��0��6$   ��64   �� *	ImgPath+ �� FallbackValue# [  6y   A� 51      53      54      56      57      59      5:      5;      