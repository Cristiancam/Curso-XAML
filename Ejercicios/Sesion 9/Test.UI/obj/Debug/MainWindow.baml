   M S B A M L   `   `   `  ����B  >Test.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Test.UI.ConvertersTest.UI.Converters  5   	       Test.UI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7
Converters clr-namespace:Test.UI.Converters     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   e aGalaSoft.MvvmLight.Extras, Version=4.4.32.39728, Culture=neutral, PublicKeyToken=0e27b6f8be9b2ef7-Custom http://www.galasoft.ch/mvvmlight  6N     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)    � 	Resources 5
      /   )Test.UI.Converters.StatusToColorConverter   StatusToColorConverter  EventViewModelTemplate1 �� Padding �� CornerRadius �� 	Converter.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName.  (System.Windows.Interactivity.TriggerBase   Actions/  )GalaSoft.MvvmLight.Command.EventToCommand   Command��%>  &	        &	      7     5   
   6,   �� 5   
   .R�5      �� $ 	5,6.2,5,5q�6j   $ 5��6~   ��6   �� *
IsSelected+8    5        5      $ 	MouseDown��6%   . 5         60   �� *SelectEventCommand+5      ._�5      �� ��6   �� *Description+5      5      5      	 � DataContext	 5      �� 5   
   
 �� Path$

 Main�6     Locator �� Source# [ 6   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5!   
   (� $��0q�6   $
��Left=�6   .��5"      ��  �� Orientation$ 
Horizontal=�6   $��15.96��62   $��90.61��6A   .+�5#      �� $
��Wrap=�6   $
��Bold"�60   $��0,0,5,0q�6B   $��Total: ��6S   
���   �6b   �� 5$      $
��Wrap=�6   ���	#FF040404��60   �� *TotalPoints+6M   5%      5&      �� 5'   
   #���  5(      $��	0,0,211,0q�5)   #   $��1��66   ��6   �� *Events+66   �� 5*   
   $��Registrar evento��5,      $
��Left=�6'   $��
320,16,0,0q�6B   $��1��6V   $	��Top=�6c   $	��173��6{   $	��187��6�   	 5+      �� *
NewEvent+.��5-      �� $
��Left=�6   $��	10,10,0,0q�64   $	��Top=�6G   $	��155��6_   .+�5.      �� $
��Wrap=�6   $��Evento��60   �� 5/      $��23��6    �� TextWrapping$
 Wrap=�6&   ��50      �� *Description+�� 51      $
��Wrap=�6   $��Puntos��60   �� 52      $��23��6   $
 Wrap=�6&   ��53      �� *Points+�� 54      $��Guardar��6   $��0,10,0,0q�56      ��55      �� *SaveCommand+56      57      58      59      5:      