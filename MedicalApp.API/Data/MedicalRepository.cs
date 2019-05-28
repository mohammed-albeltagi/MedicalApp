using MedicalApp.API.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalApp.API.Models;
using System.Linq;
using MedicalApp.API.Dtos;
using Microsoft.EntityFrameworkCore;

namespace MedicalApp.API.Data
{
    public class MedicalRepository : IMedicalRepository
    {
        private readonly DataContext _context;
        
        public MedicalRepository(DataContext context)
        {
            _context = context;            
        }
        public async Task<IEnumerable<DoctorDto>> GetDoctors()
        {
            return await _context.Doctors.Select(a => new DoctorDto{
                DoctorId = a.DoctorId,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Gender = a.Gender,
                Email = a.Email,
                YearsOfExperience = a.YearsOfExperience,
                BirthDate = a.BirthDate,
            }).ToListAsync();
        }
        public async Task<DoctorDto> GetDoctorBId(int Id)
        {
            return await _context.Doctors.Where(a => a.DoctorId == Id).Select(a => new DoctorDto{
                DoctorId = a.DoctorId,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Gender = a.Gender,
                Email = a.Email,
                YearsOfExperience = a.YearsOfExperience,
                BirthDate = a.BirthDate,
            }).FirstOrDefaultAsync();
        }
        
        public async Task<IEnumerable<PatientDto>> GetPatients(int DoctorId)
        {
            return await _context.Patients.Where(a => a.DoctorId == DoctorId)
            .Select(a => new PatientDto{
                PatientId = a.PatientId,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Gender = a.Gender,
                Email = a.Email,
                BirthDate = a.BirthDate,
                DoctorId = a.DoctorId,
                MobilePhone = a.MobilePhone
            }).ToListAsync();
        }
        public async Task<IEnumerable<PatientDto>> AddPatient(PatientDto patientDto) {
            Patient patient = new Patient(){
            BirthDate = patientDto.BirthDate,
            DoctorId = patientDto.DoctorId,
            Email = patientDto.Email,
            FirstName = patientDto.FirstName,
            LastName = patientDto.LastName,
            Gender = patientDto.Gender,
            MobilePhone = patientDto.MobilePhone
            };
            await _context.Patients.AddAsync(patient);
            await _context.SaveChangesAsync();

            return await GetPatients(patientDto.DoctorId);
        }
        public async Task<IEnumerable<PatientDto>> DeletePatient(int id){
            var patient = await _context.Patients.FindAsync(id);
            int doctorId = patient.DoctorId;
            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
            return await GetPatients(doctorId); 
        }
    }
}