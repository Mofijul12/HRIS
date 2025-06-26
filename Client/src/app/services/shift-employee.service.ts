import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ShiftEmployee } from '../models/shift-employee';

export interface DateWiseOfficeTime{
  dateWiseOfficeTimeID:string
}

@Injectable({
  providedIn: 'root'
})
export class ShiftEmployeeService {

  private apiUrl = 'http://localhost:19243/api/ShiftEmployees';
  private DtwiseUrl = 'http://localhost:19243/api/DateWiseOfficeTimes';
  
    constructor(private http:HttpClient) { }
  
    getAll(): Observable<ShiftEmployee[]> {
      return this.http.get<ShiftEmployee[]>(this.apiUrl);
    }
  
      create(data: ShiftEmployee): Observable<ShiftEmployee> {
      return this.http.post<ShiftEmployee>('http://localhost:19243/api/ShiftEmployees', data);
    }
  
      update(id: string, data: ShiftEmployee): Observable<ShiftEmployee> {
      return this.http.put<ShiftEmployee>(`${this.apiUrl}/${id}`, data);
    }
  
      delete(id: string): Observable<any> {
      return this.http.delete(`${this.apiUrl}/${id}`);
      }
  getdateWiseOfficeTime(): Observable<DateWiseOfficeTime[]>{
    return this.http.get<DateWiseOfficeTime[]>(this.DtwiseUrl);
  }
}
