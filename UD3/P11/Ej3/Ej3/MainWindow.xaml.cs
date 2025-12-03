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

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            string mensaje =
                $"Nombre: {TxtNombre.Text}\n" +
                $"Nacimiento: {DpNacimiento.SelectedDate?.ToShortDateString()}\n" +
                $"Estado civil: {((ComboBoxItem)CbEstadoCivil.SelectedItem)?.Content}\n\n" +

                $"Profesión: {TxtProfesion.Text}\n" +
                $"Experiencia: {TxtExperiencia.Text} años\n\n" +

                $"Teléfono: {TxtTelefono.Text}\n" +
                $"Correo: {TxtCorreo.Text}\n" +
                $"Dirección:\n{TxtDireccion.Text}";

            MessageBox.Show(mensaje, "Datos Guardados");
        }
    }
}