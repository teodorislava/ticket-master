import { Injectable, ResolvedReflectiveFactory, Inject } from '@angular/core';
import { UserRegistrationModel, RegistrationModel } from '../models/registration-model';
import { HttpClient } from '@angular/common/http';
import {Router} from "@angular/router"
import { LoginModel } from '../models/login-model';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string,
    private router: Router) { }

  

  registerUser(value: RegistrationModel){
    console.log(value);
    this.http.post(this.baseUrl + 'account',  value).subscribe(response => {
      this.router.navigate(['login']);
    });
  }

  login(username: string, password: string){
    this.http.put(this.baseUrl + 'account',  {
      username: username,
      password: password
    } as LoginModel).subscribe(response => {
      this.router.navigate(['dashboard']);
    });
  }

  test(){
    this.http.delete(this.baseUrl + 'account/', {
      headers: {
        "X-Requested-With": "XMLHttpRequest"
      }
    }).subscribe(obs => {
      console.log(obs);
    })
  }
}
