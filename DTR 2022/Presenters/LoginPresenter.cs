using DTR_2022.Repositories;
using DTR_2022.Views;
using System.Data;

namespace DTR_2022.Presenters
{
    class LoginPresenter
    {
        private readonly ILoginForm _view;
        private readonly UserRepository _userRepository;

        public LoginPresenter(ILoginForm view)
        {
            _view = view;
            _userRepository = new UserRepository();
            _view.OnLoginAttempt += HandleLoginButtonClicked;
        }

        public void LoadLogs()
        {
            try
            {
                DataTable logs = _userRepository.GetUserLogs();
                _view.UpdateLogDisplay(logs);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error loading logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LogLogout(string username)
        {
            try
            {
                _userRepository.LogLogout(username);
                LoadLogs(); // Refresh logs after logout
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error logging logout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleLoginButtonClicked(object sender, (string username, string password) credentials)
        {
            string username = credentials.username;
            string password = credentials.password;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                _view.ShowMessage("Username and Password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_userRepository.IsValidUser(username, password))
            {
                string role = _userRepository.getUserRole(username);
                if (role == "HR")
                {
                    _userRepository.LogLogin(username);
                    _view.SetUsername(username);
                    _view.ShowMessage("Login successful! Loading registration form...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open RegistrationForm
                    RegistrationForm registrationForm = new RegistrationForm();
                    registrationForm.FormClosed += (s, args) =>
                    {
                        LogLogout(username); // Log logout when RegistrationForm closes
                        _view.ShowForm(); // Show LoginForm again
                        _view.RefreshLogs(); // Refresh logs
                    };
                    registrationForm.Show();
                    _view.CloseAttempt(); // Set DialogResult, but form remains open
                }
                else
                {
                    _userRepository.LogLogin(username);
                    _view.SetUsername(username);
                    _view.ShowMessage("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                _view.ShowMessage("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}