using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public partial class DoctorsDbContext : DbContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrescriptionMedicament>(entity =>
            {
                entity.HasKey(e => new { e.IdMedicament, e.IdPrescription })
                    .HasName("Prescription_Medicament_pk");
            });

            OnModelCreatingPartial(modelBuilder);

            seedDatabaseWithSampleData(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        private void seedDatabaseWithSampleData(ModelBuilder modelBuilder)
        {
            var doctors = new List<Doctor>();
            doctors.Add(new Models.Doctor { IdDoctor = 1, FirstName = "Jan", LastName = "Nowak", Email = "jan.nowak@gmail.com"});
            doctors.Add(new Models.Doctor { IdDoctor = 2, FirstName = "Anna", LastName = "Sachs", Email = "anna.sa@gmail.com"});

            modelBuilder.Entity<Doctor>()
                .HasData(doctors);
        }



    }
}
