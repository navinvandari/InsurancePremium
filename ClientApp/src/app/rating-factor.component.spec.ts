import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RatingFactorComponent } from './rating-factor.component';

describe('RatingFactorComponent', () => {
  let component: RatingFactorComponent;
  let fixture: ComponentFixture<RatingFactorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RatingFactorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RatingFactorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
