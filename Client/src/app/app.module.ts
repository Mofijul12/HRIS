import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http'
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShiftEmployeeComponent } from './components/shift-employee/shift-employee.component';
import { OvertimeComponent } from './components/overtime/overtime.component';

@NgModule({
  declarations: [
    AppComponent,
    ShiftEmployeeComponent,
    OvertimeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
