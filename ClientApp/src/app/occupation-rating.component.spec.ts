import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OccupationRatingComponent } from './occupation-rating.component';

describe('OccupationRatingComponent', () => {
  let component: OccupationRatingComponent;
  let fixture: ComponentFixture<OccupationRatingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OccupationRatingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OccupationRatingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
