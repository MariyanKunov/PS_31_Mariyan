   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	        StudentInfoSystem.JobApply   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentInfoSystem     5   	     � Title$  JobApply��5   	   $	��450��6   $	��800��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Apply for Job��6   $��0��6(   $��Center=�65   $��Center=�6R   $��25(�6m   	� 5   
   -   5        $��
GradeRadio��5   {   $��1. Apply with Grades ��6   $��Center=�66   $��1��6S   $��Center=�6`   $��20(�6�   $��0,10,0,0q�6�   	� 5   
   -   5        $��CVRadio��5   }   $��2. Apply with CV       ��6   $��Center=�68   $��2��6U   $��Center=�6b   $��20(�6�   $��0,10,0,0q�6�   � 5   
   $��4��6    � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��* �6#   6/   .+�5      �� -   5        $��GradeBox��5   �   $��1��6   $
��Left=�6&   $��25��6A    �� TextWrapping$
 Wrap=�6O   $	��Top=�6d   $	��120��6|   $��	15,25,0,0q�6�   6�   �� 5      $ ��Enter your average grade: ��6   $��Right=�69   $��15(�6U   $	��Top=�6d   $��	15,22,0,0q�6|   5!      �� 5"   
   -   5        $��APPLY��5"      $��Center=�6!   $��5��6?   $��Center=�6L   $��75��6g   6r   5$      5%      