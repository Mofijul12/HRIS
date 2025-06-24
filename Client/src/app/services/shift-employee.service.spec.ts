import { TestBed } from '@angular/core/testing';

import { ShiftEmployeeService } from './shift-employee.service';

describe('ShiftEmployeeService', () => {
  let service: ShiftEmployeeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShiftEmployeeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
