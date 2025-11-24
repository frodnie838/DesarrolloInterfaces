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

namespace IntermedioVentana
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

        double descuento = 0;

        private void SelecCombo(object sender, EventArgs e)
        {
            if(MiCombo.SelectedItem is ComboBoxItem item)
            {
                descuento = double.Parse(item.Tag.ToString());
            }
        }

        private void Enviar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Debe introducir un precio.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!double.TryParse(txtPrecio.Text, out double precio) || double.Parse(txtPrecio.Text) < 1)
            {
                MessageBox.Show("Debe introducir un número válido.", "Error",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (descuento == 0)
            {
                MessageBox.Show("Debe seleccionar un porcentaje de descuento.",
                                "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            double precioFinal = precio * (1 - (descuento / 100.0));
                        
            Ventana2 ventana = new Ventana2(precioFinal);
            ventana.ShowDialog();
        }
    }
}