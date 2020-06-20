﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cw11.Models;

namespace cw11.Migrations
{
    [DbContext(typeof(DoctorsDbContext))]
    [Migration("20200620090413_SeedDbWithPresMedData")]
    partial class SeedDbWithPresMedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cw11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "jan.nowak@gmail.com",
                            FirstName = "Jan",
                            LastName = "Nowak"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "anna.sa@gmail.com",
                            FirstName = "Anna",
                            LastName = "Sachs"
                        });
                });

            modelBuilder.Entity("cw11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 10,
                            Description = "use wisely",
                            Name = "Xylo",
                            Type = "gel"
                        },
                        new
                        {
                            IdMedicament = 11,
                            Description = "use wisely",
                            Name = "Paracetamol",
                            Type = "pills"
                        },
                        new
                        {
                            IdMedicament = 12,
                            Description = "use wisely",
                            Name = "Ibuprofen",
                            Type = "pills"
                        },
                        new
                        {
                            IdMedicament = 13,
                            Description = "use wisely",
                            Name = "Strepsils",
                            Type = "pills"
                        });
                });

            modelBuilder.Entity("cw11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            IdPatient = 101,
                            Birthdate = new DateTime(1995, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Pam",
                            LastName = "Beesely"
                        },
                        new
                        {
                            IdPatient = 102,
                            Birthdate = new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jim",
                            LastName = "Halpert"
                        });
                });

            modelBuilder.Entity("cw11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int?>("IdDoctorNavigationIdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.Property<int?>("IdPatientNavigationIdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("IdDoctorNavigationIdDoctor");

                    b.HasIndex("IdPatientNavigationIdPatient");

                    b.ToTable("Prescription");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 1,
                            IdPatient = 101
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 1,
                            IdPatient = 102
                        },
                        new
                        {
                            IdPrescription = 3,
                            Date = new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 3,
                            IdPatient = 102
                        });
                });

            modelBuilder.Entity("cw11.Models.PrescriptionMedicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription")
                        .HasName("Prescription_Medicament_pk");

                    b.HasIndex("IdPrescription");

                    b.ToTable("PrescriptionMedicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 10,
                            IdPrescription = 1,
                            Details = "no details",
                            Dose = 2
                        },
                        new
                        {
                            IdMedicament = 11,
                            IdPrescription = 1,
                            Details = "no details",
                            Dose = 2
                        },
                        new
                        {
                            IdMedicament = 12,
                            IdPrescription = 1,
                            Details = "no details",
                            Dose = 2
                        },
                        new
                        {
                            IdMedicament = 12,
                            IdPrescription = 2,
                            Details = "no details",
                            Dose = 2
                        },
                        new
                        {
                            IdMedicament = 13,
                            IdPrescription = 2,
                            Details = "no details",
                            Dose = 2
                        },
                        new
                        {
                            IdMedicament = 10,
                            IdPrescription = 3,
                            Details = "no details",
                            Dose = 1
                        });
                });

            modelBuilder.Entity("cw11.Models.Prescription", b =>
                {
                    b.HasOne("cw11.Models.Doctor", "IdDoctorNavigation")
                        .WithMany("Prescription")
                        .HasForeignKey("IdDoctorNavigationIdDoctor");

                    b.HasOne("cw11.Models.Patient", "IdPatientNavigation")
                        .WithMany("Prescription")
                        .HasForeignKey("IdPatientNavigationIdPatient");
                });

            modelBuilder.Entity("cw11.Models.PrescriptionMedicament", b =>
                {
                    b.HasOne("cw11.Models.Medicament", "IdMedicamentNavigation")
                        .WithMany("PrescriptionMedicament")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cw11.Models.Prescription", "IdPrescriptionNavigation")
                        .WithMany("PrescriptionMedicament")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}