using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubNotifier.Helper {
    public partial class WaitDialog : Form {

        private SmtpClient client;
        private MailMessage mail;

        private Exception exception;

        public Exception Exception {
            get { return exception; }
        }

        public WaitDialog() {
            InitializeComponent();
        }

        public WaitDialog(SmtpClient client, MailMessage mail) {
            InitializeComponent();

            this.client = client;
            this.mail = mail;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            if (client != null) {
                client.SendAsyncCancel();
            }
        }

        private void OnSendCompletedHandler(object sender, AsyncCompletedEventArgs e) {
            if (e.Error != null) {
                this.DialogResult = DialogResult.Abort;
                this.exception = e.Error;
            }
            else if (!e.Cancelled) {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void WaitDialog_Shown(object sender, EventArgs e) {
            if (this.client != null && this.mail != null) {
                client.SendCompleted += this.OnSendCompletedHandler;
                try {
                    client.SendMailAsync(mail);
                }
                catch (Exception exception) {
                    this.DialogResult = DialogResult.Abort;
                    this.exception = exception;
                    this.Close();
                }
            }
        }
    }
}
