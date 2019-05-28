using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalApp.API.Data;
using MedicalApp.API.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicalApp.API.Controllers
{
    [Route("api/[controller]")]
    public class MedicalController : Controller
    {
        private readonly IMedicalRepository _medicalRepository;
        
        public MedicalController(IMedicalRepository medicalRepository)
        {
            _medicalRepository = medicalRepository;
        }
        // GET api/Medical
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var doc = await _medicalRepository.GetDoctors();
            return Ok(doc);
        }

        // GET api/Medical/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var doctor = await _medicalRepository.GetDoctorBId(id);
            var patients = await _medicalRepository.GetPatients(doctor.DoctorId);
            DoctorPatientsDto dt = new DoctorPatientsDto();
            dt.Patients = patients.ToList();
            dt.Doctor = doctor;
            return Ok(dt);
        }

        // POST api/Medical
        [HttpPost("add")]
        public async Task<IActionResult> Post([FromBody]PatientDto patientDto)
        {
            
            var patients = await _medicalRepository.AddPatient(patientDto);
            return Ok(patients);
            
        }


        // DELETE api/Medical/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var patients = await _medicalRepository.DeletePatient(id);
            return Ok(patients);
        }
    }
}
