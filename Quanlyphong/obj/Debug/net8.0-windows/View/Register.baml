   M S B A M L   `   `   `  ����F  BQuanlyphong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Quanlyphong.ViewQuanlyphong.View  5      =#clr-namespace:Quanlyphong.ViewModelQuanlyphong.ViewModel  5          Quanlyphong.View.Register   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Quanlyphong.View     5      2vm#clr-namespace:Quanlyphong.ViewModel     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � WindowStartupLocation$  CenterScreen=�5
   0    � WindowStyle$
 None=�6U    � 
ResizeMode$ NoResize=�6h    � DataContext 5      &   Quanlyphong.ViewModel.RegisterVM  5   
   .��5      � .+�5   
   �� 
������� �� Orientation$ 
Horizontal=�6(   .+�5      �� $	��350��6   ���	#FF6318A7.+�5      �� $��/Images/Login.jpeg��6   $	��289��64   $	��279��6@   $��30 10q�6M   $
��Fill=�6\   �� 5      $��Welcom to hotel��6   $
��20 0q�63   
���   � �� TextAlignment$ Center=�6T   $��28(�6k   $��Great Vibes)�6y   6�   5      �� 5      $	��380��6   .+�5      �� $��20 70q�6   .+�5      �� $��Đăng ký tài khoản��6    $��10q�69   
���   �$ Center=�6X   $��36(�6o   $��Great Vibes)�6}   6�   �� 5      -   5         ��Name$ 
cmbAccount��5      $��80��63   $��Times New Roman)�6>   $��16(�5       �� SelectedValuePath$ Content��6-   ��5      �� *SelectedAccountType+ �� UpdateSourceTrigger$ PropertyChanged=�.@�5      �� .��6'   user6-   �� 5      .��6'   admin6.   5      �� 5      $ 
Horizontal=�6!   $��10q�6:   .+�5       '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$
	 User=�62   $��30��6>   $��30��6I   
���   �6U   �� 5!      -   5        
 ��Name$
 txtTaiKhoanDangKy��5!   "   $
��10 0q�6|   $��20(�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter Username��6�   
���   �$	��250��6�   
���   � �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD94448��6=   �� *
Username+$ PropertyChanged=�6  5"      �� 5#      $ 
Horizontal=�6!   $��10q�6:   .+�5$        $
	 Lock=�62   $��30��6>   $��30��6I   
���   �6U   G� 5%      -   5         G�Name$ txtMatKhauDangKy��5%   &   $
��10 0q�5'   &   $��20(�64   $ ********��6B   
���   �$	��250��6   
���   � G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD94448 G� PasswordChanged 5&   &   �� *PasswordBox_PasswordChanged+5'   �   5(      �� 5)      $ 
Horizontal=�6!   $��10q�6:   .+�5*        $	 People=�62   $��30��6@   $��30��6K   
���   �6W   �� 5+      -   5        $
 txtFullNameDangKy��5+   "   $
��10 0q�5-   "   $��20(�60   $ Enter FullName��6>   
���   �$	��250��6�   
���   � �	#FFD94448 �	#FFD94448��5,   "   �� *
Fullname+$ PropertyChanged=�5-   �   5.      �� 5/      $��10q�6!   $��Center=�6-   .+�50      �� -   5         ��Name$ btnDangKyTaiKhoan��52   k    � Cursor$
 Hand��50   !   $	��150��60   $��40��6<      MaterialDesignRaisedButton#��[  6H   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��51   !   $��2q�6O   ���	#FF1261C1���	#FF1261C1
������� � ToolTip$ 
Đăng ký��52   K   $��20(�6]   $��
Đăng ký��6�   ��53   !   �� *RegisterCommand+54      55      56      57      �� 59      $��70��6   .+�5:      �� -   5        $ btnExit��5>   )    & "MaterialDesignFloatingActionButton#��[ 5:      $
 Hand��5<      $��Center=�5=      $ Close��5>      ��5;      Z� .��5?        $	 Close=�6.   
���  ��$��30��6L   $��30��6W   5@      5A      5B      5C      5D      