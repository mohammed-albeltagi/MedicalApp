using System.Collections.Generic;

namespace MedicalApp.API.Dtos
{
    public class DoctorPatientsDto
    {
        public DoctorDto Doctor { get; set; }
        public List<PatientDto> Patients { get; set; }
    }
}