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

namespace WPF_Exercise
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
        public Random Random { get; set; } = new Random();
        public Grid children { get; }

        private SolidColorBrush NewColor()
        {
            var r = Convert.ToByte(Random.Next(0, 255));
            var g = Convert.ToByte(Random.Next(0, 255));
            var b = Convert.ToByte(Random.Next(0, 255));

            return  new SolidColorBrush(Color.FromRgb(r, g, b)); 
        }

        private void LeftMouse_Clicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = NewColor();
            MessageBox.Show($"{btn.Content}'s color is changed" );
        }

        private void RightMouse_Clicked(object sender, MouseButtonEventArgs e)
        {
            Button btn = sender as Button;
            GridBtn.Children.Remove(btn);
            Title = btn.Content.ToString();
        }
    }
}
