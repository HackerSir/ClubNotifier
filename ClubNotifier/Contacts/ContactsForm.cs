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
    public partial class ContactsForm : Form {
        public ContactsForm() {
            InitializeComponent();
        }

        private void ContactsForm_Load(object sender, EventArgs e) {
            listBox1.Items.AddRange(Contacts.instance.Clubs.ToArray());
        }

        private void button1_Click(object sender, EventArgs e) {
            var newClubForm = new ClubDataForm();

            if (newClubForm.ShowDialog() == DialogResult.OK) {
                listBox1.Items.Add(newClubForm.getClubData().Data);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                EditClubButton.Enabled = RemoveClubButton.Enabled = true;

                this.clubData1.Data = (Club) listBox1.SelectedItem;
            }
            else {
                EditClubButton.Enabled = RemoveClubButton.Enabled = false;

                this.clubData1.Data = null;
            }
        }

        private void EditClubButton_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                var newClubForm = new ClubDataForm();
                newClubForm.getClubData().Data = (Club) listBox1.SelectedItem;

                if (newClubForm.ShowDialog() == DialogResult.OK) {
                    listBox1.Items[listBox1.SelectedIndex] = newClubForm.getClubData().Data;
                }
            }
        }

        private void RemoveClubButton_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                if (MessageBox.Show(String.Format("你確定要刪除 {0} 嗎？", listBox1.SelectedItem), "確認", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
        }

        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e) {
            //http://stackoverflow.com/questions/1565504/most-succinct-way-to-convert-listbox-items-to-a-generic-list
            Contacts.instance.Clubs = listBox1.Items.Cast<Club>().ToList();

            Contacts.instance.SaveData();
        }

    }
}
