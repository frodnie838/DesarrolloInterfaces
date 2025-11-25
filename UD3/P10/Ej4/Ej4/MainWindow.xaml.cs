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
        public MainWindow()
        {
            InitializeComponent();
        }
        private List<Empleado> empleados = new List<Empleado>();
        private void HoraExt(object sender, RoutedEventArgs e)
        {

        }

        private void Informe(object sender, RoutedEventArgs e)
        {

        }

        private void HorasTotales(object sender, RoutedEventArgs e)
        {

        }

        private void Alta(object sender, RoutedEventArgs e)
        {
            AltaEmpleado ap = new AltaEmpleado();
            if(ap.ShowDialog() == true)
            {
                Empleado emp = ap.nuevoEmp;
                empleados.Add(emp);
                MostrarT.Text = "Empleado añadido correctamente";
            }
        }

        public class Empleado
        {
            public string nombre { get; set; }
            public double salario { get; set; }
            public double horasExt { get; set; }

            public Empleado(string nombre, double salario)
            {
                this.nombre = nombre;
                this.salario = salario;
                this.horasExt = 0;
            }

            public override string ToString()
            {
                return nombre + " - " + salario + "€";
            }
        }
    }
}