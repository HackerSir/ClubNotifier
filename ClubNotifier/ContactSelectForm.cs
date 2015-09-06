using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubNotifier.Contacts;
using System.Net.Mail;

namespace ClubNotifier {
    public partial class ContactSelectForm : Form {
        public ContactSelectForm(List<MailAddress> selectedEmails = null) {
            InitializeComponent();

            NameColumn.DataPropertyName = "Name";
            EmailColumn.DataPropertyName = "eMail";
            ClubColumn.DataPropertyName = "Club";
            JobColumn.DataPropertyName = "Job";

            if (selectedEmails != null) {
                emails = selectedEmails;
            }
        }

        private void ContactSelectForm_Load(object sender, EventArgs e) {
            var perpleSource = new BindingSource();

            foreach (var person in ContactsData.instance.People) {
                perpleSource.Add(person);
            }

            dataGridView1.DataSource = perpleSource;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            var rows = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(r => emails.FindIndex(email => email.Address.Equals(((MailAddress)(r.Cells[EmailColumn.Name].Value)).Address)) != -1);

            foreach (var row in rows) {
                row.Cells[SelectedColumn.Name].Value = true;
            }
        }

        private List<MailAddress> emails = new List<MailAddress>();
        public List<MailAddress> Emails {
            get {
                return emails;
            }
        }

        private void YesButton_Click(object sender, EventArgs e) {
            emails.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                Object val = row.Cells[SelectedColumn.Name].Value;
                if (val != null && (Boolean)val) {
                    Object emailVal = row.Cells[EmailColumn.Name].Value;

                    if (emailVal != null) {
                        MailAddress mail = (MailAddress)emailVal;

                        Object nameVal = row.Cells[NameColumn.Name].Value;
                        if (nameVal != null) {
                            mail = new MailAddress(mail.Address, (String)nameVal);
                        }

                        emails.Add(mail);
                    }
                }
            }
        }
    }
}
