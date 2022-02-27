import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AppService } from './app.service';
import { takeUntil } from 'rxjs/operators';
import { Subject } from 'rxjs';
import { isNull, isNullOrUndefined } from 'util';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, OnDestroy {

  constructor(private appService: AppService) { }

  title = 'angular-dotnet-example';

  userForm = new FormGroup({
    Name: new FormControl('', Validators.nullValidator && Validators.required),
    Age: new FormControl('', Validators.nullValidator && Validators.required),
    DateOfBirth: new FormControl('', Validators.nullValidator && Validators.required),
    Occupation: new FormControl(isNull, Validators.nullValidator && Validators.required),
    DeathSumInsured: new FormControl('', Validators.nullValidator && Validators.required)
  });

  users: any[] = [];
  occupations: any[] = [];
  premium = 0;
  value;


  destroy$: Subject<boolean> = new Subject<boolean>();
 

  onClearEvent() {
    this.userForm.reset();
  }


  addUser() {
    this.appService.addUser(this.userForm.value).pipe(takeUntil(this.destroy$)).subscribe(data => {
      console.log('message::::', data);
      console.log(this.premium);
     
      this.getAllUsers();
    });
  }

  public onOptionsSelected(event) {
    
    if (this.userForm.valid) { this.addUser();}    
  }

  findsum(data) {
    debugger
    this.premium = 0;
    this.value = data
    console.log(this.value);
    for (let j = 0; j < data.length; j++) {
      this.premium += this.value[j].monthlyPremium
      console.log(this.premium)
    }
  }

  getAllUsers() {
    this.appService.getUsers().pipe(takeUntil(this.destroy$)).subscribe((users: any[]) => {   
      this.users = users;
      this.findsum(users)
    });
  }

  getAllOccupation() {
    this.appService.getOccupation().pipe(takeUntil(this.destroy$)).subscribe((occupations: any[]) => {
      this.occupations = occupations;      
    });
  }

  ngOnInit() {
    this.getAllUsers();
    this.getAllOccupation();
  }

  ngOnDestroy() {
    this.destroy$.next(true);
    this.destroy$.unsubscribe();
  }
}
