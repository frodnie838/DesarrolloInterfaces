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
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Avanzado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dgUsuarios.ItemsSource = usuarios;
        }
        private void AgregarUsu(object sender, RoutedEventArgs e)
        {            
            Ventana2 ventana = new Ventana2();

            if (ventana.ShowDialog() == true)
            {
                /*string nombre = ventana.Nombre;
                int edad = ventana.Edad;
                lstUsuarios.Items.Add(nombre+ " - " +edad+ " años");*/

                Usuario user = ventana.NuevoUser;
                lstUsuarios.Items.Add(user.ToString());
                usuarios.Add(user);
            }
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public class Usuario
        {
            public string nombre { get; set; }
            public int edad { get; set; }
            public Usuario(String nombre, int edad) 
            { 
                this.nombre = nombre;
                this.edad = edad;
            }
            public override string ToString()
            {
                return nombre+" - "+edad;
            }
        }

        private ObservableCollection<Usuario> usuarios = new ObservableCollection<Usuario>();
    
    }
}