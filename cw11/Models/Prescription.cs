using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class Prescription
    {
        public Prescription()
        {
            PrescriptionMedicament = new HashSet<PrescriptionMedicament>();
        }

        [Key]
        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }

        public virtual Doctor IdDoctorNavigation { get; set; }
        public virtual Patient IdPatientNavigation { get; set; }
        public virtual ICollection<PrescriptionMedicament> PrescriptionMedicament { get; set; }

    }
}
