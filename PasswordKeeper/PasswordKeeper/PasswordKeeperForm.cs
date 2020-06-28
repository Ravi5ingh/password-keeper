using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordKeeper
{
    public partial class PasswordKeeperForm : Form
    {
        private readonly string _password;
        private readonly byte[] _salt = new byte[] { 0x50, 0x76, 0xf1, 0x6e, 0x20, 0x4f, 0x65, 0x64, 0x5a, 0x65, 0x64, 0x75, 0x79 };

        public PasswordKeeperForm(string password)
        {
            _password = password;
            InitializeComponent();
            loadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in passwordGridView.SelectedRows)
            {
                passwordGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var encryptedData = new List<string>();
            foreach(DataGridViewRow row in passwordGridView.Rows)
            {
                if( row.Cells["DomainColumn"].Value == null ||
                    row.Cells["PasswordColumn"].Value == null)
                {
                    continue;
                }
                encryptedData.
                    Add($"{Encrypt(row.Cells["DomainColumn"].Value.ToString(), _password, _salt)}" +
                    $"----{Encrypt(row.Cells["PasswordColumn"].Value.ToString(), _password, _salt)}");
            }
            Persistence.SaveEncryptedPasswords(encryptedData);
        }

        private void loadData()
        {
            if(!Persistence.PasswordDataExists)
            {
                return;
            }
            var decryptedData = new List<Tuple<string, string>>();
            foreach(var line in Persistence.EncryptedPasswordData)
            {
                var linesParts = line.Split(new[] { "----" }, StringSplitOptions.RemoveEmptyEntries);
                var domain = Decrypt(linesParts[0], _password, _salt);
                var password = Decrypt(linesParts[1], _password, _salt);
                decryptedData.Add(new Tuple<string, string>(domain, password));
            }

            foreach(var record in decryptedData)
            {
                var newRow = (DataGridViewRow)passwordGridView.Rows[0].Clone();
                newRow.Cells[0].Value = record.Item1;
                newRow.Cells[1].Value = record.Item2;
                passwordGridView.Rows.Add(newRow);
            }
        }

        /// <summary>
        /// Encrypt the given string with the encryption key
        /// </summary>
        /// <param name="clearText"></param>
        /// <param name="encryptionKey"></param>
        /// <returns></returns>
        private static string Encrypt(string clearText, string encryptionKey, byte[] salt)
        {
            var clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (var encryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes(encryptionKey, salt);
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (var memoryStream = new MemoryStream())
                {
                    using (var cs = new CryptoStream(memoryStream, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            return clearText;
        }

        /// <summary>
        /// Decrypt the encrypted string with the given encryption key
        /// </summary>
        /// <param name="cipherText"></param>
        /// <param name="encryptionKey"></param>
        /// <returns></returns>
        private static string Decrypt(string cipherText, string encryptionKey, byte[] salt)
        {
            cipherText = cipherText.Replace(" ", "+");
            var cipherBytes = Convert.FromBase64String(cipherText);
            using (var encryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes(encryptionKey, salt);
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        private void PasswordKeeperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            //deleteToolStripMenuItem.Enabled = passwordGridView.SelectedRows.Count > 0;
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            deleteToolStripMenuItem.Enabled = passwordGridView.SelectedRows.Count > 0;
        }
    }
}
