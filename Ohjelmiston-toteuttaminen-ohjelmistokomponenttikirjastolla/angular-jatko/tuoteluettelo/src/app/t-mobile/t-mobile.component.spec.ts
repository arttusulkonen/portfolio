import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TMobileComponent } from './t-mobile.component';

describe('TMobileComponent', () => {
  let component: TMobileComponent;
  let fixture: ComponentFixture<TMobileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TMobileComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TMobileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
