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
        public ContactSelectForm() {
            InitializeComponent();

            NameColumn.DataPropertyName = "Name";
            EmailColumn.DataPropertyName = "eMail";
            ClubColumn.DataPropertyName = "Club";
            JobColumn.DataPropertyName = "Job";
        }

        private void ContactSelectForm_Load(object sender, EventArgs e) {
            var perpleSource = new BindingSource();

            foreach (var person in ContactsData.instance.People) {
                perpleSource.Add(person);
            }

            dataGridView1.DataSource = perpleSource;
        }

        private List<MailAddress> emails = new List<MailAddress>();
        public List<MailAddress> Emails {
            get {
                return emails;
            }
        }

        private void YesButton_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                Object val = row.Cells[SelectedColumn.Name].Value;
                if (val != null && (Boolean)val) {
                    //TODO: Add Name
                    Object emailVal = row.Cells[EmailColumn.Name].Value;
                    if (emailVal != null) {
                        emails.Add(new MailAddress((String)emailVal));
                    }
                }
            }
        }
    }
}
