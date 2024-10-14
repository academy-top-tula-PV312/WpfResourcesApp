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

namespace WpfResourcesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var solidMagenta = new SolidColorBrush(Colors.Magenta);
            this.Resources.Add("solidMagenta", solidMagenta);

            //List<string> cities = new List<string>() { "Moscow", "Voroneg", "Novgorod" };

            //this.Resources.Add("citiesList", cities);

            InitializeComponent();

            btnDynRes.SetResourceReference(Button.BackgroundProperty, "solidRed");

            //btnMagenta.Background = (Brush)this.Resources["solidMagenta"];
            btnMagenta.Background = (Brush)this.TryFindResource("solidMagenta");
        }

        private void btnMagenta_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["solidRed"] = new SolidColorBrush(Colors.Orange);
        }
    }
}