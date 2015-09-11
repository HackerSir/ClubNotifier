using ClubNotifier.Contacts;
using ClubNotifier.Helper;
using ClubNotifier.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubNotifier {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void SettingsToolStripButton_Click(object sender, EventArgs e) {
            new EmailSettings().ShowDialog();
        }

        private void AboutToolStripButton_Click(object sender, EventArgs e) {
            new AboutBox().ShowDialog();
        }

        private void ContactToolStripButton_Click(object sender, EventArgs e) {
            new ContactsForm().ShowDialog();
        }

        private void openContactSelectForm(ListBox listbox) {
            var selectForm = new ContactSelectForm(listbox.Items.Cast<MailAddress>().ToList());

            if (selectForm.ShowDialog() == DialogResult.Yes) {
                listbox.Items.Clear();
                listbox.Items.AddRange(selectForm.Emails.ToArray());
            }
        }

        private void mailToButton_Click(object sender, EventArgs e) {
            openContactSelectForm(mailToListBox);
        }

        private void mailCCButton_Click(object sender, EventArgs e) {
            openContactSelectForm(mailCCListBox);
        }

        private void mailBccButton_Click(object sender, EventArgs e) {
            openContactSelectForm(mailBccListBox);
        }

        private void attachmentsButton_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                attachmentsListBox.Items.AddRange(openFileDialog1.FileNames);
            }
        }

        private void sendEmailToolStripButton_Click(object sender, EventArgs e) {
            var msg = new MailMessage();

            msg.From = new MailAddress(Settings.Default.UesrEmail, Settings.Default.UserName);
            var to = msg.To;
            foreach (MailAddress mail in mailToListBox.Items) {
                to.Add(mail);
            }
            var cc = msg.CC;
            foreach (MailAddress mail in mailCCListBox.Items) {
                cc.Add(mail);
            }
            var bcc = msg.Bcc;
            foreach (MailAddress mail in mailBccListBox.Items) {
                bcc.Add(mail);
            }
            var attachments = msg.Attachments;
            foreach (string filename in attachmentsListBox.Items) {
                attachments.Add(new Attachment(filename));
            }

            msg.Subject = subjectTextBox.Text;
            msg.Body = mailBodyTextBox.Text;

            SendEmailHelper.SendMailUseSettings(msg);
        }

    }
}
