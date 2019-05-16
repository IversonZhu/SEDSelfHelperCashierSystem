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

namespace SEDSelfHelpCashierSystem
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SystemConfig_BtnClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Window win = new Component.AdministratorLoginBox();
            win.ShowDialog();
            if (win.DialogResult == true)
            {
               
            }
        }

        private void no_check_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
