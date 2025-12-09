using MySql.Data.MySqlClient;
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
using System.Xml.Serialization;

namespace Ej3
{
    /// <summary>
    /// Lógica de interacción para Insertar.xaml
    /// </summary>
    public partial class Insertar : Window
    {
        public Insertar()
        {            
            InitializeComponent();
        }

        private void CancelarD(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GuardarD(object sender, RoutedEventArgs e)
        {
            if(txtName.Text == null || txtSurname.Text == null || txtAge.Text == null)
            {
                MessageBox.Show("Debe introducir todos los datos");
                return;
            }

        }
    }
}
