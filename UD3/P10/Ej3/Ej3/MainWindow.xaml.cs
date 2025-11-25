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

namespace Ej3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tareas.Add("Correr");
            tareas.Add("Volar");
            tareas.Add("Nadar");
            tareas.Add("Saltar");
        }
        private List<string> tareas = new List<string>();
        
        private int contador = 0;
        private void AddTarea(object sender, RoutedEventArgs e)
        {
            NuevaTarea tareaN = new NuevaTarea();
            if (tareaN.ShowDialog() == true) 
            {
                String nuevaTarea = tareaN.newTarea;
                tareas.Add(nuevaTarea);
                MostrarT.Text = "Tarea agregada con exito";
            }
        }

        private void MostrarSig(object sender, RoutedEventArgs e)
        {
            MostrarT.Text = "Siguiente tarea a realizar:\n\n";
            if (tareas != null && tareas.Count > contador)
            {
                MostrarT.Text += tareas[contador];
                contador++;
            }
            else if (tareas != null && tareas.Count == contador)
            {
                MostrarT.Text += tareas[0];
                contador = 1;
            }
            else
            {
                MostrarT.Text = "No hay tareas pendientes";
            }
        }

        private void RealizarSig(object sender, RoutedEventArgs e)
        {
            MostrarT.Text = "Tarea realizada:\n\n";
            if (tareas.Count > 0 && tareas.Count > contador)
            {
                MostrarT.Text += tareas[contador];
                tareas.RemoveAt(contador);
            }
            else if (tareas.Count > 0 && tareas.Count == contador)
            {
                MostrarT.Text += tareas[0];
                tareas.RemoveAt(0);
                contador = 0;
            }
            else
            {
                MostrarT.Text = "No hay tareas pendientes";
            }
        }

        private void MostrarNTarea(object sender, RoutedEventArgs e)
        {
            MostrarT.Text = "Número de tareas por realizar: " + tareas.Count;
        }

        private void MostrarPen(object sender, RoutedEventArgs e)
        {
            MostrarT.Clear();
            if (tareas.Count > 0)
            {
                MostrarT.Text = "Tareas pendientes:\n\n";
                foreach (var i in tareas)
                {
                    MostrarT.Text += i + "\n";
                }
            }
            else
            {
                MostrarT.Text = "No hay tareas pendientes";
            }
        }
    }
}