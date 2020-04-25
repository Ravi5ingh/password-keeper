using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (masterPasswordTextBox.Text == "Drotinm20!")
            {
                this.Visible = false;
                var passwordKeeperForm = new PasswordKeeperForm("Drotinm20!")
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
