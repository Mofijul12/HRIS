import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Overtime } from '../models/overtime';

export interface Employee {
  employeeID: string; 
  employeeName: string;
}

@Injectable({
  providedIn: 'root'
})
export class OvertimeService {

  private empUrl = 'http://localhost:19243/api/EmployeeInformations';
  private apiUrl = 'http://localhost:19243/api/OverTimes';
    
      constructor(private http:HttpClient) { }
    
      getAll(): Observable<Overtime[]> {
        return this.http.get<Overtime[]>(this.apiUrl);
      }
    
        create(data: Overtime): Observable<Overtime> {
        return this.http.post<Overtime>('http://localhost:19243/api/OverTimes', data);
      }
    
        update(id: string, data: Overtime): Observable<Overtime> {
        return this.http.put<Overtime>(`${this.apiUrl}/${id}`, data);
      }
    
        delete(id: string): Observable<any> {
        return this.http.delete(`${this.apiUrl}/${id}`);
        }
  
        getEmployees(): Observable<Employee[]> {
          return this.http.get<Employee[]>(this.empUrl);
        }
}
