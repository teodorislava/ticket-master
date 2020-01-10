import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserDetailsModel } from '../models/user-details-model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  getCurrentUser(){
    return this.http.get<UserDetailsModel>(this.baseUrl + 'user', {
      headers: {
        "X-Requested-With": "XMLHttpRequest"
      }
    });
  }
}
