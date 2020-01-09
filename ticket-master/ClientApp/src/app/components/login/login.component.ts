import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm;


  constructor(private accService: AccountService) { 
    this.loginForm = new FormGroup({
      email: new FormControl(null),
      password: new FormControl(null)
    });
  }
  ngOnInit() {

  }

  login(value: any){
    console.log('hello!');
    this.accService.login(value.email, value.password);
  }

  test(){
    this.accService.test();
  }

}
