using MedicalApp.API.Dtos;
using MedicalApp.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalApp.API.Data
{
    public interface IMedicalRepository
    {
         Task<IEnumerable<DoctorDto>> GetDoctors();
         Task<DoctorDto> GetDoctorBId(int Id);
         Task<IEnumerable<PatientDto>> GetPatients(int DoctorId);
         Task<IEnumerable<PatientDto>> AddPatient(PatientDto patientDto);
         Task<IEnumerable<PatientDto>> DeletePatient(int id);
    }
}