   M S B A M L   `   `   `  ����D  @MyLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyLibrary.ViewMyLibrary.View  5   	       MyLibrary.View.AddNew   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   (localclr-namespace:MyLibrary.View  5   	     � WindowStyle$
  None=�5	   	   ���#b6ffff � Title$ AddNew��5   	   $	��560��6   $	��638��6%   $	��638��5   	   $	��560��6   $	��560��5   	   $	��638��6    � WindowStartupLocation$ CenterScreen=�5   	      AddNewViewModel � DataContext# [  5   	   .��5      � .+�5   
    �   � NavigationUIVisibility$ Hidden=�6   $��0,102,0,-0.333q�6U   ��60   ��  �� Path$ CurrentPage�6U   �� 5   
   $��
Книгу��65   $
��Left=�6E   $��
111,50,0,0q�6`   $	��Top=�6t   $��76��6�   ��6   �� *AddBooksCommand+6�   �� 5   
   $��
Фильм��65   $
��Left=�6E   $��
222,50,0,0q�6`   $	��Top=�6t   $��76��6�   ��6   �� *AddFilmsCommand+6�   �� 5   
   $��Сериал��67   $
��Left=�6H   $��
339,50,0,0q�6c   $	��Top=�6w   $��76��6�   ��6   �� *AddSerialsCommand+6�   �� 5   
   $��
Манга��65   $
��Left=�6E   $��
453,50,0,0q�6`   $	��Top=�6t   $��76��6�   ��6   �� *AddMangaCommand+6�   �� 5   
   -   5        $
��Left=�5      $��
566,10,0,0q�6-   $	��Top=�6A   $��55��6Y   $��26��6r   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CloseOutline=�6&   $��24��6:   $��23��6E   ���	#FF0069C1$��Center=�6h   $
��Left=�6�   5      5      5      