using System;
using System.Collections.Generic;

namespace MedicalApp.API.Models
{       
    public class Doctor 
    {   
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string Email { get; set; }
        public Nullable<int> YearsOfExperience { get; set; }
        public Nullable<DateTime> BirthDate { get; set; }
        public ICollection<Patient> Patients { get; set; } 
    }
}