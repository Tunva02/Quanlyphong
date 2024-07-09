using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Quanlyphong.Models;
using Quanlyphong.Utilities;
using Quanlyphong.View;

namespace Quanlyphong.ViewModel
{
    class RegisterVM : Utilities.ViewModelBase
    {
        public ObservableCollection<Account> Accounts { get; set; }
        private string selectedAccountType;
        public string SelectedAccountType
        {
            get { return selectedAccountType; }
            set { SetProperty(ref selectedAccountType, value); }
        }

        private string password;
        public string Password { get => password; set => SetProperty(ref password, value); }

        private string username;
        public string Username { get => username; set => SetProperty(ref username, value); }

        private string fullname;
        public string Fullname { get => fullname; set => SetProperty(ref fullname, value); }


       

        public ICommand RegisterCommand { get;  set; }
        public ICommand PasswordChanged { get; set; }


        public void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

            Password = ((PasswordBox)sender).Password;

        }

        public RegisterVM()
        {
            Accounts = new ObservableCollection<Account>();
            RegisterCommand = new RelayCommand(Register, CanRegister);
        }


        private bool CanRegister(object obj)
        {
            return !string.IsNullOrEmpty(SelectedAccountType) &&
                   !string.IsNullOrEmpty(Username) &&
                   !string.IsNullOrEmpty(Password) &&
                   !string.IsNullOrEmpty(Fullname); 
        }

        private void Register(object obj)
        {
            try
            {
                using (var db = new QuanlyphongContext())
                {
                    var existingAccount = db.Accounts.FirstOrDefault(u => u.Username == username);
                    if (existingAccount != null)
                    {
                        MessageBox.Show($"Tài khoản '{username}' đã tồn tại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    var account = new Account()
                    {
                        Role = SelectedAccountType,
                        Username = Username,
                        Password = Password, 
                        FullName = Fullname
                    };
                    db.Accounts.Add(account);
                    db.SaveChanges();
                    MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng ký thất bại: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {

            return false;
        }
    }
}
