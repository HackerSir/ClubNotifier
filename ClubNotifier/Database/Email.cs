using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Database {
    class Email {

        public int EmailId { get; set; }

        [Required]
        public String EmailAddress { get; set; }

        [Required]
        public Person Person { get; set; }

    }
}
