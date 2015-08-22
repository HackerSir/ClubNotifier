using ClubNotifier.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Contacts {
    class Contacts {
        public static Contacts instance = new Contacts();

        public List<Person> People;

        public List<Club> Clubs;

        public List<String> Jobs = new List<String>();

        private Contacts() {
            People = JsonConvert.DeserializeObject<List<Person>>(Settings.Default.JSON_People);
            Clubs = JsonConvert.DeserializeObject<List<Club>>(Settings.Default.JSON_Clubs);

            updateJobList();
        }

        public void SaveData() {
            Settings.Default.JSON_People = JsonConvert.SerializeObject(People);
            Settings.Default.JSON_Clubs = JsonConvert.SerializeObject(Clubs);

            Settings.Default.Save();

            updateJobList();
        }

        private void updateJobList() {
            HashSet<String> JobSet = new HashSet<string>();
            foreach (var person in People) {
                JobSet.Add(person.Job);
            }
            Jobs.Clear();
            Jobs.AddRange(JobSet.ToArray());
        }
    }
}
