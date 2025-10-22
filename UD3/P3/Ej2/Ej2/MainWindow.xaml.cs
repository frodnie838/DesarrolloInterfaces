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

namespace Ej2
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

        private int intentos = 0;
        private const int maxInt = 2;

        private void Corregir(object sender, RoutedEventArgs e)
        {
            if (intentos >= maxInt)
            {
                MessageBox.Show("No te quedan intentos.", "Información");
                return;
            }

            RadioButton selec = null;
            if (rbA.IsChecked == true) selec = rbA;
            else if (rbB.IsChecked == true) selec = rbB;
            else if (rbC.IsChecked == true) selec = rbC;
            else if (rbD.IsChecked == true) selec = rbD;

            if (selec == null)
            {
                MessageBox.Show("Selecciona una respuesta antes de corregir.", "Aviso");
                return;
            }

            intentos++;
            ActIntentos();

            var correcta = (selec.Tag != null && selec.Tag.ToString() == "True");

            if (correcta)
            {
                MessageBox.Show("Respuesta correcta. ¡Acertaste!", "Resultado");
                ReiniciarRb();
            }
            else
            {
                if (intentos >= maxInt)
                {
                    MessageBox.Show("Respuesta incorrecta. Ya no te quedan intentos.", "Resultado");
                    ReiniciarRb();
                }
                else
                {
                    int intRes = maxInt - intentos;
                    MessageBox.Show("Respuesta incorrecta. Te quedan " + intRes + " intentos.", "Resultado");
                }
            }
        }

        private void ActIntentos()
        {
            lblIntentos.Content = "Intentos: " + intentos + "/" + maxInt;
        }

        private void ReiniciarRb()
        {
            rbA.IsEnabled = false;
            rbB.IsEnabled = false;
            rbC.IsEnabled = false;
            rbD.IsEnabled = false;
            btnCorregir.IsEnabled = false;
        }
    }
}