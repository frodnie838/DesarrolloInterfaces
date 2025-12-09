using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static Ej2.MainWindow;

namespace Ej2
{
    /// <summary>
    /// Lógica de interacción para Datos.xaml
    /// </summary>
    public partial class Datos : Window
    {
        public ObservableCollection<users> ListaUsuarios { get; set; }
        public Datos(ObservableCollection<users> ListaU)
        {            
            ListaUsuarios = ListaU;
            InitializeComponent();
            DataContext = this;
        }
    }
}
