﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubNotifier.Contacts {
    public partial class ContactsForm : Form {
        public ContactsForm() {
            InitializeComponent();
        }

        private void ContactsForm_Load(object sender, EventArgs e) {
            listBox1.Items.AddRange(Contacts.instance.Clubs.ToArray());
        }
    }
}
