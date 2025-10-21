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
            //Creamos el  grid
            var grid = new Grid();
            //Creamos el botón y le damos formato
            var button = new Button
            { 
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontWeight = FontWeights.Bold,
                Padding = new Thickness(20)
            };
            //Creamos el Wrap Panel
            var wrap = new WrapPanel();
            //Creamos el primer TextBlock
            var tb1 = new TextBlock 
            {
                Text = "Primero",
                Foreground = Brushes.Green
            };
            //Creamos el segundo TextBlock
            var tb2 = new TextBlock
            {
                Text = "Segundo",
                Foreground = Brushes.Blue
            };
            //Creamos el tercer TextBlock
            var tb3 = new TextBlock
            {
                Text = "Tercero"
            };

            wrap.Children.Add(tb1);
            wrap.Children.Add(tb2);
            wrap.Children.Add(tb3);

            // Asignar el WrapPanel dentro del botón y colocamos el botón en el Grid
            button.Content = wrap;
            grid.Children.Add(button);

            // Asignamos el Grid como contenido de la ventana
            this.Content = grid;


        }
    }
}