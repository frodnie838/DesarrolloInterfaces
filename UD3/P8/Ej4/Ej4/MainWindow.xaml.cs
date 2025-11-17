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

        private void Show(object sender, RoutedEventArgs e)
        {
            string seleccion = txtArea.SelectedText;

            MessageBox.Show(seleccion,"Mostrar",MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = txtArea.SelectionLength > 0;
        }
        private void CutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtArea.Cut();
        }
        private void CopyCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = txtArea.SelectionLength > 0;
        }
        private void CopyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtArea.Copy();
        }
        private void PasteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }
        private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtArea.Paste();
        }
    }
}