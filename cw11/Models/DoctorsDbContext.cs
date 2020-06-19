using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class DoctorsDbContext : DbContext
    {
        public DbSet<Medicament> Medicament { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Prescription> Prescription { get; set; }
        public virtual DbSet<PrescriptionMedicament> PrescriptionMedicament { get; set; }

        public DoctorsDbContext()
        {

        }

        public DoctorsDbContext(DbContextOptions options)
            : base(options)
        {

        }


    }
}
