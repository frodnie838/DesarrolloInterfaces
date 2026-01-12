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
    /// Lógica de interacción para NuevoParticipante.xaml
    /// </summary>
    public partial class NuevoParticipante : Window
    {
        public NuevoParticipante()
        {
            InitializeComponent();
        }

        /// <summary>Adds the participante.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void AddParticipante(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NuevoParticipante añadido", "Add", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
