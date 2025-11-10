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

namespace Ej1
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

        private void Simple_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola esto es un mensaje de prueba.");
        }

        private void Titulo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola esto es un mensaje de prueba con titulo.", "Titulo Prueba");
        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¿Deseas continuar?", "Confirmacion", MessageBoxButton.YesNoCancel);
        }

        private void Respuesta_Click(object sender, RoutedEventArgs e)
        {
            var resultado = MessageBox.Show("¿Guardar cambios?", "Guardar", MessageBoxButton.YesNoCancel);
            switch (resultado)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Has elegido: Sí");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Has elegido: No");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Has elegido: Cancelar");
                    break;
            }
        }

        private void Icono_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola esto es un mensaje de prueba con icono.", "Titulo Prueba", MessageBoxButton.OK,MessageBoxImage.Exclamation);
        }

        private void Marca_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Elige una opción (predeterminada: No).", "Elección por defecto", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
        }
    }
}