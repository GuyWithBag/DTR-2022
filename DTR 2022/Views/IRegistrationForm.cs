using DTR_2022.Models;

namespace DTR_2022.Views
{
    public interface IRegistrationForm
    {
        event EventHandler<User> OnRegisterAttempt;
        void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon);
        void CloseAttempt();
    }
}