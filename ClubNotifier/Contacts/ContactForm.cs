using ClubNotifier.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubNotifier.Contacts {
    public partial class ContactForm : Form {

        ClubNotifierContext context;

        public ContactForm() {
            InitializeComponent();
        }

        private void ContactForm_Load(object sender, EventArgs e) {
            context = new ClubNotifierContext();

            context.Clubs.Load();
            context.ClubGroup.Load();
            context.Jobs.Load();

            this.clubBindingSource.DataSource = context.Clubs.Local.ToBindingList();
            this.clubGroupBindingSource.DataSource = context.ClubGroup.Local.ToBindingList();
            this.jobBindingSource.DataSource = context.Jobs.Local.ToBindingList();
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e) {
            this.Validate();

            this.context.SaveChanges();

            this.clubDataGridView.Refresh();
        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e) {
            this.context.Dispose(); 
        }

    }
}
