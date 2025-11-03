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

        private void CutCommand_CanExecute (object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtEditar != null) && (txtEditar.SelectionLength > 0);
        }
        private void CutCommand_Executed (object sender, ExecutedRoutedEventArgs e)
        {
            txtEditar.Cut();
        }
        private void PasteCommand_CanExecute (Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }
        private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditar.Paste();
        }
    }
}