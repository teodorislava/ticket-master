import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormControl, FormGroup } from '@angular/forms';
import { RegistrationModel, UserRegistrationModel, OrganisationRegistrationModel } from 'src/app/models/registration-model';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  creationForm;
  isOrganisation = false;

  constructor(public http: HttpClient, public accService: AccountService, @Inject('BASE_URL') public baseUrl: string) {
    this.creationForm = new FormGroup({
      sender: new FormControl(null),
      email: new FormControl(null),
      password: new FormControl(null),
      first_name: new FormControl(null),
      last_name: new FormControl(null),
      birthdate: new FormControl(null),
      gender: new FormControl(null),
      name: new FormControl(null),
      incorporated_date: new FormControl(null),
      description: new FormControl(null),
      phone_number: new FormControl(null),
      address_line_1: new FormControl(null),
      address_line_2: new FormControl(null),
      address_line_3: new FormControl(null),
      country: new FormControl(null),
      state: new FormControl(null),
      city: new FormControl(null),
      zip: new FormControl(null)
    });
   }

  ngOnInit() {
  }

  register() {
    this.http.post(this.baseUrl + 'account', {Email: "jocko@gmail.com", Password: "Jocaivasa2#"}).subscribe(response => {
      alert('Nice!');
    });
  }

  onSubmit(value){
    console.log(value);
    var tmp = {
      email: value.email,
      password: value.password,
      isOrganisation: this.isOrganisation,
      user: {
        firstName: value.first_name,
        lastName: value.last_name,
        birthdate: value.birthdate,
        gender: value.gender
      } as UserRegistrationModel,
      organisation: {
        name: value.name,
        incorporatedDate: value.incorporated_date,
        description: value.description,
        phoneNumber: value.phone_number,
        addressLine1: value.address_line_1,
        addressLine2: value.address_line_2,
        addressLine3: value.address_line_3,
        country: value.country,
        state: value.state,
        city: value.city,
        zipCode: value.zip
      } as OrganisationRegistrationModel
    } as RegistrationModel;
    this.accService.registerUser(tmp);
  }

  onChange(value){
    this.isOrganisation = value == "Organisation"; 
  }
}
