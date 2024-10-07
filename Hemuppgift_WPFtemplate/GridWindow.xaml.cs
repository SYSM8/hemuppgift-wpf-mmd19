using System;
using System.Collections.Generic;
using System.Data.Common;
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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            int row, column;
            if (int.TryParse(RowInput.Text, out row) && int.TryParse(ColumnInput.Text, out column))
            {
                
                if (row >= 0 && row < 4 && column >= 0 && column < 4)
                {
                    Button btn1 = new Button
                    {
                        Content = $"Row: {row}, Column: {column}", 
                        Background = Brushes.LightGreen 

                    };


                    Grid.SetRow(btn1, row);
                    Grid.SetColumn(btn1, column);
                    myGrid.Children.Add(btn1);

                }
                else
                {
                    MessageBox.Show("Ange ett giltigt nummer mellan 0-3","Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Ange ett giltigt nummer mellan 0-3", "Error", MessageBoxButton.OK, MessageBoxImage.Stop);
            }







        }
    }
}
