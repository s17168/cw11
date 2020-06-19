using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class PrescriptionMedicament
    {
        [Key]
        public int IdMedicament { get; set; }
        [Key]
        public int IdPrescription { get; set; }
        public int? Dose { get; set; } // ? pozwala na wartosc null
        [MaxLength(100)]
        public string Details { get; set; }

        public virtual Medicament IdMedicamentNavigation { get; set; }
        public virtual Prescription IdPrescriptionNavigation { get; set; }
    }
}
