   M S B A M L   `   `   `  ����E  AHelloWorld, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:HelloWorld
HelloWorld  5   	       HelloWorld.ControlWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:HelloWorld     5   	     � Title$  ControlWindow��5   	   $	��450��6   $	��800��6,   ��5	      �� 5
   
    �� ImageSource$ /Images/wpf-menus-new.png��6   .��5      �� .+�5   
   �� -   5         ��Name$ uxLocal��5      $��Local��6$   5      �� 5   
   �� 5      -   5         ��Name$ uxNavigator��5      $��http://www.google.com?�6%   .�5   A   
Google.com6M    �� 5      -   5        $��http://www.microsoft.com?�5      .�5   ?   Microsoft.com6N   5      �� 5   
   $��5q�6   
�������
����  �._�5      �� .+�5   
   	� $��Option 1��6    	� 	GroupName$	 one��6)    � ToolTip$ Click me also��69   6S   	� 5   
   $��Option 2��6   $	 one��6)   6;   5      5      	� 5   
   $��Option A��6   $	 two��6)   6;   	� 5   
   $��Option B��6   $	 two��6)   6;   �� 5    
   -   5         ��Name$ uxSlider��5        � Minimum$ 0Q�5!       � Maximum$	 100Q�6   	 �� TickPlacement$	 BottomRight=�6&   
 �� TickFrequency$
 5Q�6B   � 5#   
   -   5         �Name$ uxProgressBar��5#      $��16��6-   6;   �� 5%   
   .��5&      �� Enable feature �� 5'      
���  ��$
��Bold"�6.   .�6@   Red6F    �� 5(   
   
��� � �$
��Bold"�6!   .�63   Green6;    �� 5)   
   
����  �$
��Bold"�6    .�62   Blue68   5*      5+      5,      5-      