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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for DockPanelWindow.xaml
    /// </summary>
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
        }

        private void btnCenter_Click(object sender, RoutedEventArgs e)
        {
            TrophyImage.Visibility = Visibility.Visible;
            btnCenter.Visibility = Visibility.Collapsed;
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tryck på Center");
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tryck på Center");
        }

        private void btnTop_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tryck på Center");
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tryck på Center");
        }
    }
}
