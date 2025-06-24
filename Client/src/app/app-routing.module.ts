import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShiftEmployeeService } from './services/shift-employee.service';
import { ShiftEmployeeComponent } from './components/shift-employee/shift-employee.component';
import { OvertimeComponent } from './components/overtime/overtime.component';

const routes: Routes = [
  {path:'shiftEmployee',component:ShiftEmployeeComponent},
  {path:'overTime',component:OvertimeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
