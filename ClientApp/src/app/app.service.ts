import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  constructor(private http: HttpClient) { }

  rootURL = '/v1';

  getUsers() {
    return this.http.get(this.rootURL + '/users');
  }

  addUser(user: any) {
    return this.http.post(this.rootURL + '/user', user);
  }

  getOccupation() {
    return this.http.get(this.rootURL + '/occupation');
  }

  getFactor() {
    return this.http.get(this.rootURL + '/factor');
  }

}
