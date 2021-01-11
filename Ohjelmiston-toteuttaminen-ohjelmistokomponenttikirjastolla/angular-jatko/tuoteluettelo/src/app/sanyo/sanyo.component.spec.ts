import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SanyoComponent } from './sanyo.component';

describe('SanyoComponent', () => {
  let component: SanyoComponent;
  let fixture: ComponentFixture<SanyoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SanyoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SanyoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
