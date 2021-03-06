﻿// <auto-generated />
using System;
using MedicalApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedicalApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1");

            modelBuilder.Entity("MedicalApp.API.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool?>("Gender");

                    b.Property<string>("LastName");

                    b.Property<int?>("YearsOfExperience");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mohammedalbeltagi@gmail.com",
                            FirstName = "Mohammed",
                            Gender = false,
                            LastName = "Ahmed",
                            YearsOfExperience = 7
                        });
                });

            modelBuilder.Entity("MedicalApp.API.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BirthDate");

                    b.Property<int>("DoctorId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("MobilePhone");

                    b.HasKey("PatientId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("MedicalApp.API.Models.Patient", b =>
                {
                    b.HasOne("MedicalApp.API.Models.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
