   M S B A M L   `   `   `  ����F  BQuanlyphong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Quanlyphong.ViewQuanlyphong.View  5   	   =#clr-namespace:Quanlyphong.ViewModelQuanlyphong.ViewModel  5   	       Quanlyphong.View.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   *localclr-namespace:Quanlyphong.View  5   	   ,vm#clr-namespace:Quanlyphong.ViewModel  5   	     � Title$  Login��5
   	   $	��450��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�60    � WindowStyle$
 None=�6U    � 
ResizeMode$ NoResize=�6h    � DataContext 5      #  Quanlyphong.ViewModel.LoginVM  5   
   .��5      � .+�5   
   � .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��350��6   ���	#FF6318A7.+�5      �� $	��287��6   $	��265��6(   $��30 10q�65   $
��Fill=�6D   $��/Images/Login.jpeg��6S   �� 5      $��Welcome to hotel��6    $��	20 30 0 0q�68   
���   � �� TextAlignment$ Center=�6^   $��28(�6u   $��Great Vibes)�6�   6�   5      �� 5      $	��390��6   .+�5      �� $��20 70q�6!   .+�5      �� $��Đăng nhập��6$   $��20q�65   
���   �$ Center=�6T   $��38(�6k   $��Great Vibes)�6y   6�   �� 5      $ 
Horizontal=�6%   $��10q�6>   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�66   $��30��6C   $��30��6N   
���   �6Z   �� 5      -   5         ��Name$ txtUsername��5   '   $
��10 0q�6|   $��20(�6�   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Enter Username��6�   
���   �$	��250��6�   
���   �
 �� 
CaretBrush
 �	#FFD94448 �� SelectionBrush �	#FFD94448��6<   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6  5      �� 5      $ 
Horizontal=�6%   $��10q�6>   .+�5        $
 Lock=�66   $��30��6B   $��30��6M   
���   �6Y   G� 5       -   5         G�Name$ txtPassword��5    +   $��20(�6@   $
��10 0q�6N   $	 ********��5!      
���   �$	��250��6[   
���   � G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD94448 G� PasswordChanged 5#      �� *PasswordBox_PasswordChanged+5$      �� 5&      $��10q�6%   $��Center=�61   .+�5'      �� -   5         ��Name$ btnLogin��5)   j    � Cursor$
 Hand��5'   F   $	��150��6T   $��40��6`      MaterialDesignRaisedButton#��[  6l   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5(      $��2q�6L   ���	#FF1261C1���	#FF1261C1
������� � ToolTip$ Đăng nhập��5)   H   $��20(�6\   $��Đăng nhập��6�   ��5'   %   �� *LoginCommand+5*      �� 5+      -   5        $ 	btnDangKy��5-   h   $��10q�5+   &   $	��150��62   $��40��6>   #��[  6J   $ 10��5,      $��2q�6L   ���	#FF1261C1���	#FF1261C1
�������$ 
Đăng ký��5-   H   $��20(�6Z   $��
Đăng ký��6�   5.      50      51      52      �� 53      $��60��6   .+�54      �� -   5        $ btnExit��57   "    & "MaterialDesignFloatingActionButton#��[ 54      $��Center=�56      $ Close��57      ��55      Z� .��58        $ Close=�62   
���  ��$��30��6P   $��30��6[   59      5:      5;      5=      5>      5?      