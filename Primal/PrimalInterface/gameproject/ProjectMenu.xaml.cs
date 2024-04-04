using System;
using System.Collections.Generic;
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

namespace PrimalInterface.gameproject
{
    /// <summary>
    /// Logique d'interaction pour ProjectMenu.xaml
    /// </summary>
    public partial class ProjectMenu : Window
    {
        public ProjectMenu()
        {
            InitializeComponent();
            openProjectButton.IsChecked = true;
            newProjectButton.IsChecked = false;
        }
        private void OnToggle_ButtonClick(object sender, RoutedEventArgs e)
        {
            // si l'objet qui a déclencher à été déclencher par openProjectButton
            if(sender == openProjectButton)
            {
                if(newProjectButton.IsChecked == true)
                {
                    newProjectButton.IsChecked = false;
                    Browser.Margin = new Thickness(0);
                }
                openProjectButton.IsChecked = true;
            }
            else
            {
                if (openProjectButton.IsChecked == true)
                {
                    openProjectButton.IsChecked = false;
                    Browser.Margin = new Thickness(-800,0,0,0);
                }
                newProjectButton.IsChecked = true;
            }
            
        }
    }
}
