   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SpeedofMath2SpeedofMath2  5   	       SpeedofMath2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SpeedofMath2     5   	     � Title$  TheSpeedofMath2��5   	   $	��600��6!   $	��750��6.   
������� � 	Resources 5
      *   $SpeedofMath2.BoolVisibilityConverter   BoolVisibilityConverter��%   &	          5   
   6(   5      .��5      � $��Center=�6   $��Center=�6(   
���   �.+�5   
   �� $��The Speed of Math v2.0��6   
���   �
�������$��Calibri)�6X   $��36(�6m    �� TextAlignment$ Center=�6{   $��	0,100,0,0q�6�   y�6�   �� *titleVisible+ �� 	Converter# [   �� Mode$ TwoWay=��� 5   
   $��Timer:��6   
���   �
�������$��Calibri)�6H   $��16(�6]   $ Center=�6k   $��359,387.5,0,0q�6�   y�6�   �� *titleVisible+# [  $ TwoWay=�6�   �� 5   
   
������� J� Opacity$	 0.8Q�6W   $��Center=�6e   $��Center=�6�   $��25��6�   $��40��6�   $��535,375,70,65q�6'  ��6   �� *time+$ TwoWay=�y�6�   �� *startVisible+# [  $ TwoWay=�6'  �� 5   
   $��75��6   $	��200��6   $��Start��6)   
�����F�$
 0.75Q�6P   $��Center=�6�   $��0,200,0,195q�6  y�6_   �� *startVisible+# [  $ TwoWay=���6�   �� *StartCommand+6  �� 5   
    �� Orientation$ 
Horizontal=�6   $��	0,350,0,0q�6.   $��Center=�6A   y�6^   �� *startVisible+# [  $ TwoWay=�.+�5      	� $��Addition   ��6   
����İ�
�������$��	0,0,0,120q�6{   ��6_   �� *	AddOnly+6{   	� 5      $��Subtraction   ��6   
�������
�������$��	0,0,0,120q�6�   ��6h   �� *SubtractOnly+6�   	� 5      $��Multiplication   ��6   
����İ�
�������$��	0,0,0,120q�6�   ��6e   �� *MultiplyOnly+6�   	� 5      $��Division   ��6   
�������
�������$��	0,0,0,120q�6�   ��6e   �� *
DivideOnly+6�   	� 5      $	��All��6   
����İ�
������� d� 	IsChecked$
 TrueY�6o   $��	0,0,0,120q�6�   ��6W   �� *All+6�   5      �� 5   
   
�������$��Calibri)�6�   $��36(�6�   $ Center=�6�   $��114,85,115,324q�6�   ��6   �� *	qOutput+y�6@   �� *qTextVisible+# [  $ TwoWay=�6�   �� 5   
   -   5        $��
AnsButton1��5      
��� ���$ 0.775Q�6U   $��50��6e   $	��125��6q   $��113,225,404,198q�6}   ��6#   �� *buttonText1+y�6�   �� *button1Visible+# [  $ TwoWay=���6�   �� *ButtonCommand1+�� 5   
   -   5        $��
AnsButton2��5      
��� ���$ 0.775Q�6U   $��50��6e   $	��125��6q   $��258.5,225,258.5,198q�6}   ��6#   �� *buttonText2+y�6�   �� *button2Visible+# [  $ TwoWay=���6  �� *ButtonCommand2+�� 5   
   -   5        $��
AnsButton3��5      
��� ���$ 0.775Q�6U   $��50��6e   $	��125��6q   $��404,225,113,198q�6}   ��6#   �� *buttonText3+y�6�   �� *button3Visible+# [  $ TwoWay=���6�   �� *ButtonCommand3+�� 5    
   
�������$��
0,415,0,10q�6�   $��Calibri)�6�   $��24(�6�   $ Center=�6�   ��6   �� *streak+y�6>   �� *exitButtonVisible+# [  $ TwoWay=�6�   �� 5!   
   -   5        $
��Exit��5!      $
��Exit��6   
�������$	 0.8Q�6>   $��50��6L   $	��200��6X   $��329,314,113,80q�6�   y�6d   �� *exitButtonVisible+# [  $ TwoWay=���6�   �� *ExitCommand+6�   �� 5"   
   -   5        $��Retry��5"      $��Retry��6   
������$
 0.75Q�6F   $��50��6U   $	��200��6a   $��113,314,329,80q�6�   y�6m   �� *exitButtonVisible+# [  $ TwoWay=���6�   �� *RetryCommand+6�   5#      5$      