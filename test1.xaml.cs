using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

namespace Popovv



{
    public partial class test1 : Window
    {
      
        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Да, правильно");
        }

        private void acceptButton_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нет, не правильно");
        }

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // закрытие окна
        }
    }
}