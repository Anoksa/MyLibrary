   M S B A M L   `   `   `  ����D  @MyLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyLibrary.ViewMyLibrary.View  5           MyLibrary.View.AddFilmPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      (localclr-namespace:MyLibrary.View  5      $	��450��5	      $	��638��6     N� Title$  AddPage��5
       N� 
Background
 �����.��5      � .+�5   
   �� $��Сохранить��60   $
��Left=�6D   $��313,372,0,0q�6_   $	��Top=�6t   $	��106��6�   ��6   �� *
AddCommand+6�   �� 5   
   -   5         ��Name$ 	book_name��5      $
��Left=�6%   $��23��6@   $��
235,36,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6u   $	��160��6�   .��6�   ��5      �� 5       �� Path$ Title�6    �� UpdateSourceTrigger$ PropertyChanged=�6'    �� ValidatesOnDataErrors .  �� ValidationRules 5      5  /System.Windows.Controls.ExceptionValidationRule  5      5      .��5      5      �� 5   
   -   5        $
 year��5      $
��Left=�6    $��23��6;   $��
235,89,0,0q�6G   $
 Wrap=�6[   $	��Top=�6p   $��97��6�   .��6�   ��5      �� 5      $
 Year�6   $ PropertyChanged=�6&    .  5        5      5      .��5      5      �� 5    
   -   5        $ description��5       $
��Left=�6'   $	��121��6B   $��235,201,0,0q�6O   $
 Wrap=�6d   $	��Top=�6y   $	��286��6�   .��6�   ��5!      �� 5"      $ Description�6   $ PropertyChanged=�6-    .  5#        5$      5&      .��5'      5(      �� 5)   
   $��Название:��6   $
��Left=�6$   $��	88,35,0,0q�6?   $	��Top=�6R   �� 5*   
   $"��Год добавления:��6   $
��Left=�6*   $��	88,95,0,0q�6E   $	��Top=�6X   �� 5+   
   $��Описание:��6   $
��Left=�6$   $��
88,201,0,0q�6?   $	��Top=�6S   �� 5,   
   $��Статус :��6   $
��Left=�6#   $��485,127,0,0q�6>   $	��Top=�6S   �� 5.   
   -   5        $��	BooksList��5.   4   $��30��6E   $	��Top=�6Q   $��235,147,243,0q�6i    �� SelectedIndex 6   �� *Genre+.@�5/      �� .��6   Детектив6%   �� 50      .��6   Мелодрама6&   �� 51      .��6   Фантастика6'   �� 52      .��6   Фэнтези6$   �� 53      .��6   Приключения6(   �� 54      .��6   Комедия6$   �� 55      .��6   
Ужасы6"   56      �� 57   
   $��Просмотренно��66   $
��Left=�6M   $��485,159,0,0q�6h   $	��Top=�6}   	 d� 	IsChecked	 6   �� $ Status�6}   59      5:      