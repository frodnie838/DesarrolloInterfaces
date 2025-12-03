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
        

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            if (TabControlMain.SelectedIndex > 0)
                TabControlMain.SelectedIndex--;
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            if (TabControlMain.SelectedIndex < TabControlMain.Items.Count - 1)
                TabControlMain.SelectedIndex++;
        }

        private void Seleccionado_Click(object sender, RoutedEventArgs e)
        {
            var tab = TabControlMain.SelectedItem as System.Windows.Controls.TabItem;
            if (tab != null)
            {
                MessageBox.Show($"Has seleccionado la opción de {tab.Header}",
                                "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }

}