using System;
using System.Windows.Controls;

namespace SeatManageTrain
{
    public class NavigationService
    {
        public event Action<UserControl> OnViewChanged;

        public void NavigateTo(UserControl view)
        {
            OnViewChanged?.Invoke(view);
        }

        // Méthode utilitaire pour naviguer par type
        public void NavigateTo<T>() where T : UserControl, new()
        {
            NavigateTo(new T());
        }
    }
}