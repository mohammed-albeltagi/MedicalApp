using System;
using System.Collections.Generic;

namespace MedicalApp.API.Dtos
{
    public class PatientDto
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public Nullable<DateTime> BirthDate { get; set; }

        public int DoctorId { get; set; }
        
    }
}