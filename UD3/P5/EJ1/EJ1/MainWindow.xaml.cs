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

namespace EJ1
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

        public void Limpiar(object sender, RoutedEventArgs e)
        {
            txtNombre.Clear();
            txtEmail.Clear();
        }

        public void Cancelar(object sender, RoutedEventArgs e) {
            MessageBox.Show("Acción cancelada");
            txtNombre.Clear();
            txtEmail.Clear();
        }

        public void Enviar(object sender, RoutedEventArgs e) {
            MessageBox.Show("Datos enviados!! Nombre: "+txtNombre.Text+" Correo electrónico: "+txtEmail.Text);
        }
    }
}