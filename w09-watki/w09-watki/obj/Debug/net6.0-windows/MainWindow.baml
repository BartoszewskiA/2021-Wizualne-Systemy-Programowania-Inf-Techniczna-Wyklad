   M S B A M L   `   `   `  ����D  @w09-watki, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:w09_watki	w09_watki  5   	       w09_watki.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:w09_watki     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��10,10,10,10q�6    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ 	textBox01��5      $
��10,5q�6%    �� AcceptsReturn$
 True��64    �� TextWrapping$
 Wrap=�6I   " �� VerticalScrollBarVisibility$
 Auto=�6]   �� 5   
   -   5        $ 	textBox02��5      $��1��6%   � 5   
   -   5         �Name$ progressBar01��5      $��2��6.   $��25��6<   $
��Auto��6H    � Value$ 0Q�6U   �� 5   
   -   5        $��3��5      .��64   START6;   �� 5   
   -   5        $��4��5      .��65   Stop6;   5      5      