import { Injectable } from '@angular/core';
import { Employee } from './employee.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  formData  : Employee;
  list : Employee[];
  readonly rootURL ="https://localhost:44371/Employee/"

  constructor(private http : HttpClient) { }

  postEmployee(formData : Employee){
   return this.http.post(`${this.rootURL}Create`,formData);  
  }

  refreshList(){
    this.http.get(`${this.rootURL}GetAll`)
    .toPromise().then(res => this.list = res as Employee[]);
  }

  putEmployee(formData : Employee){
    return this.http.post(`${this.rootURL}Update`,formData);
     
   }

   deleteEmployee(id : string){
     console.log(this.rootURL+`Remove/${id}`);
    return this.http.delete(`${this.rootURL}Remove/${id}`);
   }
}
