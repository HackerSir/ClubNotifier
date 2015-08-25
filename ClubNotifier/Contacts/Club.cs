using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Contacts  {
    public class Club {
        //社團代號
        public String ClubCode { get; set; }
        //社團名稱
        public String Name { get; set; }

        public Club() { }

        public override string ToString() {
            return String.Format("({0} {1})", ClubCode, Name);
        }

        public override bool Equals(Object obj) {
            Club clubObj = obj as Club;
            if (clubObj == null)
                return false;
            else
                return this.ClubCode == clubObj.ClubCode && this.Name == clubObj.Name;
        }
    }
}
