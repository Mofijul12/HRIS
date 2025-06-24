import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShiftEmployeeComponent } from './shift-employee.component';

describe('ShiftEmployeeComponent', () => {
  let component: ShiftEmployeeComponent;
  let fixture: ComponentFixture<ShiftEmployeeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ShiftEmployeeComponent]
    });
    fixture = TestBed.createComponent(ShiftEmployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
