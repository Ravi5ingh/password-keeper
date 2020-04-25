namespace PasswordKeeper
{
    partial class PasswordKeeperForm
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
            this.components = new System.ComponentModel.Container();
            this.passwordGridView = new System.Windows.Forms.DataGridView();
            this.DomainColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.controlBox.SuspendLayout();
            this.dataBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordGridView
            // 
            this.passwordGridView.AllowUserToOrderColumns = true;
            this.passwordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DomainColumn,
            this.PasswordColumn});
            this.passwordGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.passwordGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordGridView.Location = new System.Drawing.Point(3, 16);
            this.passwordGridView.Name = "passwordGridView";
            this.passwordGridView.Size = new System.Drawing.Size(770, 342);
            this.passwordGridView.TabIndex = 0;
            // 
            // DomainColumn
            // 
            this.DomainColumn.HeaderText = "Domain";
            this.DomainColumn.Name = "DomainColumn";
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.HeaderText = "Password";
            this.PasswordColumn.Name = "PasswordColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.saveButton);
            this.controlBox.Location = new System.Drawing.Point(12, 12);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(776, 59);
            this.controlBox.TabIndex = 1;
            this.controlBox.TabStop = false;
            this.controlBox.Text = "Control";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 19);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataBox
            // 
            this.dataBox.Controls.Add(this.passwordGridView);
            this.dataBox.Location = new System.Drawing.Point(12, 77);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(776, 361);
            this.dataBox.TabIndex = 2;
            this.dataBox.TabStop = false;
            this.dataBox.Text = "Data";
            // 
            // PasswordKeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.controlBox);
            this.Name = "PasswordKeeperForm";
            this.Text = "Password Keeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordKeeperForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.passwordGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.controlBox.ResumeLayout(false);
            this.dataBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView passwordGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomainColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox dataBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

