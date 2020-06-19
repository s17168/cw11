using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class Patient
    {
        public Patient()
        {
            Prescription = new HashSet<Prescription>();
        }

        [Key]
        public int IdPatient { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}
