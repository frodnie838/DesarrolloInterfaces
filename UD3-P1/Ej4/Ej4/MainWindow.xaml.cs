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
        //Creamos la funcion Alerta asignándole un evento, el cuál lanzara un mensaje alert por pantalla 
        private void Alerta(Object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Alerta!!! Warning!!!");
        }
    }
}