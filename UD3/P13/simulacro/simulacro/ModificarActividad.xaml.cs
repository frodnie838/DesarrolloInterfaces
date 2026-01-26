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
    /// Lógica de interacción para ModificarActividad.xaml
    /// </summary>
    public partial class ModificarActividad : Window
    {
        /// <summary>Initializes a new instance of the <see cref="ModificarActividad" /> class.</summary>
        public ModificarActividad()
        {
            InitializeComponent();
        }

        /// <summary>Futbols the specified sender.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void futbol(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Futbol", "Actividad", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>Atles the specified sender.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void atle(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Atletismo", "Actividad", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>Natas the specified sender.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void nata(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Natacion", "Actividad", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>Puens the specified sender.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void puen(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Puenting", "Actividad", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>Baloncs the specified sender.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void balonc(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Baloncesto", "Actividad", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>Tenises the specified sender.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void tenis(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Tenis", "Actividad", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
