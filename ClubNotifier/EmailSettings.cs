using ClubNotifier.Helper;
using ClubNotifier.Properties;
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

namespace ClubNotifier {
    public partial class EmailSettings : Form {
            
        public EmailSettings() {
            InitializeComponent();
        }

        private void EmailSettings_Load(object sender, EventArgs e) {
            Settings.Default.Reload();

            using (SecureString password = ProtectedDataHelper.ReadPassword()) {
                loginPassewordTextBox.Text = ProtectedDataHelper.ToInsecureString(password);
            }

            updateLoginPasswordTextBoxState();
        }

        private void OKButton_Click(object sender, EventArgs e) {
            ProtectedDataHelper.SavePassword(loginPassewordTextBox.Text);

            Settings.Default.Save();
        }

        private void noSavePasswordCheckBox_CheckedChanged(object sender, EventArgs e) {
            updateLoginPasswordTextBoxState();
        }

        private void updateLoginPasswordTextBoxState() {
            loginPassewordTextBox.Enabled = !noSavePasswordCheckBox.Checked;
            if (!loginPassewordTextBox.Enabled) {
                loginPassewordTextBox.Text = "";
            }
        }

        private void EmailSettings_FormClosed(object sender, FormClosedEventArgs e) {
            loginPassewordTextBox.Text = "";
        }

    }
}
