using MySql.Data.MySqlClient;
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
        private readonly string connectionString = "Server=localhost; port=3306; Database=prueba; Uid=root; Pwd=password";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MostrarD(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM users";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder sb = new StringBuilder();
                    Datos d = new Datos(reader, sb);
                    d.ShowDialog();
                }
                catch (MySqlException ex)
                {
                    tbResult.Text = "Error al conectar con la Base de Datos. " + ex.Message;
                }
            }

            }

        private void BBDD(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    tbResult.Text = "Conexión establecida.";
                }
                catch (MySqlException ex)
                {
                    tbResult.Text = "Error al conectar con la Base de Datos. "+ex.Message;
                }
            }
        }
    }
}