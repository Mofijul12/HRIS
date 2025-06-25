import { Component, OnInit } from '@angular/core';
import { Overtime } from 'src/app/models/overtime';
import { OvertimeService } from 'src/app/services/overtime.service';

@Component({
  selector: 'app-overtime',
  templateUrl: './overtime.component.html',
  styleUrls: ['./overtime.component.css']
})
export class OvertimeComponent implements OnInit{
  
   overtime:Overtime[] = [];
      Form: Overtime = { overTimeID: '', otDate:'', otStartTime: '',otEndTime:'',employeeID: ''};
      isEdit: boolean = false;
    
       constructor(private svc: OvertimeService) {}
    
      ngOnInit(): void {
        this.getAll();
      }
    
        getAll(): void {
  this.svc.getAll().subscribe(data => {
    this.overtime = data;


    const maxId = this.overtime.reduce((max, item) => {
      const num = parseInt(item.overTimeID!.replace('OT', ''), 10);
      return isNaN(num) ? max : Math.max(max, num);
    }, 0);


    const nextId = `OT${(maxId + 1).toString().padStart(3, '0')}`;
    this.Form.overTimeID = nextId;
  });
}

    
       onSubmit(): void {
        if (this.isEdit) {
          this.svc.update(this.Form.overTimeID!, this.Form).subscribe(() => {
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
    
        editItem(item: Overtime): void {
        this.Form = { ...item };
        this.isEdit = true;
      }
    
      deleteItem(id: string): void {
        if (confirm('Are you sure to delete?')) {
          this.svc.delete(id).subscribe(() => this.getAll());
        }
      }
    
      resetForm(): void {
        this.Form = {overTimeID: '', otDate:'', otStartTime: '',otEndTime:'',employeeID: ''};
        this.isEdit = false;
      }
}
