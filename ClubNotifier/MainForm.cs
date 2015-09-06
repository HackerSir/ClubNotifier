﻿using ClubNotifier.Contacts;
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

        private void mailToButton_Click(object sender, EventArgs e) {
            var selectForm = new ContactSelectForm(mailToListBox.Items.Cast<MailAddress>().ToList());

            if (selectForm.ShowDialog() == DialogResult.Yes) {
                mailToListBox.Items.Clear();
                mailToListBox.Items.AddRange(selectForm.Emails.ToArray());
            }
        }

    }
}
