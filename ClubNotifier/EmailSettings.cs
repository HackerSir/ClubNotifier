using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubNotifier {
    public partial class EmailSettings : Form {
        public EmailSettings() {
            InitializeComponent();
        }

        private void EmailSettings_Load(object sender, EventArgs e) {
            ClubNotifier.Properties.Settings.Default.Reload();
            updateLoginPasswordTextBoxState();
        }

        private void OKButton_Click(object sender, EventArgs e) {
            ClubNotifier.Properties.Settings.Default.Save();
        }

        private void noSavePasswordCheckBox_CheckedChanged(object sender, EventArgs e) {
            updateLoginPasswordTextBoxState();
        }

        private void updateLoginPasswordTextBoxState() {
            loginPasseordTextBox.Enabled = !noSavePasswordCheckBox.Checked;
            if (!loginPasseordTextBox.Enabled) {
                loginPasseordTextBox.Text = "";
            }
        }

    }
}
