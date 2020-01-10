import { Component, OnInit, Input } from '@angular/core';
import { TicketsService } from 'src/app/services/tickets.service';
import { TicketDetailsModel } from 'src/app/models/ticket-details-model';
import { ActivatedRoute } from '@angular/router';
import { isDate } from 'util';

@Component({
  selector: 'app-ticket-details',
  templateUrl: './ticket-details.component.html',
  styleUrls: ['./ticket-details.component.css']
})
export class TicketDetailsComponent implements OnInit {

  ticketId : number;

  public model: TicketDetailsModel = new TicketDetailsModel();

  constructor(private ticketService : TicketsService, private route: ActivatedRoute) { }

  datePreetyPrint(date){
    if(date == null || date == undefined)
      return date;
    else if(!isDate(date)){
      return new Date(date).toDateString();
    }
    else
      return date.toDateString();
  }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.ticketId = Number(params.get("id"));
      this.ticketService.
        getTicketDetails(this.ticketId).
        subscribe((result: TicketDetailsModel)=>this.model = result);
    });
  }

}
