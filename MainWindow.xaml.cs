using AutoUpdate;
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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Updater.GitHubRepo = "/mzghm/publishtest";
            //if (Updater.AutoUpdate(args))
            //    return;
            Updater.Update(new Version(1, 0, 0, 1));
            InitializeComponent();
        }

        private void OpenNewWindow(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }
    }
}
