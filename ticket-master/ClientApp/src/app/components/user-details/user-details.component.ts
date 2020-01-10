import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/user.service';
import { UserDetailsModel } from 'src/app/models/user-details-model';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css']
})
export class UserDetailsComponent implements OnInit {

  model : UserDetailsModel = new UserDetailsModel();

  constructor(private userService : UserService) { }
  
  ngOnInit() {
    this.userService.getCurrentUser().subscribe((result : UserDetailsModel) => {
      this.model = result;
    })
  }

}
