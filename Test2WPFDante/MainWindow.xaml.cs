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

namespace Test2WPFDante
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
            Rectangle vierkant = new Rectangle();
            vierkant.Height = 100;
            vierkant.Width = 100;
            vierkant.Margin = new Thickness(210, 10, 0, 0);
            vierkant.Stroke = new SolidColorBrush(Colors.Yellow);
            vierkant.StrokeThickness = 2;
            canvas.Children.Add(vierkant);

        }
        
        private void vergrootknop_Click(object sender, RoutedEventArgs e)
        {
            
            cirkel.Width = 200;
            cirkel.Height = 200;
        }

        private void cirkel_MouseEnter(object sender, MouseEventArgs e)
        {
            cirkel.Stroke = new SolidColorBrush(Colors.Black);
        }

        private void cirkel_MouseLeave(object sender, MouseEventArgs e)
        {
            cirkel.Stroke = new SolidColorBrush(Colors.Yellow);
        }
    }
}
