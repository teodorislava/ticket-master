import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { TicketCreationModel } from 'src/app/models/ticket-create-model';
import { TicketsService } from 'src/app/services/tickets.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new-ticket',
  templateUrl: './new-ticket.component.html',
  styleUrls: ['./new-ticket.component.css']
})
export class NewTicketComponent implements OnInit {

  public creationForm;

  constructor(private service: TicketsService, private router: Router) 
  {
    this.creationForm = new FormGroup({
      name: new FormControl(null),
      type: new FormControl(null),
      note: new FormControl(null),
      fullPrice: new FormControl(null),
      capacity: new FormControl(null),
      validFrom: new FormControl(null),
      validTo: new FormControl(null),
      description: new FormControl(null),
      discount: new FormControl(null),
    });
  }

  ngOnInit() {
  }


  onSubmit(value){
    var tmp = {
      name: value.name,
      type: value.type,
      note: value.note,
      fullPrice: value.fullPrice,
      capacity: value.capacity,
      validFrom: value.validFrom,
      validTo: value.validTo,
      description: value.description,
      discount: value.discount/100,
    } as TicketCreationModel;
    this.service.createTicket(tmp).subscribe((response)=>{
      this.router.navigate(['dashboard']);
    })
  }
}
