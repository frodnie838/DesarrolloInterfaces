using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace Avanzado
{
    /// <summary>
    /// Lógica de interacción para Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {
        public String Nombre = "";
        public int Edad = 0;
        public MainWindow.Usuario NuevoUser;
        public Ventana2()
        {
            InitializeComponent();
        }

        public void AceptarClick(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEdad.Text))
            {
                MessageBox.Show("Debe rellenar los campos");
                return;
            }
            else
            {
                Nombre = txtNombre.Text;
                Edad = int.Parse(txtEdad.Text);

                NuevoUser = new MainWindow.Usuario(Nombre, Edad);
                DialogResult = true;
                this.Close();
            }
            
        }

        public void Cancelar(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
