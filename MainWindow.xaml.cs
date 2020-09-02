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

namespace Popovv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageSourceConverter imageSource = new ImageSourceConverter();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content)
            {
                case "Наука":
                    ShowDialog(TestWindow("science"));
                    Hide();
                    break;
                case "Медицина":
                    ShowDialog(TestWindow("med"));
                    Hide();
                    break;
                case "IT":
                    ShowDialog(TestWindow("it"));
                    Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
