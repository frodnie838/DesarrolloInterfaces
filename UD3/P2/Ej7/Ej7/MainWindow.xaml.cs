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

namespace Ej7
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
        private void BClick(object sender, RoutedEventArgs e)
        {
            ShowSelectedText();
        }

        private void ImagenClick(object sender, MouseButtonEventArgs e)
        {
            ShowSelectedText();
            e.Handled = true;
        }

        private void ShowSelectedText()
        {
            var seleccionado = tBox?.SelectedText;
            if (string.IsNullOrEmpty(seleccionado))
            {
                MessageBox.Show("No hay selección en el TextBox.", "Selección", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Has seleccionado: "+seleccionado, "Selección", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}