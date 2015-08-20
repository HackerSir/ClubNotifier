﻿using ClubNotifier.Properties;
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

        private Contacts() {
            People = JsonConvert.DeserializeObject<List<Person>>(Settings.Default.JSON_People);
            Clubs = JsonConvert.DeserializeObject<List<Club>>(Settings.Default.JSON_Clubs);
        }

        public void SaveData() {
            Settings.Default.JSON_People = JsonConvert.SerializeObject(People);
            Settings.Default.JSON_Clubs = JsonConvert.SerializeObject(Clubs);

            Settings.Default.Save();
        }
    }
}
