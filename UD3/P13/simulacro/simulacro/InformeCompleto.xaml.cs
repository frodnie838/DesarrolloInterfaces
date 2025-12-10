using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
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

namespace simulacro
{
    /// <summary>
    /// Lógica de interacción para InformeCompleto.xaml
    /// </summary>
    public partial class InformeCompleto : Window
    {
        private string conexion = "server=localhost; port=3306; database=prueba; uid=root; pwd=password";
        private MySqlConnection connection;
        public ObservableCollection<users> Lista { get; set; }
        public InformeCompleto()
        {
            Lista = new ObservableCollection<users>();
            connection = new MySqlConnection(conexion);
            connection.Open();
            DataContext = this;
            InitializeComponent();

            String sql = "SELECT * FROM users";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Lista.Add(new users(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));                
            }
            if(Lista.Count == 0)
            {
                MessageBox.Show("No hay Participantes registrados", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
    }
}
