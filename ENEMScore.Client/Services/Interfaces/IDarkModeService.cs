namespace ENEMScore.Client.Services.Interfaces
{
    public interface IDarkModeService
    {
        bool isDarkMode { get; set; }
        event Action OnChange;
        void ToogleDarkMode();
    }
}
