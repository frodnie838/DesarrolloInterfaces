using Microsoft.Win32;
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
using System.IO;

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

        private void AbrirFichero(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Texto (*.txt) | *.txt| Todos (*.*) | *.*";

            if (ofd.ShowDialog() == true)
            {
                txtArea.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void GuardarFichero(Object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Texto (*.txt)|*.txt|C# (*.cs)|*.cs";                        


            if (sfd.ShowDialog() == true)
            {
                File.WriteAllText(sfd.FileName, txtArea.Text);
            }

        }
    }    
}