   M S B A M L   `   `   `  ����J  FSemesterProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SemesterProjectSemesterProject  5   	   #    SemesterProject.DriverDetails   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SemesterProject     5   	     � Title$  DriverDetails��5   	   $	��482��6   $��630.361��6,    � Icon$ 
images.jpg��6<    � 
ResizeMode$ CanMinimize=�6N    � WindowStartupLocation$ CenterScreen=�6g   .��5	      � ��5
   
   �� 5       �� ImageSource$ DaewooExpress.jpg��6   .+�5   
   �� -   5        $
��Back��5      $
��Left=�6    $��	10,21,0,0q�6;   $	��Top=�6N   $��75��6f    � Cursor$
 Hand��6�   �� 5   
   -   5         ��Name$ DriverDetail��5      $
��Left=�6(   $	��314��6C   $��	38,61,0,0q�6P   $	��Top=�6c   $	��537��6{      DataTemplate1#���   6�    � 	Resources 5      ��%p  &	        �� 5      .R�5      � $	��407��6   $	��196��6'   .+�5      �� $
��Left=�6    $��78��6;   $��0,29,0,0q�6G   $	��Top=�6Y   $��73��6q   $'��!Photo Editor_2019102922390721.png��6|   �� 5      $��Stretch=�69   $��134,10,114,0q�6W   $	��Top=�6m   $
��Auto��6�   $��24��6�   ��6    �� *Name+6�   �� 5      $��Stretch=�69   $��134,121,114,0q�6W   $	��Top=�6n   $
��Auto��6�   $��30��6�   ��6    �� *Cnic+6�   �� 5      $��Stretch=�6<   $��134,80,114,0q�6Z   $	��Top=�6p   $
��Auto��6�   $��27��6�   ��6    �� *	Address+6�   �� 5      $��Stretch=�6<   $��134,44,114,0q�6Z   $	��Top=�6p   $
��Auto��6�   $��26��6�   ��6    �� *	contact+6�   �� 5      $
��Edit��6!   $��Stretch=�60   $��310,21,10,0q�6N   $	��Top=�6c   $
��Auto��6{   ���	#FFE4E4E4���	#FF57B01A$��44��6�   �� 5      -   5        $��Delete��5   !   $��Stretch=�62   $��310,0,10,49q�6P   $��Bottom=�6e   $
��Auto��6�   ���	#FFD11E1E���	#FFDAB6B6$��42��6�   �� 5      $��Name:��6    $
��Left=�60   $��78,8,0,0q�6K   $	��Top=�6]   �� 5      $��Licence Number:��6    $
��Left=�6:   $��
31,160,0,0q�6U   $	��Top=�6i   �� 5      $��Address:��6    $
��Left=�63   $��	78,81,0,0q�6N   $	��Top=�6a   �� 5      $��Contact��6    $
��Left=�62   $��	78,44,0,0q�6M   $	��Top=�6`   �� 5      $��CNIC:��6    $
��Left=�60   $��
78,121,0,0q�6K   $	��Top=�6_   �� 5      $��Stretch=�6=   $��134,160,114,0q�6[   $	��Top=�6r   $
��Auto��6�   $��30��6�   ��6    �� *
Licence_+6�   5      5       5"      5#      �� 5$   
   -   5         ��Name$ AddDriverBtn��5$      $��
Add Driver��6'   $
��Left=�6<   $��500,398,0,0q�6W   $	��Top=�6l   $��75��6�   $
 Hand��6�   �� 5%   
   -   5        $��	Show Data��5%      $
��Left=�6%   $��413,398,0,0q�6@   $	��Top=�6U   $��75��6m   6x   5'      5(      