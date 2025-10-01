using System.Windows;
using System.Windows.Controls;

namespace SeatManageTrain
{
    /// <summary>
    /// Interaction logic for NavigationButtons.xaml
    /// </summary>
    public partial class NavigationButtons : UserControl
    {
        private readonly NavigationService _navigationService;
        public NavigationButtons()
        {
            InitializeComponent();
            _navigationService = new NavigationService();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var viewType = button.Tag.ToString();

            switch (viewType)
            {
                case "Dashboard":
                    _navigationService.NavigateTo(new DashboardView());
                    break;
                case "Ticket":
                    _navigationService.NavigateTo(new TicketView());
                    break;
                case "Train":
                    _navigationService.NavigateTo(new TrainView());
                    break;
                case "Setting":
                    _navigationService.NavigateTo(new SettingView());
                    break;
                case "Map":
                    _navigationService.NavigateTo(new MapView());
                    break;
            }
        }
        public NavigationService NavigationService => _navigationService;
    }
}
