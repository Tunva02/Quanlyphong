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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Quanlyphong.View;

namespace Quanlyphong.UserControls
{
    /// <summary>
    /// Interaction logic for uc_Customer.xaml
    /// </summary>
    public partial class uc_Customer : UserControl
    {
        public uc_Customer()
        {
            
        }

        private void lsvKhachHang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnThemKhachHang_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();   
            addCustomer.ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, RoutedEventArgs e) 
        { 

        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
