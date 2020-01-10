import { Component, OnInit } from '@angular/core';
import { TicketSummaryModel } from 'src/app/models/ticket-summary-model';
import { TicketsService } from 'src/app/services/tickets.service';

@Component({
  selector: 'app-ticket-list',
  templateUrl: './ticket-list.component.html',
  styleUrls: ['./ticket-list.component.css']
})
export class TicketListComponent implements OnInit {
  ticketList: TicketSummaryModel[] = [];
  constructor(public ticketService: TicketsService) { 
    
  }

  ngOnInit() {
    this.ticketService.getTickets().subscribe((data: TicketSummaryModel[]) => this.ticketList = [...data]);
  }

}
