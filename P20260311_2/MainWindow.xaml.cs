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

namespace P20260311_2
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

        private void belep_Click(object sender, RoutedEventArgs e)
        {
            Jelentkezes j = new Jelentkezes();
            j.Show();
        }

        private void kilep_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void regisztral_Click(object sender, RoutedEventArgs e)
        {
            Regisztacio r = new Regisztacio();
            r.Show();
        }
    }
}