   M S B A M L   `   `   `  ����D  @MyLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyLibrary.ViewMyLibrary.View  5          MyLibrary.View.Books   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      (localclr-namespace:MyLibrary.View  5        N� Title$  Books��5	       N� 
Background
 �����$	��580��6(      BooksViewModel � DataContext# [  5
      $��1112.333��65   .��5      � .+�5   
   �� -   5         ��Name$ BookList��5      $
��Left=�6�   $	��594��6�   $	��570��6�   $	��Top=�6�   ��6%   �� *Books+ �� Mode$ OneWay=� �� SelectedItem 6P   �� *SelectedBook+$ OneWayToSource=� �� View 5      �� 5      .P�5      �� $��Название��6&    �� DisplayMemberBinding 68   �� *Title+�� 5      $��
Автор��6&    65   �� *Author+�� 5      $��Жанр��6&    64   �� *Genre+�� 5      $!��Год добавления��6&    6>   �� *Year+�� 5      $��Статус��6&    66   �� *Status+5      5      �� 5   
   $��660,133,341,152q�6   .+�5      �� $��50��64   $��30��6?    " MaterialDesignRaisedDarkButton#��[ 6K   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 25��6�   ��6   �� *
AllCommand+.��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$
	 Book=�6*   
 � ToolTip
 5      _� 5      .��6   Все книги6)   5!      �� 5#      $��1��6   $��10,2,9.667,2q�6#   �� 5%      $��50��6;   $��30��6F   #��[ 6R   $ 25��6�   ��6   �� *DetectiveCommand+.��5&        $	 Magnify=�6*   
 5'      _� 5(      .��6   Детектив6(   5*      �� 5+      $��1��6   $��10,2,9.667,2q�6#   �� 5-      $��50��69   $��30��6D   #��[ 6P   $ 25��6�   ��6   �� *RomanticCommand+.��5.        $	 Heart=�6*   
 5/      _� 50      .��6   Романтика6)   52      �� 54      $��1��6   $��10,2,9.667,2q�6#   �� 56      $��50��6:   $��30��6E   #��[ 6Q   $ 25��6�   ��6   �� *FantasticCommand+.��57        $		 Ufo=�6*   
 58      _� 59      .��6   Фантастика6*   5;      �� 5=      $��3��6   $��10,2,9.667,2q�6#   �� 5?      $��50��68   $��30��6C   #��[ 6O   $ 25��6�   ��6   �� *FantasyCommand+.��5@        $	 CrystalBall=�6*   
 5A      _� 5B      .��6   Фэнтези6'   5D      �� 5F      $��1��6   $��10,2,9.667,2q�6#   �� 5H      $��50��6<   $��30��6G   #��[ 6S   $ 25��6�   ��6   �� *AdventureCommand+.��5I        $	 Mountain=�6*   
 5J      _� 5K      .��6   Приключения6+   5M      �� 5O      $��1��6   $��10,2,9.667,2q�6#   �� 5Q      $��50��66   $��30��6A   #��[ 6M   $ 25��6�   ��6   �� *DramaCommand+.��5R        $	 EmoticonCry=�6*   
 5S      _� 5T      .��6   
Драма6%   5V      �� 5X      $��1��6   $��10,2,9.667,2q�6#   �� 5\      $��50��66   $��30��6A   #��[ 6M   $ 25��6�   ��6   �� *RomanCommand+.��5]        $	 People=�6*   
 5^      _� 5_      .��6   
Роман6%   5a      5d      �� 5f   
    , (MaterialDesignFloatingActionAccentButton#��[ 60   $��983,472,73.333,52q�6r   ��6   �� *
AddCommand+.��5g        $		 Add=�6&   $��39��61   $��37��6=   5h      �� 5i   
   $#��Resources/Images/Hermione.jpg��6   $
��Left=�67   $	��123��6R   $��
599,10,0,0q�6_   $	��Top=�6s   $	��120��6�   �� 5k   
    ! MaterialDesignFlatMidBgButton#��[ 5l      $!
 MaterialDesignFlatMidButton��5m      $
��Auto��63   $��641,443,320,106q�6A   ��5k      �� *StatusCommand+.��5m   Z   Изменить статус5o      �� 5q   
     MaterialDesignRaisedButton#��[ 5r      $	��100��5s      $/
 )Resource name: MaterialDesignRaisedButton��5t      $��665,490,347,57q�69   $
��Auto��6Q   ��5q      �� *DeleteCommand+.��5t   _   Удалить5v      �� 5x   
   $
��Left=�6B   $��
776,96,0,0q�6]   $
��Wrap=�6q   $	��Top=�6�   $	��351��6�   $	��295��6�   ��6   �� *GetDescription+$ OneWay=�6�   �� 5y   
   $
��Left=�6   $��32��6.   $��
745,22,0,0q�6:   $	��Top=�6O   $	��215��6g   4  .System.Windows.Automation.AutomationProperties   HelpText$5 /Введите параметр поиска...��6s   .��6�   ��5z      �� 5{       �� Path$ SearchB�6    �� UpdateSourceTrigger$ PropertyChanged=�6*    �� ValidatesOnDataErrors .  �� ValidationRules 5|      5  /System.Windows.Controls.ExceptionValidationRule  5}      5      .��5�      5�      �� 5�   
   #��[ 5�      $	��100��5�      $8
 2Resource name: MaterialDesignRaisedLightDarkButton��5�      $��983,22,29,526q�6B   ��5�      �� *SearchCommand+.��5�   Y   
Поиск5�      5�      5�      