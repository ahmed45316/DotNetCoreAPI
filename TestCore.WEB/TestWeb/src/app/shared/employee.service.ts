import { Injectable } from '@angular/core';
import { Employee } from './employee.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  formData  : Employee;
  list : Employee[];
  readonly rootURL ="http://localhost/TestCore.API/Employee/"

  constructor(private http : HttpClient) { }

  postEmployee(formData : Employee){
   return this.http.post(`${this.rootURL}Create`,formData);  
  }

  refreshList(){
    this.http.get<Employee[]>(`${this.rootURL}GetAll`).subscribe((res)=>this.list=res as Employee[]);
     //this.http.get<Employee[]>(`${this.rootURL}GetAll`);
    // .toPromise().then(res => this.list = res as Employee[]);
  }

  putEmployee(formData : Employee){
    return this.http.post(`${this.rootURL}Update`,formData);
     
   }

   deleteEmployee(id : string){
     console.log(this.rootURL+`Remove/${id}`);
    return this.http.delete(`${this.rootURL}Remove/${id}`);
   }
}
