   M S B A M L   `   `   `  ����F  BDsoMusicWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DsoMusicWPFDsoMusicWPF  5   	       DsoMusicWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DsoMusicWPF     5   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1000��6)    � WindowStyle$
 None=�66    � AllowsTransparency$
 True��6J    � 
ResizeMode$ NoResize=�6d    � 	Resources 5	         style_default �� 
TargetType �� Property �� Value �� Triggers	 P� Property
 P� Value��%�   &	        �� 5
   
   " ��6&   .�5      ��  � ��$ 20(�6)    5      P� 5      	 �@J�IsMouseOver$

 True��61   . �5      ��  � ��
 �����63   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      $��80 �6   .+�5   
   � -   5        $��TitleBar��5      $��0��6>   ���	#FFFF4141.+�5      �� $��Dso Music WPF��6   $��Center=�6-   $��20 0 0 0q�6H   $��14(�6Z   ���#DDDDDD6h   �� 5      -   5        $��SearchTextBox��5      $��32��6+   $	��300��67   �� 5      -   5        $��SearchButton��5      $��50��6D   $��Right=�6O   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5       $	��200 �6#   �� 5!      .+�5#      � $��0��6   .+�5$      �� .+�5%      �� -   5         ��Name$ HomePageButton��5%      $��主页��65   6B   5'      5(      � 5)      $��1��6   .+�5*       � -   5          �Name$ 	MainFrame��5*      5,      5-      5/      � 51   
   $��2��6   
������� 52      �� 53      $	��200 �6#   �� 54      �� 55      $	��200 �6#   .+�57      � $��0��6   .+�58      �� -   5        $��SongNameTextBloack��58      $��音乐��66   $��10q�6@   $��14(�6L   59      � 5:      $��1��6   .+�5;      �� -   5        $ ButtonPlayOrPause��5;      64   5<      r� 5>      -   5        $��mediaElement��5>      5?      5A      5B      