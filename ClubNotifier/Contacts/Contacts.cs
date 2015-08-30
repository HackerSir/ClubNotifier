using ClubNotifier.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Contacts {
    class ContactsData {
        public static ContactsData instance = new ContactsData();

        public List<Person> People;

        public List<Club> Clubs;

        public List<String> Jobs;

        private ContactsData() {
            try {
                People = JsonConvert.DeserializeObject<List<Person>>(Settings.Default.JSON_People);
                Clubs = JsonConvert.DeserializeObject<List<Club>>(Settings.Default.JSON_Clubs);
                Jobs = JsonConvert.DeserializeObject<List<String>>(Settings.Default.JSON_Jobs);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw e;
            }
        }

        public void SaveData() {
            Settings.Default.JSON_People = JsonConvert.SerializeObject(People);
            Settings.Default.JSON_Clubs = JsonConvert.SerializeObject(Clubs);
            Settings.Default.JSON_Jobs = JsonConvert.SerializeObject(Jobs);

            Settings.Default.Save();
        }
    }
}
