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

namespace Ej3
{
    /// <summary>
    /// Lógica de interacción para NuevaTarea.xaml
    /// </summary>
    public partial class NuevaTarea : Window
    {
        public NuevaTarea()
        {
            InitializeComponent();
        }
        public String newTarea;

        private void EnviarTarea(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tarea.Text))
            {
                MessageBox.Show("Debe introducir la tarea");
                return;
            }
            else
            {
                newTarea = tarea.Text;
                DialogResult = true;
                this.Close();
            }
        }
    }
}
