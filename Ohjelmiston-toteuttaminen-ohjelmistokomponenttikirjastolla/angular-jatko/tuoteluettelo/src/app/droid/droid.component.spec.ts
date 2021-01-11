import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DroidComponent } from './droid.component';

describe('DroidComponent', () => {
  let component: DroidComponent;
  let fixture: ComponentFixture<DroidComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DroidComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DroidComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
