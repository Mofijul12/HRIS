import { Component, OnInit } from '@angular/core';
import { ShiftEmployee } from 'src/app/models/shift-employee';
import { ShiftEmployeeService } from 'src/app/services/shift-employee.service';

@Component({
  selector: 'app-shift-employee',
  templateUrl: './shift-employee.component.html',
  styleUrls: ['./shift-employee.component.css']
})
export class ShiftEmployeeComponent implements OnInit{

    shiftEmp:ShiftEmployee[] = [];
    Form: ShiftEmployee = { shiftEmployeeID: '', fromDate:'', toDate: '',dateWiseOfficeTimeID:''};
    isEdit: boolean = false;
  
     constructor(private svc: ShiftEmployeeService) {}
  
    ngOnInit(): void {
      this.getAll();
    }
  
      getAll(): void {
      this.svc.getAll().subscribe(data => {
        this.shiftEmp = data;
      });
    }
  
     onSubmit(): void {
      if (this.isEdit) {
        this.svc.update(this.Form.shiftEmployeeID!, this.Form).subscribe(() => {
          this.getAll();
          this.resetForm();
        });
      } else {
        const newItem = { ...this.Form, id: crypto.randomUUID() }; 
        this.svc.create(newItem).subscribe(() => {
          this.getAll();
          this.resetForm();
        });
      }
    }
  
      editItem(item: ShiftEmployee): void {
      this.Form = { ...item };
      this.isEdit = true;
    }
  
    deleteItem(id: string): void {
      if (confirm('Are you sure to delete?')) {
        this.svc.delete(id).subscribe(() => this.getAll());
      }
    }
  
    resetForm(): void {
      this.Form = { shiftEmployeeID: '', fromDate:'', toDate: '',dateWiseOfficeTimeID:''};
      this.isEdit = false;
    }
}
