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

namespace Ej2
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

        private void RGB(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)sR.Value;
            byte g = (byte)sG.Value;
            byte b = (byte)sB.Value;

            gridbase.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }
    }
}