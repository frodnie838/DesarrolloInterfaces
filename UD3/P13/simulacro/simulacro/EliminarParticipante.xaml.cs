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

namespace simulacro
{
    /// <summary>
    /// Lógica de interacción para EliminarParticipante.xaml
    /// </summary>
    public partial class EliminarParticipante : Window
    {
        public EliminarParticipante()
        {
            InitializeComponent();
        }

        /// <summary>Bajas the participante.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void BajaParticipante(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Baja tramitada", "Baja", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
