import { Component, OnInit } from '@angular/core';
import { ShiftEmployee } from 'src/app/models/shift-employee';
import { ShiftEmployeeService } from 'src/app/services/shift-employee.service';

@Component({
  selector: 'app-shift-employee',
  templateUrl: './shift-employee.component.html',
  styleUrls: ['./shift-employee.component.css']
})
export class ShiftEmployeeComponent implements OnInit{

    shifEmp:ShiftEmployee[] = [];
         Form: ShiftEmployee = { shiftEmployeeID: '', fromDate:'', toDate: '',dateWiseOfficeTimeID:''};
         isEdit: boolean = false;
       
          constructor(private svc: ShiftEmployeeService) {}
       
         ngOnInit(): void {
           this.getAll();
         }
       
           getAll(): void {
     this.svc.getAll().subscribe(data => {
       this.shifEmp = data;
   
   
       const maxId = this.shifEmp.reduce((max, item) => {
         const num = parseInt(item.shiftEmployeeID!.replace('SE', ''), 10);
         return isNaN(num) ? max : Math.max(max, num);
       }, 0);
   
   
       const nextId = `SE${(maxId + 1).toString().padStart(3, '0')}`;
       this.Form.shiftEmployeeID = nextId;
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
           this.Form = {shiftEmployeeID: '', fromDate:'', toDate: '',dateWiseOfficeTimeID:''};
           this.isEdit = false;
         }
}
