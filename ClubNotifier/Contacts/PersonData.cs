using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace ClubNotifier.Contacts {
    public partial class PersonData : UserControl {

        public PersonData() {
            InitializeComponent();
        }

        private void PersonData_Load(object sender, EventArgs e) {
            JobsComboBox.Items.AddRange(Contacts.instance.Jobs.ToArray());
            ClubsComboBox.Items.AddRange(Contacts.instance.Clubs.ToArray());
        }

        public Boolean isDataReadOnly {
            get {
                return NameTextBox.ReadOnly;
            }
            set {
                NameTextBox.ReadOnly = EmailTextBox.ReadOnly = value;
                JobsComboBox.Enabled = ClubsComboBox.Enabled = !value;
            }
        }

        private Person data = null;
        public Person Person {
            get {
                if (data == null) {
                    MailAddress email = null;
                    try {
                        email = new MailAddress(EmailTextBox.Text);
                    }
                    catch (Exception e) { }

                    data = new Person()
                    {
                        Name = NameTextBox.Text,
                        eMail = email,
                        Job = (JobsComboBox.SelectedItem == null) ? "" : (String)JobsComboBox.SelectedItem,
                        Club = (Club)ClubsComboBox.SelectedItem,
                    };
                }
                else {
                    data.Name = NameTextBox.Text;
                    data.eMail = new MailAddress(EmailTextBox.Text);
                    data.Job = (JobsComboBox.SelectedItem == null) ? "" : (String)JobsComboBox.SelectedItem;
                    data.Club = (Club)ClubsComboBox.SelectedItem;
                }
                return data;
            }
            set {
                data = value;
                NameTextBox.Text = (data == null) ? "" : data.Name;
                EmailTextBox.Text = (data == null) ? "" : data.eMail.Address;
                JobsComboBox.SelectedItem = (data == null) ? null : data.Job;
                ClubsComboBox.SelectedItem = (data == null) ? null : data.Club;
            }
        }
    }
}
