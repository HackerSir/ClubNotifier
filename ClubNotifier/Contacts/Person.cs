using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Contacts {
    public class Person {
        //聯絡人姓名
        public String Name { get; set; }
        //電子郵件
        [JsonConverter(typeof(EmailConverter))]
        public MailAddress eMail { get; set; }
        //職位
        public String Job { get; set; }
        //所屬社團
        public Club Club { get; set; }

        public override string ToString() {
            return Name;
        }

        public override bool Equals(object obj) {
            var person = obj as Person;

            if (person == null) {
                return false;
            }

            if (!Name.Equals(person.Name)) {
                return false;
            }

            if (eMail == null) {
                if (person.eMail != null) {
                    return false;
                }
            }
            else if (!eMail.Equals(person.eMail)) {
                return false;
            }

            if (!Job.Equals(person.Job)) {
                return false;
            }

            if (Club == null) {
                if (person.Club != null) {
                    return false;
                }
            }
            else if (!Club.Equals(person.Club)) {
                return false;
            }

            return true;
        }

        public override int GetHashCode() {
            int hash = 13;
            if (Name != null) hash = (hash * 7) + Name.GetHashCode();
            if (eMail != null) hash = (hash * 7) + eMail.GetHashCode();
            if (Job != null) hash = (hash * 7) + Job.GetHashCode();
            if (Club != null) hash = (hash * 7) + Club.GetHashCode();

            return hash;
        }
    }
}
