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

namespace Ej4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private bool contador = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CambiarImg(object sender, RoutedEventArgs e)
        {
            if (contador)
            {
                Imagen.Source = new BitmapImage(new Uri("/images/andalucia.png", UriKind.Relative));
                contador = false;
            }
            else
            {
                Imagen.Source = new BitmapImage(new Uri("/images/dragon.png", UriKind.Relative));
                contador = true;
            }
        }
    }
}