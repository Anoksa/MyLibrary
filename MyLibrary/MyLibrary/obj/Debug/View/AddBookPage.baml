   M S B A M L   `   `   `  ����D  @MyLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyLibrary.ViewMyLibrary.View  5           MyLibrary.View.AddBookPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      (localclr-namespace:MyLibrary.View  5      $	��450��5	      $	��638��6     N� Title$  AddBookPage��5
       N� 
Background
 �����.��5      � .+�5   
   �� $��Сохранить��60   $
��Left=�6D   $��314,386,0,0q�6_   $	��Top=�6t   $	��106��6�   ��6   �� *
AddCommand+6�   �� 5   
   -   5         ��Name$ title��5      $
��Left=�6!   $��23��6<   $��
235,36,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6q   $	��160��6�   .��6�   ��5      �� 5       �� Path$ Title�6    �� UpdateSourceTrigger$ PropertyChanged=�6'    �� ValidatesOnDataErrors .  �� ValidationRules 5      5  /System.Windows.Controls.ExceptionValidationRule  5      5      .��5      5      �� 5   
   -   5        $ author��5      $
��Left=�6"   $��23��6=   $��
235,70,0,0q�6I   $
 Wrap=�6]   $	��Top=�6r   $	��160��6�   .��6�   ��5      �� 5      $ Author�6   $ PropertyChanged=�6(    .  5        5      5      .��5      5      �� 5    
   -   5        $
 year��5       $
��Left=�6    $��23��6;   $��235,112,0,0q�6G   $	��Top=�6^   $��97��6v   .��6�   ��5!      �� 5"      $
 Year�6   $ PropertyChanged=�6&    .  5#        5$      5&      .��5'      5(      �� 5)   
   -   5        $ description��5)      $
��Left=�6'   $	��121��6B   $��235,212,0,0q�6O   $
 Wrap=�6d   $	��Top=�6y   $	��286��6�   .��6�   ��5*      �� 5+      $ Description�6   $ PropertyChanged=�6-    .  5,        5-      5/      .��50      51      �� 52   
   $"��Название книги:��6   $
��Left=�6*   $��	88,35,0,0q�6E   $	��Top=�6X   �� 53   
   $"��Год добавления:��6   $
��Left=�6*   $��
88,118,0,0q�6E   $	��Top=�6Y   �� 54   
   $��Автор:��6   $
��Left=�6!   $��	88,76,0,0q�6<   $	��Top=�6O   �� 55   
   $��Описание:��6   $
��Left=�6$   $��
88,212,0,0q�6?   $	��Top=�6S   �� 56   
   $��Статус книги:��6   $
��Left=�6(   $��
441,95,0,0q�6C   $	��Top=�6W   �� 58   
   -   5        $��	BooksList��58   4   $��30��6E   $	��Top=�6Q   $��235,168,243,0q�6i    �� SelectedIndex 6   �� *Genre+.@�59      �� .��6   Детектив6%   �� 5:      .��6   Романтика6&   �� 5;      .��6   Фантастика6'   �� 5<      .��6   Фэнтези6$   �� 5=      .��6   Приключения6(   �� 5>      .��6   
Драма6"   �� 5?      .��6   
Роман6"   5@      �� 5A   
   -   5        	 ��Name$	 ch��5A   �   $��Прочитано��66   $
��Left=�6J   $��441,127,0,0q�6e   $	��Top=�6z   
 d� 	IsChecked
 6   �� $ Status�6�   5C      5D      