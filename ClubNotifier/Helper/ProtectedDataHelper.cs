using ClubNotifier.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Helper {
    class ProtectedDataHelper {
        public static void SavePassword(String password) {
            //http://stackoverflow.com/a/12657970/4983032
            byte[] plaintext = Encoding.UTF8.GetBytes(password);

            // Generate additional entropy (will be used as the Initialization vector)
            byte[] entropy = new byte[20];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {
                rng.GetBytes(entropy);
            }

            byte[] ciphertext = ProtectedData.Protect(plaintext, entropy, DataProtectionScope.CurrentUser);
            Array.Clear(plaintext, 0, plaintext.Length);


            Settings.Default.Password = Convert.ToBase64String(ciphertext);
            Settings.Default.Entropy = Convert.ToBase64String(entropy);
            
        }

        public static SecureString ReadPassword() {
            SecureString result = new SecureString();

            if (Settings.Default.Password != "") {
                byte[] plaintext = ProtectedData.Unprotect(
                    Convert.FromBase64String(Settings.Default.Password),
                    Convert.FromBase64String(Settings.Default.Entropy),
                    DataProtectionScope.CurrentUser
                );


                foreach (char b in plaintext) {
                    result.AppendChar(Convert.ToChar(b));
                }
                Array.Clear(plaintext, 0, plaintext.Length);
            }

            result.MakeReadOnly();

            return result;
        }

        //http://weblogs.asp.net/jongalloway//encrypting-passwords-in-a-net-app-config-file
        public static string ToInsecureString(SecureString input) {
            string returnValue = string.Empty;
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
            try {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
            return returnValue;
        }
    }
}
