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

namespace Ej3
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

        public void Enviar(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string comentario = txtComentario.Text;
            string mensaje = "El usuario " + nombre + " con email " + email + " envía el mensaje " + comentario;
            if (string.IsNullOrEmpty(comentario) )
            {
                mensaje = "El usuario " + nombre + " con email " + email + " no ha enviado ningún mensaje ";
            }

            

            MessageBox.Show(mensaje);
        }
        
    }
}