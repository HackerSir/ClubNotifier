using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Contacts {
    class Person {
        //聯絡人姓名
        public String Name { get; set; }
        //電子郵件
        public MailAddress eMail { get; set; }
        //職位
        public String Job { get; set; }
        //所屬社團
        public Club Club { get; set; }
    }
}
