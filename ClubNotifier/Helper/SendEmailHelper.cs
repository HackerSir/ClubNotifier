using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubNotifier.Helper {
    class SendEmailHelper {

        public static void SendMailUseSettings(MailMessage mail) {

        }

        public static void SendMail(MailMessage mail, string smtpServer, int smtpSeverPort, Boolean enableSsl, NetworkCredential credentials) {
            SmtpClient client = new SmtpClient(smtpServer, smtpSeverPort);
            client.EnableSsl = enableSsl;
            client.Credentials = credentials;

            try {
                client.Send(mail);
                MessageBox.Show("測試信成功寄出。");
            }
            catch (Exception e) {
                //TODO: 更多說明，幫助使用者排除狀況
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 建立身分認證用的 NetworkCredential，若回傳 null，代表使用者不輸入密碼
        /// </summary>
        /// <param name="username">使用者名稱</param>
        /// <param name="password">密碼，若為空字串，會開啟視窗詢問</param>
        /// <returns></returns>
        public static NetworkCredential createCredentials(string username, string password) {
            if (password == "") {
                //使用者沒有設定密碼，詢問使用者密碼
                PasswordDialog dialog = new PasswordDialog()
                {
                    UserName = username,
                };

                if (dialog.ShowDialog() == DialogResult.OK) {
                    return new NetworkCredential(username, dialog.Password);
                }
                else {
                    return null;
                }
            }
            else {
                return new NetworkCredential(username, ProtectedDataHelper.ToSecureString(password));
            }
        }

    }
}
