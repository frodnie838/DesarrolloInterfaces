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
        private List<Brush> Colores = new List<Brush>
        {
            Brushes.Red,
            Brushes.Blue,
            Brushes.Green,
            Brushes.Orange,
            Brushes.Orchid,
            Brushes.Yellow,
            Brushes.Black,
            Brushes.Violet,
            Brushes.White,
            Brushes.Tomato
        };
        //Cambia el color del borde del boton
        private void B1(object sender, RoutedEventArgs e)
        {            
            Random r = new Random();
            btn1.BorderBrush = Colores[r.Next(Colores.Count)];            
        }
        //Cambia el color de fonde del boton
        private void B2(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            btn2.Background = Colores[r.Next(Colores.Count)];
        }
        //Cambia el color de fondo de Border Grande
        private void B3(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            BorderT.Background = Colores[r.Next(Colores.Count)];
        }
    }
}