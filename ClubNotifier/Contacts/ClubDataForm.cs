using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubNotifier.Contacts {
    public partial class ClubDataForm : Form {
        public ClubDataForm() {
            InitializeComponent();
        }

        public ClubData getClubData() {
            return this.clubData1;
        }
    }
}
