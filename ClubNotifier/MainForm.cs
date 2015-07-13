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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void Email設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            new EmailSettings().ShowDialog();
        }

        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutBox().ShowDialog();
        }

    }
}
