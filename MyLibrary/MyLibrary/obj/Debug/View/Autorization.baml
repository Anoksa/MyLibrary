   M S B A M L   `   `   `  ����D  @MyLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MyLibrary	MyLibrary  5   	       MyLibrary.Autorization   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   #localclr-namespace:MyLibrary  5   	     � Title$  
MainWindow��5
   	   $	��480��6   $	��360��6)   $��Andalus)�65    � WindowStartupLocation$ CenterScreen=�6J   $	��360��5   	   $	��480��6   $	��360��6(   $	��480��67    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��97* �6   �� 5      $
��256* �6    � RowDefinitions 5   
   �� 5      $
��149* �6   �� 5      $
��324* �6   .+�5   
   �� $��Логин:��6   $
��Left=�6!   $��31,56.667,0,0q�6<   $��1��6S   $	��Top=�6`   $��23��6x   $��56��6�   �� 5   
   $��Пароль:��6   $
��Left=�6"   $��31,100.667,0,0q�6=   $��1��6U   $	��Top=�6b   $��27��6z   $��56��6�   �� 5!   
   -   5         "  MaterialDesignRaisedDarkButton#��[  5!   2   $
��Auto��6j   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 25��6y   $��1��6�   $#��34.667,138.667,88.333,146.333q�6�   $��1��6�   ��6   �� *LoginCommand+.��5"      �� $��Вход��6   5#      G� 5%   
   -   5        $��1��5%   A   $
��Left=�6Q   $��24.333,87.667,0,0q�6l   $��1��6�   $	��Top=�6�   $	��153��6�   $��30��6�   �� 5&   
   $��1��6   $
��Left=�6"   $��30��6=   $��24.333,43.667,0,0q�6I   $��1��6d    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $	��153��6�   .��6�   .��5'      ��  �� Path$ Login�6   	 �� UpdateSourceTrigger$	 PropertyChanged=�6#   
 �� ValidatesOnDataErrors
 .  �� ValidationRules 5(      5  /System.Windows.Controls.ExceptionValidationRule  5)      5+      5,      �� 5-   
   -   5        $��1��5-      $
��Left=�6"   $��192.667,10,0,0q�6=   $	��Top=�6U   $��53��6m   $��27��6�   .��5.      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CloseOutline=�6&   $��24��6:   $��23��6E   ���	#FF0069C1$��Center=�6h   $
��Left=�6�   5/      �� 50   
   $��1��6   $
��Left=�6    $	��115��6;   $��34.667,10,0,0q�6H   $	��Top=�6_   $	��126��6w   $ ��Resources\Images\Books.png��6�   �� 53   
   $��Регистрация��69      MaterialDesignOutlinedButton#��[ 6O   $��1��6�   $"��34.667,191.667,88.333,97.333q�6�   $��1��6�   $
��Auto��6�   ��6   �� *RegistrationCommand+6�   55      56      