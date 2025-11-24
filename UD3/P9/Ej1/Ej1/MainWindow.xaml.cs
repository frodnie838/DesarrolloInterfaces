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
            lstRango.Items.Add(new ItemsNombres { Texto = "Complete this WPF tutorial", Valor = 40 });
            lstRango.Items.Add(new ItemsNombres { Texto = "Learn C#", Valor = 80 });
            lstRango.Items.Add(new ItemsNombres { Texto = "Wash the car", Valor = 0 });
        }
        public class ItemsNombres
        {
            public string Texto { get; set; }
            public int Valor { get; set; }
        }
        private void showClick(object sender, RoutedEventArgs e)
        {
            if(lstRango.SelectedItem is ItemsNombres item)
            {
                MessageBox.Show("Seleccionado: " + item.Texto);
            }
            else
            {
                MessageBox.Show("No hay nada seleccionado");
            }
        }

        private void lastClick(object sender, RoutedEventArgs e)
        {
            lstRango.SelectedIndex = lstRango.Items.Count - 1;
        }

        private void nextClick(object sender, RoutedEventArgs e)
        {
            if (lstRango.SelectedIndex < lstRango.Items.Count - 1)
            {
                lstRango.SelectedIndex++;
            }else
            {
                lstRango.SelectedIndex = 0;
            }
        }

        private void cClick(object sender, RoutedEventArgs e)
        {
            foreach (var item in lstRango.Items)
            {
                if( item is ItemsNombres datos && datos.Texto == "Learn C#")
                {
                    lstRango.SelectedItem = item;
                    break;
                }
            }
        }

        private void allClick(object sender, RoutedEventArgs e)
        {
            lstRango.SelectAll();
        }
       
    }
}