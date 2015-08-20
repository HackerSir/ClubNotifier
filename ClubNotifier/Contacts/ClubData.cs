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
    public partial class ClubData : UserControl {
        public ClubData() {
            InitializeComponent();
        }

        public Boolean isDataReadOnly {
            get {
                return textBox1.ReadOnly;
            }
            set {
                textBox1.ReadOnly = textBox2.ReadOnly = value;
            }
        }

        private Club data = new Club();
        public Club Data {
            get {
                return data;
            }
            set {
                data = value;
                textBox2.Text = (data == null) ? "" : data.ClubCode;
                textBox1.Text = (data == null) ? "" : data.Name;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            if (data != null) {
                data.ClubCode = textBox2.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (data != null) {
                data.Name = textBox1.Text;
            }
        }
    }
}
