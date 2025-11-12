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

namespace Ej1
{
    /// <summary>
    /// Lógica de interacción para SegundaVentana.xaml
    /// </summary>
    public partial class SegundaVentana : Window
    {
        private MainWindow main;
        public SegundaVentana(MainWindow Uno)
        {
            InitializeComponent();
            main = Uno;
        }

        private void EnviarEmail (object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            main.recoger(email);            
            this.Close();
        }
    }
}
