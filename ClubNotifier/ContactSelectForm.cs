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
    }
}
