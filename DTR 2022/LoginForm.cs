using DTR_2022.Presenters;
using DTR_2022.Views;
using System.Data;

namespace DTR_2022
{
    public partial class LoginForm : Form, ILoginForm
    {
        private readonly LoginPresenter _presenter;
        private string _loggedInUsername;

        public LoginForm()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this);
            buttonLogin.Click += LoginAttempt;
            Load += LoginForm_Load;
            FormClosing += LoginForm_FormClosing;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _presenter.LoadLogs();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(_loggedInUsername))
            {
                _presenter.LogLogout(_loggedInUsername);
            }
        }

        public event EventHandler<(string username, string password)> OnLoginAttempt;

        public void LoginAttempt(object sender, EventArgs e)
        {
            OnLoginAttempt?.Invoke(this, (textBoxIDNumber.Text, textBoxPassword.Text));
        }

        public void CloseAttempt()
        {
            this.DialogResult = DialogResult.OK;
        }

        public void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buttons, icon);
        }

        public void UpdateLogDisplay(DataTable logs)
        {
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new Action<DataTable>(UpdateLogDisplay), logs);
            }
            else
            {
                dataGridView1.DataSource = logs;
                dataGridView1.Columns["log_id"].Visible = false;
                dataGridView1.AutoResizeColumns();
            }
        }

        public string GetUsername()
        {
            return _loggedInUsername;
        }

        public void SetUsername(string username)
        {
            _loggedInUsername = username;
        }

        public void ShowForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ShowForm));
            }
            else
            {
                this.Show();
                this.BringToFront();
            }
        }

        public void RefreshLogs()
        {
            _presenter.LoadLogs();
        }
    }
}