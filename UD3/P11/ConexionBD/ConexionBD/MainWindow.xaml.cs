using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace ConexionBD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        private readonly string con = "Server=localhost; Port=3306; Database=prueba; Uid= root; Pwd=password;";
        public ObservableCollection<users> ListaUsuarios { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ListaUsuarios = new ObservableCollection<users>();
            DataContext = this;
        }
        public class users
        {
            public int idusers { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public int age { get; set; }

            public users(int id, string n, string s, int a)
            {
                idusers = id;
                name = n;
                surname = s;
                age = a;
            }
        }

        private void CargarDatos(object sender, RoutedEventArgs e)
        {
            using(MySqlConnection conexion = new MySqlConnection(con))
            {
                try
                {
                    conexion.Open();
                    string sql = "SELECT * FROM users";
                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder sb = new StringBuilder();
                    while (reader.Read()) {
                        sb.Append(reader.GetInt32(0));
                        sb.Append(" ");
                        sb.Append(reader.GetString(1));
                        sb.Append(" ");
                        sb.Append(reader.GetString(2));
                        sb.Append(" ");
                        sb.Append(" ");
                        sb.Append(reader.GetInt32(3));
                        sb.Append("\n");
                        ListaUsuarios.Add(new users(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));

                    }
                    lbLista.Text = sb.ToString();
                    //lbLista.Text = "Se ha conectado a la base de datos " + conexion.Database;

                    
                }
                catch (Exception ex) { 
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}