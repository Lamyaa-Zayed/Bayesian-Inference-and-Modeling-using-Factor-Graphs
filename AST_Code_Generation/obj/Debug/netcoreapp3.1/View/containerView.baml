   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�bclr-namespace:Microsoft.Expression.Interactivity.Layout;assembly=Microsoft.Expression.Interactions)Microsoft.Expression.Interactivity.Layout 5      N JAST_Code_Generation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AST_Code_GenerationAST_Code_Generation 5	      '   !AST_Code_Generation.containerView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      qilbclr-namespace:Microsoft.Expression.Interactivity.Layout;assembly=Microsoft.Expression.Interactions     5      b	 ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1*cmd http://www.galasoft.ch/mvvmlight 	 5      -local!clr-namespace:AST_Code_Generation 	 5	        � 	Resources  5      ,  &AST_Code_Generation.MouseDownConverter   mouseDownEventArgsConverter,  &AST_Code_Generation.MouseMoveConverter  mouseMoveEventArgsConverter)  #AST_Code_Generation.ButtonConverter  buttonEventArgsConverter' !AST_Code_Generation.LineConverter  lineEventArgsConverter��%t   &	        &	      &	 &     &	 9       5   
   6#     5   
   6#     5   
   6      5   
   6   5      .��5      � -   5         �Name$
 grid��5      .+�5   
   �� ��6   �� *ObservableRectangles+��5      �� 5      .R�5      �� 5      ��5      �� 5      .R�5      �� $��1q�6   
���   �$��70��6F   $��40��6Q   ��5      �� 5      .�5   "   ��  �� Property � �� �� Value
 ���� 6F   5       ._�5"      �� $��Center=�6;   $��Center=�6V   ��6$   �� *Title+6u   .   (System.Windows.Interactivity.Interaction   Triggers 5$      /   )System.Windows.Interactivity.EventTrigger  5%         	EventName$ 	MouseDown��6-   .   (System.Windows.Interactivity.TriggerBase   Actions. 5&   "   / 	 )GalaSoft.MvvmLight.Command.EventToCommand     EventArgsConverter# [  5'   *      PassEventArgsToCommand$
 True��5)   *   	   Command	 5&   5   �� *DataContext.MouseDownCommand+
 �� RelativeSource
 ��  �� Mode$ FindAncestor=� �� AncestorType
 Window �� Mode$ OneWay=�"   EventArgsConverterParameter 5(   *   ��  �� Path$ .�5)   *   5*        5+      $ MouseDoubleClick��6-   . 5,   "     # [  5-   *   $
 True��5/   *   	 5,   5   �� *%#DataContext.MouseDoubleClickCommand+
 �� $ FindAncestor=�
 Window$ OneWay=� 5.   *   �� $ .�5/   *   50      52      54      ��56      �� 57      .�58      ��  �@��Left 64   �� *
CanvasLeft+�� 59       �@��Top 63   �� *	CanvasTop+5:      5<      �� 5>   
   ��6   �� *ObservableLines+��5?      �� 5@      .R�5A      �� 5B      ��5D      �� 5E      .R�5F      �� 
���   �	 �� X1 6   �� *
Starting.X+	 �� Y1 65   �� *
Starting.Y+	 �� X2 6P   �� *
Ending.X+	 �� Y2 6h   �� *
Ending.Y+ 5G        5H      $ MouseUp��6-   . 5I   "     # [ 5J   *   $
 True��5L   *   	 5I   5   �� *DataContext.RemoveLineCommand+
 �� $ FindAncestor=�
 Window$ OneWay=� 5K   *   �� $ .�5L   *   5N      5P      5R      5T      �� 5V   
   ��6   �� *ObservableButtons+��5W      �� 5X      .R�5Y      �� 5Z      ��5\      �� 5]      .R�5^      ��  ��Name$ Bu��6   $	��...��6)   $��15��67   $��17��6B   $	��Top=�6N   $��	ExtraBold"�6f    5_        5`      $ Click��6-   . 5a   "     # [ 5b   *   $
 True��5d   *   	 5a   5   �� *DataContext.ShowWindowCommand+
 �� $ FindAncestor=�
 Window$ OneWay=� 5c   *   �� $ .�5d   *   5e      5g      5h      ��5j      �� 5k      .�5l      ��  �@��Left 64   �� *
CanvasLeft+�� 5m       �@��Top 63   �� *	CanvasTop+5n      5p      �� 5r   
   ��6   �� *ObservableRemove+��5s      �� 5t      .R�5u      �� 5v      ��5x      �� 5y      .R�5z      �� $ Bu��6   $��-��6)   $��15��65   $��15��6@   $	��Top=�6L   $��	ExtraBold"�6d    5{        5|      $ Click��6-   . 5}   "     # [ 5~   *   $
 True��5�   *   	 5}   5   �� *DataContext.RemoveCommand+
 �� $ FindAncestor=�
 Window$ OneWay=� 5   *   �� $ .�5�   *   5�      5�      5�      ��5�      �� 5�      .�5�      ��  �@��Left 64   �� *
CanvasLeft+�� 5�       �@��Top 63   �� *	CanvasTop+5�      5�      �� 5�   
   $��
0,0,-143,0q�6   $
��1526��6&   $	��Top=�64   .+�5�      �� -   5         ��Name$ toolbox��5�      $	��100��6)   $	��800��65    �� Left$ 10��6B   
 �� Top$ 25��6S   
���   �6t   �� 5�      -   5        $��	textBlock��5�      $��     ToolBox  ��6)   $��	ExtraBold"�6?   �� 5�      $	 840��6   $ 10��6&   $��50��67   $	��100��6C   $��Generate��6O    5�        5�      $ Click��6%   . 5�        	 6-   �� *DataContext.GenerateCommand+
 �� $ FindAncestor=�
 Window$ OneWay=�5�      5�      �� 5�      $	 900��6   $ 10��6&   $��50��67   $	��100��6C   $
��Save��6O    5�        5�      $ Click��6%   . 5�        	 6-   �� *DataContext.SaveCommand+
 �� $ FindAncestor=�
 Window$ OneWay=�5�      5�      �� 5�      $	 960��6   $ 10��6&   $��50��67   $	��100��6C   $
��Load��6O    5�        5�      $ Click��6%   . 5�        	 6-   �� *DataContext.LoadCommand+
 �� $ FindAncestor=�
 Window$ OneWay=�5�      5�      5�      5�      5�      