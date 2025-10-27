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
        }
        const string usuario = "Admin";
        const string password = "1234";
        public void Password(Object sender, RoutedEventArgs e)
        {
            String usu = txtUsu.Text;
            String pass = pwdPass.Password;

            if (usu.Equals(usuario) && pass.Equals(password)) {
                MessageBox.Show("Bienvenido, "+usuario+"!!");
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta.");
                pwdPass.Clear();
            }

        }
    }
}