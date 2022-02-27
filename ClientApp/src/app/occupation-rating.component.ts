import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-occupation-rating',
  templateUrl: './occupation-rating.component.html',
  styleUrls: ['./occupation-rating.component.css']
})
export class OccupationRatingComponent implements OnInit {

  constructor() { }

  @Input() occupations: any[];

  ngOnInit() {
  }

}
