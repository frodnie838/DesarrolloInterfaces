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

        private void TabCambio(object sender, SelectionChangedEventArgs e)
        {
            if (TabMain.SelectedIndex == 1)
            {
                double v1, v2;
                if (!double.TryParse(tb1.Text, out v1))
                {
                    MessageBox.Show("El primer valor no es válido.", "Error",MessageBoxButton.OK, MessageBoxImage.Warning);
                    TabMain.SelectedIndex = 0;
                    return;
                }
                if (!double.TryParse(tb2.Text, out v2))
                {
                    MessageBox.Show("El segundo valor no es válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    TabMain.SelectedIndex = 0;
                    return;
                }
                tbResult.Text = v1+" x "+v2+" = "+(v1 * v2).ToString();
            }
        }
    }
}