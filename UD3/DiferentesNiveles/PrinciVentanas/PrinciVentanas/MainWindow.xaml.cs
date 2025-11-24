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

namespace PrinciVentanas
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

        private void HacerClick(object sender, RoutedEventArgs e)
        {
            string nombre = MensajeTxt.Text;
            SegundaVentana ventana = new SegundaVentana(nombre);
            ventana.Show();

        }
    }
}