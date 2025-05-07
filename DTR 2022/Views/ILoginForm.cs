using System.Data;

namespace DTR_2022.Views
{
    public interface ILoginForm
    {
        event EventHandler<(string username, string password)> OnLoginAttempt;
        void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon);
        void CloseAttempt();
        void UpdateLogDisplay(DataTable logs);
        string GetUsername();
        void SetUsername(string username);
        void ShowForm();
        void RefreshLogs();
        void UpdateWelcomeLabel(string name);
        void UpdateProfileImage(Image image);
    }
}