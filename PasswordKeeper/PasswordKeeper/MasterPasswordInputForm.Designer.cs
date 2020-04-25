namespace PasswordKeeper
{
    partial class MasterPasswordInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.masterPasswordSubmitButton = new System.Windows.Forms.Button();
            this.passwordInputLabel = new System.Windows.Forms.Label();
            this.masterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // masterPasswordSubmitButton
            // 
            this.masterPasswordSubmitButton.Location = new System.Drawing.Point(512, 31);
            this.masterPasswordSubmitButton.Name = "masterPasswordSubmitButton";
            this.masterPasswordSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.masterPasswordSubmitButton.TabIndex = 0;
            this.masterPasswordSubmitButton.Text = "Submit";
            this.masterPasswordSubmitButton.UseVisualStyleBackColor = true;
            this.masterPasswordSubmitButton.Click += new System.EventHandler(this.masterPasswordSubmitButton_Click);
            // 
            // passwordInputLabel
            // 
            this.passwordInputLabel.AutoSize = true;
            this.passwordInputLabel.Location = new System.Drawing.Point(12, 9);
            this.passwordInputLabel.Name = "passwordInputLabel";
            this.passwordInputLabel.Size = new System.Drawing.Size(147, 13);
            this.passwordInputLabel.TabIndex = 1;
            this.passwordInputLabel.Text = "Please input master password";
            // 
            // masterPasswordTextBox
            // 
            this.masterPasswordTextBox.Location = new System.Drawing.Point(15, 34);
            this.masterPasswordTextBox.Name = "masterPasswordTextBox";
            this.masterPasswordTextBox.PasswordChar = '*';
            this.masterPasswordTextBox.Size = new System.Drawing.Size(491, 20);
            this.masterPasswordTextBox.TabIndex = 2;
            this.masterPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.masterPasswordTextBox_KeyDown);
            // 
            // MasterPasswordInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 83);
            this.Controls.Add(this.masterPasswordTextBox);
            this.Controls.Add(this.passwordInputLabel);
            this.Controls.Add(this.masterPasswordSubmitButton);
            this.Name = "MasterPasswordInputForm";
            this.Text = "Password Keeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button masterPasswordSubmitButton;
        private System.Windows.Forms.Label passwordInputLabel;
        private System.Windows.Forms.TextBox masterPasswordTextBox;
    }
}