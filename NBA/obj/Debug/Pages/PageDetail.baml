   M S B A M L   `   `   `  ����>  :NBA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NBA.Pages	NBA.Pages  5          NBA.Pages.PageDetail   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:NBA.Pages     5        N� Title$  
PageDetail��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   �� $��50��6(   $��50��64   ��6   �� *Logo+6A   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      o� $��17(�6   .@�5      m� -   5        $��Roster��5      $��Roster��6)   6P   m� 5      -   5        $��Mathup��5      $��Mathup��6)   6P   m� 5      -   5        $��Lineup��5      $��Lineup��6)   6P   5      �� 5      -   5        $��
PoiskCombo��5      $	��200��6)   $��17(�65   $��	20,0,10,0q�6C   6X   �� 5      -   5         ��Name$ SearhBtn��5      $��Search��6>   $��17(�6O   6_   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataPlayers��5       $��2��6   $��17(�65      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 No.��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 62   �� *
PlayerId+6Q     5      $
 Name��6%   	 63   �� *Name+6N     5      $ Position��6%   	 67   �� *Position.Name+6[     5       $ DateofBirth��6%   	 6:   �� *DateOfBirth+6\     5!      $ College��6%   	 66   �� *	College+6T     5"      $ 
Experience��6%   	 69   �� *Position.Abbr+6]     5#      $ Salary��6%   	 65   �� *Salary+6R   5%      5&      5'      