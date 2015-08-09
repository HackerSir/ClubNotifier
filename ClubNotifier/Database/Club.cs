using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubNotifier.Database {
    class Club {
        [Key]
        public string ClubCode { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
