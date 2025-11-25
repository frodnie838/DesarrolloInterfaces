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
        private void dniSinLetra(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                String[] letras = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                try
                {
                    int num = int.Parse(numeros.Text.Trim());
                    if (numeros.Text.Trim().Length < 8)
                    {
                        letra.Text = "Debe introducir 8 dígitos";
                    }
                    else
                    {
                        String letrafin = letras[num % 23];
                        letra.Text = "La letra del DNI es la " + letrafin;
                    }
                }
                catch (FormatException ex)
                {
                    letra.Text = "Formato incorrecto: debe introducir 8 números";
                }

            }
        }
    }
}