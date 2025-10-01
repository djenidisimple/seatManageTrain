using System.Windows;
using System.Windows.Controls;

namespace SeatManageTrain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavButtons.NavigationService.OnViewChanged += OnViewChanged;

            // Vue par défaut
            NavButtons.NavigationService.NavigateTo(new DashboardView());
        }
        private void OnViewChanged(UserControl newView)
        {
            // NETTOYAGE AUTOMATIQUE : Le ContentControl gère ça tout seul
            MainContent.Content = newView;
        }
    }
}
