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

namespace XamlLayout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridPageButton_OnClick(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(new GridDemoPage());
        }

        private void StackPanelButton_OnClick(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(new StackPanelDemoPage());
        }

        private void ScrollViewerButton_OnClick(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(new ScrollViewDemoPage());
        }
    }
}
