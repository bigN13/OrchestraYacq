   M S B A M L   `   `   `  ����J  FMahApps.Metro, Version=0.0.0.999, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    OrchestraYacq   OrchestraYacq.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Yacq Exploration��5   	   $	��600��6"   $	��800��6/   (   "MahApps.Metro.Controls.MetroWindow   	GlowBrush 5      �� 5   
      AccentColor �� Color# �   6    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $H Bpack://application:,,,/MahApps.Metro;component/Styles/Colours.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5         WindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� $��settings��6   5      .��5      � .+�5   
   �� .@�5      �� $��Datagrid��6   .��5      �  � ColumnDefinitions 5      �� 5       �� 5!      $
��Auto �6+    � RowDefinitions 5#      �� 5$      $
��Auto �6(   �� 5%      .+�5'      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dgr_Persons��5'      
   AutoGenerateColumns
 .  $��Stretch=�5(      $��5q�6=   $��1��6H   $��2��6U   $��Stretch=�6j      Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
PersonId+  5+      $ 
First Name��61    6E   �� *	FirstName+  5,      $ 	Last Name��61    6D   �� *
LastName+  5-      $ Date Of Birth��61    6H   �� *DateOfBirth+  5.      $	 Age��61    6>   �� *Age+  5/      $	 Sex��61    6>   �� *Sex+  50      $ Phone Number��61    6G   �� *PhoneNumber+52      �� 53      -   5         ��Name$ txt_Expression��53      $��Stretch=�66   $��23��6T   $��5q�6`    �� TextWrapping$
 Wrap=�6k   $�� ��6   $��Stretch=�6�   *   $MahApps.Metro.Controls.TextboxHelper   	Watermark$# Put your expression here.....��54       � ToolTip$  Write your Yacq expression��55   &   �� 56      -   5        $��Apply��56      $��1��6-   $��Right=�6=   $��5q�6Y   $��Stretch=�6d   $��75��6�   6�   58      59      �� 5:      $��Yacq Parser��6   .��5;      �  5<      �� 5=      $	��90* �6+   �� 5>      $
��257* �6+   �� 5?      $
��170* �6+    5A      �� 5B      $
��Auto �6(   �� 5C      $
��Auto �6(   �� 5D      $
��Auto �6(   �� 5E      $
��Auto �6(   �� 5F      .+�5H      �� -   5        $��	Calculate��5H      $
��Left=�61   $��5,5,0,0q�6L   $	��Top=�6]   $��75��6u   $��25��6�   �� 5I      -   5        $ txt_Evaluate1��5I      $��Stretch=�65   $��5q�6S   $��1��6^   $
 Wrap=�6k   $��Yacq.net��6   $��Stretch=�6�   $��2��6�   {�.  6�   �� 5J      -   5        $ 	txt_expr1��5J      $��Stretch=�61   $��5q�6O   $
 Wrap=�6Z   $��	(+ 1 2 3)��6n   $��Stretch=�6   $��1��6�   $��2��6�   �� 5K      -   5        $ txt_Result1��5K      $��Stretch=�63   $��5q�6Q   $��1��6\   $
 Wrap=�6i   $
��....��6}   $��Stretch=�6�   $��2��6�   {�.  $
��Bold"�6�   $��14(�6�   �� 5N      -   5         ��Name$ btn_2��5N      $��	Calculate��6,   $
��Left=�6@   $��5,5,0,0q�6[   $	��Top=�6l   $��75��6�   $��2��6�   $��25��6�   �� 5O      -	   5        $ 	txt_expr2��5O      $��Stretch=�61   $��26��6O   $��5,5,5,0q�6[   $
 Wrap=�6l   $(��"it.(ToUpper).(Replace 'FOO' 'bar')��6�   $	��Top=�6�   $��2��6�   $��1��6�   $��2��6�   �� 5P      -
   5        $ txt_Evaluate2��5P      $��Stretch=�66   $��5q�6T   $��3��6_   $
 Wrap=�6l   $��Yacq.net��6�   $��Stretch=�6�   $��2��6�   {�.  6�   �� 5Q      -   5        $ txt_Result2��5Q      $��Stretch=�63   $��5q�6Q   $��3��6\   $
 Wrap=�6i   $
��....��6}   $��Stretch=�6�   $��2��6�   {�.  $��14(�6�   $
��Bold"�6�   5S      5T      5U      5W      5X      