using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using Quanlyphong.Models;
using Quanlyphong.ViewModel;
using System.Net;
using System.Security.Principal;
using System.Security;
using System.Windows.Input;
using Quanlyphong.Utilities;
using System.Windows.Controls;
using static MaterialDesignThemes.Wpf.Theme;


namespace Quanlyphong.ViewModel
{
    class LoginVM : Utilities.ViewModelBase
    {
        public ObservableCollection<Account> Accounts   { get; set; }
       
        public ICommand LoginCommand { get; set; }
        public ICommand PasswordChanged { get; set; }

        public LoginVM() 
        { 
            Accounts = new ObservableCollection<Account>();
            LoginCommand = new RelayCommand(Login, CanLogin);
        }




        public void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.PasswordBox)
            {
                Password = ((System.Windows.Controls.PasswordBox)sender).Password;
            }
        }


        private bool CanLogin(object arg)
        {
            return true;
        }

        private void Login(object obj)
        {
             using (var context = new QuanlyphongContext())
             {

                  bool isValid = context.Accounts.Any(u => u.Username == username && u.Password == password);
                  if (isValid)
                  {
                       MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                       MainWindow mainWindow = new MainWindow();
                       mainWindow.Show();
                  }
                  else
                  {
                       MessageBox.Show("Vui lòng kiểm tra lại thông tin tài khoản và mật khẩu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                  }


             }
        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {          
            return false;
        }

        private string password;

        public string Password { get => password; set => SetProperty(ref password, value); }

        private string username;

        public string Username { get => username; set => SetProperty(ref username, value); }
            
    }

}
