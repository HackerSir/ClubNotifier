using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubNotifier.Helper {
    public partial class PasswordDialog : Form {
        public PasswordDialog() {
            InitializeComponent();
        }

        private SecureString password;

        public SecureString Password {
            get { return password; }
        }

        public String UserName {
            set { this.UsernameTextBox.Text = value; }
        }

        private void OKButton_Click(object sender, EventArgs e) {
            this.password = ProtectedDataHelper.ToSecureString(PasswordTextBox.Text);
        }

        private void PasswordDialog_FormClosed(object sender, FormClosedEventArgs e) {
            PasswordTextBox.Text = "";
        }
    }
}
