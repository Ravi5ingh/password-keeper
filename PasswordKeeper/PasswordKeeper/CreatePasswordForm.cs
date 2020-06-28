using System;
using System.Windows.Forms;

namespace PasswordKeeper
{
    public partial class CreatePasswordForm : Form
    {
        private readonly string _viewPasswordButtonText = "View Password";
        private readonly string _hidePasswordButtonText = "Hide Password";
        private bool _passwordsHidden = true;
        
        public CreatePasswordForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SubmitMasterPassword();
        }

        private void SubmitMasterPassword()
        {
            if (enterPasswordTextBox.Text != reEnterPasswordTextBox.Text)
            {
                MessageBox.Show("The two passwords entered must match", "Passwords mis-match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Persistence.SetMasterPassword(enterPasswordTextBox.Text);

            this.Visible = false;
            var passwordKeeperForm = new PasswordKeeperForm(enterPasswordTextBox.Text)
            {
                Visible = true
            };
        }

        private void viewHidePasswordButton_Click(object sender, EventArgs e)
        {
            switch(_passwordsHidden)
            {
                case true:
                    enterPasswordTextBox.PasswordChar = '\0';
                    reEnterPasswordTextBox.PasswordChar = '\0';
                    viewHidePasswordButton.Text = _hidePasswordButtonText;
                    _passwordsHidden = false;
                    break;
                case false:
                    enterPasswordTextBox.PasswordChar = '*';
                    reEnterPasswordTextBox.PasswordChar = '*';
                    viewHidePasswordButton.Text = _viewPasswordButtonText;
                    _passwordsHidden = true;
                    break;
            }
        }

        private void enterPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitMasterPassword();
            }
        }

        private void reEnterPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitMasterPassword();
            }
        }
    }
}
