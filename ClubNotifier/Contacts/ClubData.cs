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
    }
}
