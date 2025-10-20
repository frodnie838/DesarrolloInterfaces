using System.Runtime.InteropServices;
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

namespace Ej6
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
        
        // Ahora capturamos la excepción localmente
        private void Crash(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] arr = new int[3];
                arr[10] = 5;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Te has pasado!!");
            }
        }
    }
}