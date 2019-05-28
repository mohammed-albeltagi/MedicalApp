import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MediaclOperationsService {
baseURL = 'http://localhost:5000/api/medical/';
constructor(private http: HttpClient) { }

addPatient(patient: any) {
  return this.http.post(this.baseURL + 'add', patient);
  }
  deletePatient(patientId: any) {
    return this.http.delete(this.baseURL + patientId);
  }
}
