   M S B A M L   `   `   `  ����>  :yk1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:yk1yk1  5   	       yk1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:yk1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��17* �6   �� 5      $	��14* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid��5         CanUserAddRows .  $��	5,14,5,21q�6<   6O   �� 5   
   -   5        $
��btn1��5      $!��вторая таблица��6   $
��Left=�66   $��52��6Q   $��608,124,0,0q�6]   $	��Top=�6r   $	��144��6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ dobavl��5      $��добавить��6!   $
��Left=�64   $��
72,124,0,0q�6O   $��1��6c   $	��Top=�6p   $��52��6�   $	��130��6�   6�   �� 5   
   -   5        $	��del��5      $��удалить��6   $
��Left=�6.   $��238,124,0,0q�6I   $��1��6^   $	��Top=�6k   $��52��6�   $	��130��6�   6�   �� 5   
   -   5         ��Name$ surname��5      $
��Left=�6#   $��
278,10,0,0q�6>   $��1��6R    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��181��6�   $��25��6�   �� 5   
   -   5        $
 name��5      $
��Left=�6    $��	60,10,0,0q�6;   $��1��6N   $
 Wrap=�6[   $	��Top=�6o   $	��182��6�   $��25��6�   �� 5   
   -   5        $
 last��5      $
��Left=�6    $��
499,10,0,0q�6;   $��1��6O   $
 Wrap=�6\   $	��Top=�6p   $	��181��6�   $��25��6�   �� 5   
   -   5        $ update��5      $��изменить��6!   $
��Left=�64   $��52��6O   $��400,124,0,0q�6[   $��1��6p   $	��Top=�6}   $	��124��6�   6�   5      5      