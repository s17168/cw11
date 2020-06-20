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

            var patients = new List<Patient>();
            patients.Add(new Models.Patient { IdPatient = 101, FirstName = "Pam", LastName = "Beesely", Birthdate = new DateTime(1995, 3, 16)});
            patients.Add(new Models.Patient { IdPatient = 102, FirstName = "Jim", LastName = "Halpert", Birthdate = new DateTime(1995, 3, 15)});

            var medicamets = new List<Medicament>();
            medicamets.Add(new Models.Medicament { IdMedicament = 10, Name = "Xylo", Description = "use wisely", Type = "gel"});
            medicamets.Add(new Models.Medicament { IdMedicament = 11, Name = "Paracetamol", Description = "use wisely", Type = "pills"});
            medicamets.Add(new Models.Medicament { IdMedicament = 12, Name = "Ibuprofen", Description = "use wisely", Type = "pills"});
            medicamets.Add(new Models.Medicament { IdMedicament = 13, Name = "Strepsils", Description = "use wisely", Type = "pills"});

            var prescriptions = new List<Prescription>();
            prescriptions.Add(new Models.Prescription { IdPrescription = 1, IdPatient = 101, IdDoctor = 1, Date = new DateTime(2020, 1, 1)});
            prescriptions.Add(new Models.Prescription { IdPrescription = 2, IdPatient = 102, IdDoctor = 1, Date = new DateTime(2020, 1, 10)});
            prescriptions.Add(new Models.Prescription { IdPrescription = 3, IdPatient = 102, IdDoctor = 3, Date = new DateTime(2020, 1, 12)});

            var presMed = new List<PrescriptionMedicament>();
            presMed.Add(new Models.PrescriptionMedicament { IdPrescription = 1, IdMedicament = 10, Dose = 2, Details = "no details"});
            presMed.Add(new Models.PrescriptionMedicament { IdPrescription = 1, IdMedicament = 11, Dose = 2, Details = "no details"});
            presMed.Add(new Models.PrescriptionMedicament { IdPrescription = 1, IdMedicament = 12, Dose = 2, Details = "no details"});
            
            presMed.Add(new Models.PrescriptionMedicament { IdPrescription = 2, IdMedicament = 12, Dose = 2, Details = "no details"});
            presMed.Add(new Models.PrescriptionMedicament { IdPrescription = 2, IdMedicament = 13, Dose = 2, Details = "no details"});
            
            presMed.Add(new Models.PrescriptionMedicament { IdPrescription = 3, IdMedicament = 10, Dose = 1, Details = "no details"});

            modelBuilder.Entity<Doctor>()
                .HasData(doctors);

            modelBuilder.Entity<Patient>()
                .HasData(patients);

            modelBuilder.Entity<Medicament>()
                .HasData(medicamets);

            modelBuilder.Entity<Prescription>()
               .HasData(prescriptions);
        }



    }
}
