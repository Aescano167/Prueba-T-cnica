import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProyectoSpaComponent } from './proyecto-spa.component';

describe('ProyectoSpaComponent', () => {
  let component: ProyectoSpaComponent;
  let fixture: ComponentFixture<ProyectoSpaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProyectoSpaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ProyectoSpaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
