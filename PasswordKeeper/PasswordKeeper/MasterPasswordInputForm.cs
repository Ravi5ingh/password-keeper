using System;
using System.Windows.Forms;

namespace PasswordKeeper
{
    public partial class MasterPasswordInputForm : Form
    {
        public MasterPasswordInputForm()
        {
            InitializeComponent();
        }

        private void masterPasswordSubmitButton_Click(object sender, EventArgs e)
        {
            SubmitPassword();
        }

        private void masterPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SubmitPassword();
            }
        }

        private void SubmitPassword()
        {
            if (Persistence.CheckMasterPassword(masterPasswordTextBox.Text))
            {
                this.Visible = false;
                var passwordKeeperForm = new PasswordKeeperForm(masterPasswordTextBox.Text)
                {
                    Visible = true
                };
            }
            else
            {
                MessageBox.Show("Wrong Password", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
