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

            JobsComboBox.Items.Add("");
            JobsComboBox.Items.AddRange(ContactsData.instance.Jobs.ToArray());
            ClubsComboBox.Items.Add("");
            ClubsComboBox.Items.AddRange(ContactsData.instance.Clubs.ToArray());
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
                    MailAddress email = null;
                    try {
                        email = new MailAddress(EmailTextBox.Text);
                    }
                    catch (Exception e) { }

                    data.Name = NameTextBox.Text;
                    data.eMail = email;
                    data.Job = (JobsComboBox.SelectedItem == null) ? "" : (String)JobsComboBox.SelectedItem;
                    data.Club = (Club)ClubsComboBox.SelectedItem;
                }
                return data;
            }
            set {
                data = value;
                NameTextBox.Text = (data == null) ? "" : data.Name;
                EmailTextBox.Text = (data != null && data.eMail != null) ? data.eMail.Address : "";

                if (data != null ) {
                    int jobIndex = JobsComboBox.FindString(data.Job);
                    if (jobIndex != -1) {
                        JobsComboBox.SelectedIndex = jobIndex;
                    }
                }

                if (data != null && data.Club != null ) {
                    int clubIndex = ClubsComboBox.FindString(data.Club.ToString());
                    if (clubIndex != -1) {
                        ClubsComboBox.SelectedIndex = clubIndex;
                    }
                }
            }
        }
    }
}
