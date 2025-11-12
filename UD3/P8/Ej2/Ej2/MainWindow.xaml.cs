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

        public void Centollo(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido el Centollo");
        }
        public void Gamba(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la Gamba");
        }
        public void Check(object sender, EventArgs e)
        {
            if (chk1.IsChecked)
            {
                MessageBox.Show("Has marcado el Check");
            }
            else
            {
                MessageBox.Show("Has desmarcado el Check");
            }
        }
        public void Dragon(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido el Dragon");
        }
        public void Logo(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido el logo");
        }

        public void Check_2(object sender, EventArgs e)
        {
            if (chk2.IsChecked)
            {
                MessageBox.Show("Has marcado el Check");
            }
            else
            {
                MessageBox.Show("Has desmarcado el Check 2");
            }
        }

    }
}