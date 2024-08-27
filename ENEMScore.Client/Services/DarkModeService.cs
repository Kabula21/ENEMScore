using ENEMScore.Client.Services.Interfaces;

namespace ENEMScore.Client.Services
{
    public class DarkModeService : IDarkModeService
    {
        public bool isDarkMode { get; set; } = false;

        public event Action OnChange;

        public void ToogleDarkMode()
        {
            isDarkMode = !isDarkMode;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
