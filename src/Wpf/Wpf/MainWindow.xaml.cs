using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf
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

        private void FirstWindow_Click(object sender, RoutedEventArgs e)
        {
            Window1 firstWindow = new Window1();
            firstWindow.Show();
            this.Close();
        }

        private void SecondWindow_Click(object sender, RoutedEventArgs e)
        {
            CalculatorWindow second1Window = new CalculatorWindow();
            second1Window.Show();
            this.Close();
        }

        private void ThirdWindow_Click(object sender, RoutedEventArgs e)
        {
            Window3 thirdWindow = new Window3();
            thirdWindow.Show();
            this.Close();
        }
        private void FourWindow_Click(object sender, RoutedEventArgs e)
        {
            Window4 fourWindow = new Window4();
            fourWindow.Show();
            this.Close();
        }
    }
}