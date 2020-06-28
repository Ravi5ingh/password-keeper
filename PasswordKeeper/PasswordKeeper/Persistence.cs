using System.Collections.Generic;
using System.IO;

namespace PasswordKeeper
{
    public static class Persistence
    {
        #region Interface

        public static bool MasterPasswordExists => File.Exists($"{CurrentDirectory}\\pwd");

        public static void SetMasterPassword(string password)
        {   
            File.WriteAllText($"{CurrentDirectory}\\pwd", BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt(12)));
            BackupDataFile();
            File.Delete($"{CurrentDirectory}\\data");
        }

        public static bool CheckMasterPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, File.ReadAllText($"{CurrentDirectory}\\pwd"));
        }

        public static bool PasswordDataExists => File.Exists($"{CurrentDirectory}\\data");

        public static string[] EncryptedPasswordData => File.ReadAllLines($"{CurrentDirectory}\\data");

        public static void SaveEncryptedPasswords(List<string> passwordData)
        {
            File.WriteAllLines($"{CurrentDirectory}\\data", passwordData);
        }

        #endregion

        #region Private

        private static string CurrentDirectory
        {
            get
            {
                return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
            }
        }

        private static void BackupDataFile()
        {
            var suffix = 0;
            while (File.Exists($"{CurrentDirectory}\\data{Str(suffix)}"))
            {
                suffix++;
            }

            if (suffix > 0)
            {
                File.Copy(
                    $"{CurrentDirectory}\\data{Str(suffix - 1)}",
                    $"{CurrentDirectory}\\data{Str(suffix)}");
            }
        }

        private static string Str(int suffix)
        {
            return suffix == 0 ? string.Empty : suffix.ToString();
        }

        #endregion
    }
}
