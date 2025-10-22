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

namespace Ej8
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
        private void Seleccionar(object sender, EventArgs e)
        {
            bool newVal = (Caja.IsChecked == true);
            di.IsChecked = newVal;
            sge.IsChecked = newVal;
            ad.IsChecked = newVal;
        }
        private void Sl(object sender, EventArgs e)
        {
            Caja.IsChecked = null;
            if ((di.IsChecked == true) && (sge.IsChecked == true) && (ad.IsChecked == true))
            { Caja.IsChecked = true; }
            if ((di.IsChecked == false) && (sge.IsChecked == false) && (ad.IsChecked == false))
            { Caja.IsChecked = false; }
        }
    }
}