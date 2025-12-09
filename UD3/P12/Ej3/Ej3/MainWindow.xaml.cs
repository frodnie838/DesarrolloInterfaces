using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
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
using System.Xml.Linq;

namespace Ej3
{
    public partial class MainWindow : Window
        {
            private readonly string connectionString = "Server=localhost; port=3306; Database=prueba; Uid=root; Pwd=password";
        public ObservableCollection<users> ListaU { get; set; }

        private MySqlConnection _connection;
        public MainWindow()
        {
            InitializeComponent();
            ListaU = new ObservableCollection<users>();
        }

        private void MostrarD(object sender, RoutedEventArgs e)
        {

            try
            {
                if (_connection == null || _connection.State != ConnectionState.Open)
                {
                    tbResult.Text = "Debe conectar con la base de datos";
                    return;
                }

                string sql = "SELECT * FROM users";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                ListaU.Clear();
                while (reader.Read())
                {
                    ListaU.Add(new users(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                }
                Datos d = new Datos(ListaU);
                d.ShowDialog();
                _connection.Close();
                tbResult.Text = "Conexión cerrada";
            }
            catch (MySqlException ex)
            {
                tbResult.Text = "Error al conectar con la Base de Datos. " + ex.Message;
            }


        }

        private void BBDD(object sender, RoutedEventArgs e)
        {

            try
            {
                if (_connection == null)
                {
                    _connection = new MySqlConnection(connectionString);
                }
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                tbResult.Text = "Conexión establecida.";
            }
            catch (MySqlException ex)
            {
                tbResult.Text = "Error al conectar con la Base de Datos. " + ex.Message;
            }

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

        private void InsertarD(object sender, RoutedEventArgs e)
        {
            if(_connection == null || _connection.State != ConnectionState.Open)
            {
                tbResult.Text = "Debe conectar con la base de datos";
                return;
            }
            Insertar i = new Insertar();
            i.ShowDialog();
        }
    }
}