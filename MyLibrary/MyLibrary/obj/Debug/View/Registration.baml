   M S B A M L   `   `   `  ����D  @MyLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyLibrary.ViewMyLibrary.View  5   	   !    MyLibrary.View.Registration   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   (localclr-namespace:MyLibrary.View  5   	     � 
ResizeMode$  NoResize=�5	   	    � WindowStyle$
 None=�5
   	    � Title$ Registration��5   	   $	��480��6   $	��360��6+   $	��360��5   
   $	��480��6   $	��360��6)   $	��480��68    � WindowStartupLocation$ CenterScreen=�6H   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��191* �6   �� 5      $	��62* �6    � RowDefinitions 5   
   �� 5      $
��124* �6   �� 5      $
��327* �6   .+�5   
   �� $ ��Resources\Images\Books.png��6   $
��Left=�65   $	��100��6P   $	��Top=�6]   $	��100��6u   $��	25,10,0,0q�6�   $��1��6�   �� 5   
   -   5         ��Name$ 	txt_login��5   �   $��1��6   $
��Left=�6"   $��23��6=   $��	10,44,0,0q�6I   $��1��6\    �� TextWrapping$
 Wrap=�6i   $	��Top=�6~   $	��171��6�   .��6�   .��5      ��  �� Path$ Login�6   	 �� UpdateSourceTrigger$	 PropertyChanged=�6#   
 �� ValidatesOnDataErrors
 .  �� ValidationRules 5      5  /System.Windows.Controls.ExceptionValidationRule  5      5       5!      G� 5"   
   -   5         G�Name$ txt_password��5"   �   $��1��6A   $
��Left=�6Q   $��	10,80,0,0q�6l   $��1��6   $	��Top=�6�   $	��171��6�   $��24��6�   6�   �� 5#   
   -   5        $ txt_UserName��5#   �   $��1��6   $
��Left=�6"   $��23��6=   $��
10,120,0,0q�6I   $��1��6]   $
 Wrap=�6j   $	��Top=�6   $	��171��6�   .��6�   .��5$      �� $ UserName�6   $	 PropertyChanged=�6&   
 .  5%        5&      5(      5)      �� 5*   
   $��Логин:��6   $
��Left=�6!   $��	36,50,0,0q�6<   $��1��6O   $	��Top=�6\   $��24��6t   $��44��6�    � ToolTip 5+      _� 5,      .��6   RPЛогин должен содержать не меньше 4 символов.6H   5.      �� 5/   
   $��Пароль:��6   $
��Left=�6"   $��	36,87,0,0q�6=   $��1��6P   $	��Top=�6]   $��24��6u   $��52��6�   �� 50   
   $��Имя:��6   $
��Left=�6   $��
36,126,0,0q�6:   $��1��6N   $	��Top=�6[   $��24��6s   $��34��6   �� 51   
   -   5        $��1��51      $
��Left=�6"   $��
189,10,0,0q�6=   $	��Top=�6Q   $��54��6i   $��25��6�   $��2��6�   .��52      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CloseOutline=�6&   $��24��6:   $��23��6E   ���	#FF0069C1$��Center=�6h   $
��Left=�6�   53      �� 55   
      MaterialDesignFlatButton#��[  6   $��25,178,38.667,123q�6f   $��1��6�   $
��Auto��6�   $��1��6�   ��6D   �� *SignUpCommand+.��6�   Подтвердить57      5:      5;      