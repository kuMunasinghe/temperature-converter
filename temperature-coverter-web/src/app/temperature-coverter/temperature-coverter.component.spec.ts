import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TemperatureCoverterComponent } from './temperature-coverter.component';

describe('TemperatureCoverterComponent', () => {
  let component: TemperatureCoverterComponent;
  let fixture: ComponentFixture<TemperatureCoverterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TemperatureCoverterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TemperatureCoverterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
