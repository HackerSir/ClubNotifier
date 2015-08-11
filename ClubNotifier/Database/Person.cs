using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Database {
    class Person {

        public int PersonId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Email> emails { get; set; }
    }
}
