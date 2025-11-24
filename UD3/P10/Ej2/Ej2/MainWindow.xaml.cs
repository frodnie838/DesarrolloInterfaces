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

namespace Ej2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[,] matriz;
        private void Inicializa(object sender, RoutedEventArgs e)
        {   
            try
            {
                Random r = new Random();
                int dim = int.Parse(dimension.Text.Trim());
                if (dimension.Text.Length == 0)
                {
                    resultado.Text = "Debe introducir la dimensión de la matriz";
                }
                else
                {
                    matriz = new int[dim,dim];
                    for (int i = 0; i < dim; i++)
                    {
                        for (int j = 0; j < dim; j++)
                        {
                            matriz[i, j] = r.Next(1, 100);
                        }
                    }
                    resultado.Text = "Matriz creada con dimension " + dim;
                }
            }
            catch (FormatException ex) 
            {
                resultado.Text = "Formato incorrecto debe introducir un numero";
            }
            
        }

        private void ImpMatriz(object sender, RoutedEventArgs e)
        {
            if (matriz == null)
            {
                resultado.Text = "Hay que inicializar la matriz";
                return;
            }
            resultado.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    resultado.Text += matriz[i,j]+"\t";
                }
                resultado.Text += "\n"; 
            }
        }

        private void ImpTras(object sender, RoutedEventArgs e)
        {
            if(matriz == null)
            {
                resultado.Text = "Hay que inicializar la matriz";
                return;
            }
            resultado.Clear();
            int[,] matrizTras = new int[matriz.GetLength(1),matriz.GetLength(0)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizTras[j,i] = matriz[i,j];                    
                }                
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {                    
                    resultado.Text += matrizTras[i, j] + "\t";
                }
                resultado.Text += "\n";
            }
        }
    }
}