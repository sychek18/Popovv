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
                    OpenTestAsync("science").GetAwaiter();
                    Hide();
                    break;
                case "Медицина":
                    OpenTestAsync("med").GetAwaiter();
                    Hide();
                    break;
                case "IT":
                    OpenTestAsync("it").GetAwaiter();
                    Hide();
                    break;
                default:
                    break;
            }
        }
        private async Task OpenTestAsync(string TestClass)
        {
            await Task.Run(() => OpenTest(TestClass));
        }
        private void OpenTest(string TestClass)
        {
            Dispatcher.BeginInvoke((Action)(() => { 
            TestWindow testWindow = new TestWindow(TestClass);
            testWindow.ShowDialog();
            }));
        }
    }
}
