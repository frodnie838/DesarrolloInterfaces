using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ej4
{
    /// <summary>
    /// Lógica de interacción para AltaEmpleado.xaml
    /// </summary>
    public partial class AltaEmpleado : Window
    {
        public AltaEmpleado()
        {
            InitializeComponent();
        }
        public MainWindow.Empleado nuevoEmp; 
        private void Enviar(object sender, RoutedEventArgs e)
        {

        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
