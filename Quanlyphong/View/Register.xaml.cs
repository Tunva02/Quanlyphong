using Microsoft.VisualBasic.ApplicationServices;
using Quanlyphong.Models;
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
   
    public partial class Register : Window
    {
        public Register()
        {
        }
        private void btnDangKyTaiKhoan_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void cmbAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
