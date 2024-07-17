using Quanlyphong.Models;
using Quanlyphong.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Quanlyphong.View
{
    public partial class Login : Window
    {
        public Login()
        {
  
        }

        private void btnDangKy_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
             
        }
    }
}
