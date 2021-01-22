import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaasivuComponent } from './paasivu.component';

describe('PaasivuComponent', () => {
  let component: PaasivuComponent;
  let fixture: ComponentFixture<PaasivuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PaasivuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PaasivuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
