﻿using ClubNotifier.Helper;
using ClubNotifier.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        private void sendTestMailButton_Click(object sender, EventArgs e) {
            NetworkCredential credentials = SendEmailHelper.createCredentials(loginUsernameTextBox.Text, loginPassewordTextBox.Text);

            // 若為null，代表使用者拒絕輸入密碼，則不送測試信
            if (credentials != null) {
                SendEmailHelper.SendMail(
                    generateTestMail(),
                    SmtpServerTextBox.Text,
                    Convert.ToInt32(serverPortTextBox.Text),
                    enableSSLCheckBox.Checked,
                    credentials
                );
            }
        }

        private MailMessage generateTestMail() {
            return new MailMessage(new MailAddress(mailTextBox.Text, userNameTextBox.Text), new MailAddress(mailTextBox.Text, userNameTextBox.Text))
            { 
                Subject = Application.ProductName + " 測試信",
                Body = @"如果你收到這封信，代表你的e-mail設定是正常的。"
            };
        }

    }
}
