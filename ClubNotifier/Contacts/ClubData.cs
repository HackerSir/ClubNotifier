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
                return ClubNameTextBox.ReadOnly;
            }
            set {
                ClubNameTextBox.ReadOnly = ClubCodeTextBox.ReadOnly = value;
            }
        }

        private Club data = null;
        public Club Data {
            get {
                if (data == null) {
                    data = new Club()
                    {
                        ClubCode = ClubCodeTextBox.Text,
                        Name = ClubNameTextBox.Text,
                    };
                }
                else {
                    data.ClubCode = ClubCodeTextBox.Text;
                    data.Name = ClubNameTextBox.Text;
                }
                return data;
            }
            set {
                data = value;
                ClubCodeTextBox.Text = (data == null) ? "" : data.ClubCode;
                ClubNameTextBox.Text = (data == null) ? "" : data.Name;
            }
        }
    }
}
