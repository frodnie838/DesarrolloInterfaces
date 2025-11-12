using Microsoft.Win32;
using System.IO;
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
        }

        public void Guardar(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Archivo de texto|*.txt",
                Title = "Guardar archivo"
            };

            if (saveDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveDialog.FileName, txtArea.Text);
                MessageBox.Show("Archivo guardado correctamente.", "Guardar", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtArea.Clear();
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