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

namespace simulacro
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

        private void AddParticipante(object sender, RoutedEventArgs e)
        {
            NuevoParticipante p = new NuevoParticipante();
            p.Show();
        }

        private void ModActividad(object sender, RoutedEventArgs e)
        {
            ModificarActividad m = new ModificarActividad();
            m.Show();
        }

        private void DelParticipante(object sender, RoutedEventArgs e)
        {
            EliminarParticipante ep = new EliminarParticipante();
            ep.Show();
        }

        private void InformeCompleto(object sender, RoutedEventArgs e)
        {
            InformeCompleto m = new InformeCompleto();
            m.Show();
        }
    }
}