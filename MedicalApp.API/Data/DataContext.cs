using MedicalApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MedicalApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
            .HasData(new Doctor 
            {  
                DoctorId = 1,
                FirstName = "Mohammed",
                LastName = "Ahmed",
                Gender = false,
                Email = "mohammedalbeltagi@gmail.com",
                YearsOfExperience = 7,
                BirthDate = DateTime.Parse("1990-06-27 00:00:00"),
            });
        }
    }
}