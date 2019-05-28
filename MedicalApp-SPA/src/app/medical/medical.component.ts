import { MediaclOperationsService } from './../_services/mediaclOperations.service';
import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-medical',
  templateUrl: './medical.component.html',
  styleUrls: ['./medical.component.css']
})
export class MedicalComponent implements OnInit {
doctors: any;
patient: any = {};
  constructor(private http: HttpClient, private medicalService: MediaclOperationsService) { }

  ngOnInit() {
    this.getDoctors();
  }
  addPatient(doctorId) {
    this.patient.doctorId = doctorId;
    this.medicalService.addPatient(this.patient).subscribe(response => {
      this.patient = {};
      this.doctors.patients = response;
    }, error => {
       console.log(error);
    });
  }
  deletePatient(patientId) {
    this.medicalService.deletePatient(patientId).subscribe(response => {
      this.doctors.patients = response;
    }, error => {
       console.log(error);
    });
  }
getDoctors() {
 this.http.get('http://localhost:5000/api/medical/1').subscribe(response => {
   this.doctors = response;
 }, error => {
    console.log(error);
 });
}
}
