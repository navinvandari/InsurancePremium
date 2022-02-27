import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-rating-factor',
  templateUrl: './rating-factor.component.html',
  styleUrls: ['./rating-factor.component.css']
})
export class RatingFactorComponent implements OnInit {

  constructor() { }

  @Input() factors: any[];

  ngOnInit() {
  }

}
