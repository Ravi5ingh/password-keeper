namespace PasswordKeeper
{
    partial class CreatePasswordForm
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
            this.enterPasswordLabel = new System.Windows.Forms.Label();
            this.reEnterPasswordLabel = new System.Windows.Forms.Label();
            this.enterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.reEnterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.viewHidePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterPasswordLabel
            // 
            this.enterPasswordLabel.AutoSize = true;
            this.enterPasswordLabel.Location = new System.Drawing.Point(12, 9);
            this.enterPasswordLabel.Name = "enterPasswordLabel";
            this.enterPasswordLabel.Size = new System.Drawing.Size(84, 13);
            this.enterPasswordLabel.TabIndex = 0;
            this.enterPasswordLabel.Text = "Enter Password:";
            // 
            // reEnterPasswordLabel
            // 
            this.reEnterPasswordLabel.AutoSize = true;
            this.reEnterPasswordLabel.Location = new System.Drawing.Point(12, 31);
            this.reEnterPasswordLabel.Name = "reEnterPasswordLabel";
            this.reEnterPasswordLabel.Size = new System.Drawing.Size(98, 13);
            this.reEnterPasswordLabel.TabIndex = 1;
            this.reEnterPasswordLabel.Text = "Re-Enter Password";
            // 
            // enterPasswordTextBox
            // 
            this.enterPasswordTextBox.Location = new System.Drawing.Point(124, 6);
            this.enterPasswordTextBox.Name = "enterPasswordTextBox";
            this.enterPasswordTextBox.PasswordChar = '*';
            this.enterPasswordTextBox.Size = new System.Drawing.Size(425, 20);
            this.enterPasswordTextBox.TabIndex = 2;
            this.enterPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterPasswordTextBox_KeyDown);
            // 
            // reEnterPasswordTextBox
            // 
            this.reEnterPasswordTextBox.Location = new System.Drawing.Point(124, 28);
            this.reEnterPasswordTextBox.Name = "reEnterPasswordTextBox";
            this.reEnterPasswordTextBox.PasswordChar = '*';
            this.reEnterPasswordTextBox.Size = new System.Drawing.Size(425, 20);
            this.reEnterPasswordTextBox.TabIndex = 3;
            this.reEnterPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reEnterPasswordTextBox_KeyDown);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(474, 54);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // viewHidePasswordButton
            // 
            this.viewHidePasswordButton.Location = new System.Drawing.Point(351, 54);
            this.viewHidePasswordButton.Name = "viewHidePasswordButton";
            this.viewHidePasswordButton.Size = new System.Drawing.Size(117, 23);
            this.viewHidePasswordButton.TabIndex = 5;
            this.viewHidePasswordButton.Text = "View Password";
            this.viewHidePasswordButton.UseVisualStyleBackColor = true;
            this.viewHidePasswordButton.Click += new System.EventHandler(this.viewHidePasswordButton_Click);
            // 
            // CreatePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 87);
            this.Controls.Add(this.viewHidePasswordButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.reEnterPasswordTextBox);
            this.Controls.Add(this.enterPasswordTextBox);
            this.Controls.Add(this.reEnterPasswordLabel);
            this.Controls.Add(this.enterPasswordLabel);
            this.Name = "CreatePasswordForm";
            this.Text = "Please Create a Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterPasswordLabel;
        private System.Windows.Forms.Label reEnterPasswordLabel;
        private System.Windows.Forms.TextBox enterPasswordTextBox;
        private System.Windows.Forms.TextBox reEnterPasswordTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button viewHidePasswordButton;
    }
}