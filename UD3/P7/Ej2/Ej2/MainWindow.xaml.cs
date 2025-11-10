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

        private void Imagen_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG (*.png) | *.png| JPEG (*.jpeg) | *.jpeg| JPG (*.jpg) | *.jpg| Todos (*.*) | *.*";
            if (ofd.ShowDialog() == true) 
            {
                img.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
    }
}