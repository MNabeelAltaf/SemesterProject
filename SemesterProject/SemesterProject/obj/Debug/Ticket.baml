   M S B A M L   `   `   `  ����J  FSemesterProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SemesterProjectSemesterProject  5   	       SemesterProject.Ticket   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SemesterProject     5   	     � WindowStartupLocation$  CenterScreen=�5   	   $	��600��5	   	   $
��1000��6    � Title$ Ticket��5
   	   $	��600��6   $
��1000��6%   .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��28* �6   �� 5      $	��41* �6   �� 5      $	��47* �6   �� 5      $
��176* �6   .+�5   
   � 
��� � �$��0��6"    � ColumnDefinitions 5      �� 5      $	��25* �6#   �� 5      $
��200* �6#   �� 5      $	��25* �6#   .+�5      �� $��Ticket��6   
���   �$��Comic Sans MS)�68   $��25(�6S   $��	10 10 0 0q�6a   $��Black"�6u   $��1��6�   $��346,-1,346,7q�6�   �� 5      -   5         ��Name$
 back��5      $��Center=�6#   $��Center=�6@   $��45��6[   $��40��6f   .��5      �� $��homeIcon.jpg��6   $	��100��6.   $	��100��6>   $��Center=�6M    J� RenderTransformOrigin$ 0.531,0.503&�6j   5      �� 5       -   5        $ history��5       $��2��6&   $��Center=�67   $��Center=�6T   $��40��6o   $��40��6{   .��5!      �� $��historyIcon.jpg��6   $��40��61   $��38��6=   5"      5$      �� 5&   
   $��0,56,0,0q�6   $��2��6#   .+�5(      �� $����Note : Please save and bring this ticket. This will be check before riding on the bus.
           Also bring photocopy of CNIC (provided at registration process). Incase of any  missing document, passenger will not allow to ride on
           the bus and amount will not be refund.��6   $	��980��5)      $	��118��6!   $��15(�6.   $��SemiBold"�5*      
���  ��
 �� Top$ 10��6;    �� Left$ 10��6K   5,      �� 5/   
   -   5        $��Show Ticket��5/      $��20(�6'   
���W�.�
����·�
�������$��Italic$�6y   $	��3.5q�6�   $��Times New roman)�6�   $
��Left=�6�   $��	28,40,0,0q�6�   $��2��6�   $	��Top=�6�   $��44��6*  $	��141��66  �� 51   
   $��3��6   
�������$
��Auto=�6=   $��24,10,24,217q�6b   .��53      &   System.Windows.Controls.DataGrid  -   5          Name$ tickets��53      
�������{�.  $��3��6S   $	   HorizontalScrollBarVisibility$
	 Auto=�6`   $��10,35,10,35q�6�   $	��987��6�   $ 0.5,0.5&�6�   $	��128��6�   55      �� 57   
   $��3��6   
�������$
��Auto=�6=   $��24,156,24,69q�6b   .��58        -   5        $ tickets2��58      
�������{�.  $��3��6T   $��10,35,10,35q�6b   $
��1006��6w   $	��123��6�   59      5<      5>      