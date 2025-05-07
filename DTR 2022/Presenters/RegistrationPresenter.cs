using DTR_2022.Models;
using DTR_2022.Repositories;
using DTR_2022.Views;

namespace DTR_2022.Presenters
{
    public class RegistrationPresenter
    {
        private readonly IRegistrationForm _view;
        private readonly UserRepository _repository;

        public RegistrationPresenter(IRegistrationForm view)
        {
            _view = view;
            _repository = new UserRepository();
            _view.OnRegisterAttempt += OnRegisterAttempt;
        }

        private void OnRegisterAttempt(object sender, User user)
        {
            try
            {
                // Additional validation (beyond view's basic checks)
                if (string.IsNullOrWhiteSpace(user.Role))
                {
                    _view.ShowMessage("Role is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (user.HourlyRate < 0)
                {
                    _view.ShowMessage("Hourly rate cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Register the user
                string result = _repository.RegisterUser(user);

                switch (result)
                {
                    case "201":
                        _view.ShowMessage("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _view.CloseAttempt(); // Close the form on success
                        break;
                    case "409":
                        _view.ShowMessage("Username already exists.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "400":
                        _view.ShowMessage("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "500":
                        _view.ShowMessage("An internal error occurred. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        _view.ShowMessage("Unexpected response from server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}