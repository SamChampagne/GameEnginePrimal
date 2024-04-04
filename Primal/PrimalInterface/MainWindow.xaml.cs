using PrimalInterface.gameproject;
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

namespace PrimalInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // événement Loaded (quand la page sera load, la méthode OnMainWindowLoaded se lance)
            Loaded += OnMainWindowLoaded;
        }
        private void OnMainWindowLoaded(object sender, RoutedEventArgs e)
        {
            // je désabonne l'événement loaded de la méthode comme sa elle se lance une fois et 
            // je lance la méthode OpenProjectBroswerDialog
            Loaded -= OnMainWindowLoaded;
            OpenProjectBrowserDialog();
        }
        private void OpenProjectBrowserDialog()
        {
            // créer une nouvelle instance du menu
            var projectBrowser = new ProjectMenu();
            // création d'un if en vérifiant si la boite est ouvert 
            if(projectBrowser.ShowDialog() == false)
            {
                Application.Current.Shutdown();
            }
            else
            {
                
            }

        }
    }
}