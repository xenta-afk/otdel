   M S B A M L   `   `   `  ����F  BOtdelKadrov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OtdelKadrovOtdelKadrov  5   	       OtdelKadrov.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:OtdelKadrov     5   	   -   5          � Title$  HR Department��5   	   $	��450��6   $	��800��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� -   5        $��BtnDel��5   G   $��Удалить��6   $��85��6#   $��20��6.   $��2��6:   $��Right=�6j   $��	0,0,300,0q�6�   �� 5   
   -   5        $��BtnAdd��5   H   $��Добавить��6   $��85��6$   $��20��6/   $��2��6;   $
��Left=�6k   $��	300,0,0,0q�6�   �� 5   
   -   5        $��BtnDoc��5   I   $��Документы��6   $��85��6%   $��20��60   $��2��6<   $
��Left=�6l   $��10q�6�   6�   �� 5   
   -   5        $��BtnRep��5   E   $��
Отчёт��6   $��85��6!   $��20��6,   $��2��68   $��Right=�6h   $��10q�6�   6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� $4��.Информация о сотрудниках��6   $��20(�68   $
��Bold"�6F   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ employeesDataGrid��5      $��10q�6.   $��1��6:      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6J   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 62   �� *ФИО+6J     5      $ Дата рождения��6%   $ * 6^   	 6<   �� *Дата_рождения+6^     5      $ Пол��6%   $ * 6J   	 62   �� *Пол+6J     5       $ 
Адрес��6%   $ * 6N   	 64   �� *
Адрес+6N     5!      $! Номер телефона��6%   $ * 6`   	 6=   �� *Номер_телефона+6`     5"      $ Должность��6%   $ * 6V   	 68   �� *Должность+6V     5#      $ Дата найма��6%   $ * 6X   	 69   �� *Дата_найма+6X     5$      $% Заработная плата��6%   $ * 6d   	 6?   �� *!Заработная_плата+6d     5%      $# Дата увольнения��6%   $ * 6b   	 6>   �� *Дата_увольнения+6b   4  .System.Windows.Controls.DataGridTemplateColumn  5&      $
 auto 6)   
   CellTemplate
 5'      �� 5(      .R�5)      �� $��BtnEdit��6=   -   5        $ ��Редактировать��5)   %   6d   5*      5,      5.      5/      50      