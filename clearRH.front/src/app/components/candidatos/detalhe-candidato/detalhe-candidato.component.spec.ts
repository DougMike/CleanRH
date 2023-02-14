import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalheCandidatoComponent } from './detalhe-candidato.component';

describe('DetalheCandidatoComponent', () => {
  let component: DetalheCandidatoComponent;
  let fixture: ComponentFixture<DetalheCandidatoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetalheCandidatoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetalheCandidatoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
