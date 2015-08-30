using ClubNotifier.Helper;
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
            PersonListBox.Items.AddRange(ContactsData.instance.People.ToArray());
            ClubListBox.Items.AddRange(ContactsData.instance.Clubs.ToArray());
            JobListBox.Items.AddRange(ContactsData.instance.Jobs.ToArray());
        }

        private void ClubListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (ClubListBox.SelectedIndex != -1) {
                EditClubButton.Enabled = RemoveClubButton.Enabled = true;

                this.clubData1.Data = (Club) ClubListBox.SelectedItem;
            }
            else {
                EditClubButton.Enabled = RemoveClubButton.Enabled = false;

                this.clubData1.Data = null;
            }
        }

        private void AddClubButton_Click(object sender, EventArgs e) {
            var newClubForm = new ClubDataForm();

            if (newClubForm.ShowDialog() == DialogResult.OK) {
                ClubListBox.Items.Add(newClubForm.getClubData().Data);
            }
        }

        private void EditClubButton_Click(object sender, EventArgs e) {
            if (ClubListBox.SelectedIndex != -1) {
                var newClubForm = new ClubDataForm();
                newClubForm.getClubData().Data = (Club) ClubListBox.SelectedItem;

                if (newClubForm.ShowDialog() == DialogResult.OK) {
                    ClubListBox.Items[ClubListBox.SelectedIndex] = this.clubData1.Data = newClubForm.getClubData().Data;
                }
            }
        }

        private void RemoveClubButton_Click(object sender, EventArgs e) {
            if (ClubListBox.SelectedIndex != -1) {
                if (MessageBox.Show(String.Format("你確定要刪除 {0} 嗎？", ClubListBox.SelectedItem), "確認", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    ClubListBox.Items.RemoveAt(ClubListBox.SelectedIndex);
                }
            }
        }

        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e) {
            SaveData();
        }

        private void AddPersonButton_Click(object sender, EventArgs e) {
            var newPersonDataForm = new PersonDataForm();

            if (newPersonDataForm.ShowDialog() == DialogResult.OK) {
                PersonListBox.Items.Add(newPersonDataForm.getPersonData().Person);
            }
        }

        private void EditPersonButton_Click(object sender, EventArgs e) {
            if (PersonListBox.SelectedIndex != -1) {
                var newPersonForm = new PersonDataForm();
                newPersonForm.getPersonData().Person = (Person)PersonListBox.SelectedItem;

                if (newPersonForm.ShowDialog() == DialogResult.OK) {
                    PersonListBox.Items[PersonListBox.SelectedIndex] = this.personData1.Person = newPersonForm.getPersonData().Person;
                }
            }
        }

        private void RemovePersonButton_Click(object sender, EventArgs e) {
            if (PersonListBox.SelectedIndex != -1) {
                if (MessageBox.Show(String.Format("你確定要刪除這個聯絡人 '{0}' 嗎？", PersonListBox.SelectedItem), "確認", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    PersonListBox.Items.RemoveAt(PersonListBox.SelectedIndex);
                }
            }
        }

        private void PersonListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (PersonListBox.SelectedIndex != -1) {
                EditPersonButton.Enabled = RemovePersonButton.Enabled = true;

                this.personData1.Person = (Person)PersonListBox.SelectedItem;
            }
            else {
                EditPersonButton.Enabled = RemovePersonButton.Enabled = false;

                this.personData1.Person = null;
            }
        }

        private void ContactsForm_FormClosing(object sender, FormClosingEventArgs e) {
            SaveData();
        }

        private void SaveData() {
            //http://stackoverflow.com/questions/1565504/most-succinct-way-to-convert-listbox-items-to-a-generic-list
            ContactsData.instance.People = PersonListBox.Items.Cast<Person>().ToList();
            ContactsData.instance.Clubs = ClubListBox.Items.Cast<Club>().ToList();
            ContactsData.instance.Jobs = JobListBox.Items.Cast<String>().ToList();

            ContactsData.instance.SaveData();
        }

        private void AddJobButton_Click(object sender, EventArgs e) {
            var textForm = new TextBoxDialog();
            if (textForm.ShowDialog() == DialogResult.OK) {
                String JobName = textForm.DataTextBox.Text;
                if (JobName != "") {
                    //TODO: 重複檢查
                    JobListBox.Items.Add(JobName);
                }
            }
        }

        private void EditJobButton_Click(object sender, EventArgs e) {
            if (JobListBox.SelectedIndex != -1) {
                var textForm = new TextBoxDialog();
                textForm.DataTextBox.Text = (String)JobListBox.SelectedItem;

                if (textForm.ShowDialog() == DialogResult.OK) {
                    String JobName = textForm.DataTextBox.Text;
                    if (JobName != "") {
                        JobListBox.Items[JobListBox.SelectedIndex] = JobName;
                    }
                }
            }
        }

        private void RemoveJobButton_Click(object sender, EventArgs e) {
            if (JobListBox.SelectedIndex != -1) {
                if (MessageBox.Show(String.Format("你確定要刪除這個職位 '{0}' 嗎？", JobListBox.SelectedItem), "確認", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    JobListBox.Items.RemoveAt(JobListBox.SelectedIndex);
                }
            }
        }

        private void JobListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (JobListBox.SelectedIndex != -1) {
                EditJobButton.Enabled = RemoveJobButton.Enabled = true;
            }
            else {
                EditJobButton.Enabled = RemoveJobButton.Enabled = false;
            }
        }
    }
}
