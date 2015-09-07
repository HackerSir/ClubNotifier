using ClubNotifier.Contacts;
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

        }


    }
}
