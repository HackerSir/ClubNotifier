using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
