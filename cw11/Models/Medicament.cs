using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class Medicament
    {
        public Medicament()
        {
            PrescriptionMedicament = new HashSet<PrescriptionMedicament>();
        }

        [Key]
        //[Required] dla NOT NULL
        public int IdMedicament { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [MaxLength(100)]
        public string Type { get; set; }

        public virtual ICollection<PrescriptionMedicament> PrescriptionMedicament { get; set; }

    }
}
