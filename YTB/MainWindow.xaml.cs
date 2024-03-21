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

namespace YTB
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(searchbar.Text, "Zpráva ze searchbaru");
        }
        private void mainGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            mainGrid.Background = Brushes.LightBlue; // Change background color to light blue on mouse enter
        }

        private void mainGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            mainGrid.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x21, 0x21, 0x21)); // Change background color to original color on mouse leave
        }
        private void mainGrid_KeyDown(object sender, KeyEventArgs e)
        {
            const double moveStep = 5; // Adjust this value based on how much you want to move the image
            if (e.Key == Key.Up)
            {
                fotka.Margin = new Thickness(fotka.Margin.Left, fotka.Margin.Top - moveStep, 0, 0);
            }
            else if (e.Key == Key.Down)
            {
                fotka.Margin = new Thickness(fotka.Margin.Left, fotka.Margin.Top + moveStep, 0, 0);
            }
            else if (e.Key == Key.Left)
            {
                fotka.Margin = new Thickness(fotka.Margin.Left - moveStep, fotka.Margin.Top, 0, 0);
            }
            else if (e.Key == Key.Right)
            {
                fotka.Margin = new Thickness(fotka.Margin.Left + moveStep, fotka.Margin.Top, 0, 0);
            }
        }
    }
}
