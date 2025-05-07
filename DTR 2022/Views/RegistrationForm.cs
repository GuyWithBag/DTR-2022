using DTR_2022.Models;
using DTR_2022.Presenters;

namespace DTR_2022.Views
{
    public partial class RegistrationForm : Form, IRegistrationForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
            new RegistrationPresenter(this); // Initialize the presenter
            buttonRegister.Click += RegisterAttempt;
            buttonSelectImage.Click += ButtonSelectImage_Click; // Add image selection
        }

        public event EventHandler<User> OnRegisterAttempt;

        private void ButtonSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Profile Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;
                    string destinationFolder = Path.Combine(Application.StartupPath, "Images");
                    Directory.CreateDirectory(destinationFolder); // Create Images folder if it doesn't exist
                    string fileName = Path.GetFileName(sourcePath);
                    string destinationPath = Path.Combine(destinationFolder, fileName);

                    // Copy the image to the project folder
                    File.Copy(sourcePath, destinationPath, true);
                    textBoxProfileImage.Text = destinationPath; // Update textbox with full path

                    // Display the image (optional preview)
                    pictureBoxProfileImage.Image = Image.FromFile(destinationPath);
                    pictureBoxProfileImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        public void RegisterAttempt(object sender, EventArgs e)
        {
            // Create a User object with data from the form
            var user = new User
            {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                Sex = comboBoxSex.SelectedItem?.ToString(),
                Birthdate = dateTimePickerBirthdate.Value,
                ContactInfo = textBoxContactInfo.Text,
                Position = textBoxPosition.Text,
                HourlyRate = decimal.TryParse(textBoxHourlyRate.Text, out var rate) ? rate : 0,
                Password = textBoxPassword.Text,
                Photo = textBoxProfileImage.Text, // Use the file path
                Role = comboBoxRole.SelectedItem?.ToString()
            };

            // Validate required fields
            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Password))
            {
                ShowMessage("Name and Password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Invoke the event with the User object
            OnRegisterAttempt?.Invoke(this, user);
        }

        public void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buttons, icon);
        }

        public void CloseAttempt()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}