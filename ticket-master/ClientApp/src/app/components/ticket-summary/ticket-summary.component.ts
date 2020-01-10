import { Component, OnInit, Input } from '@angular/core';
import { TicketSummaryModel } from 'src/app/models/ticket-summary-model';
import { TicketDetailsComponent } from '../ticket-details/ticket-details.component';
import { TicketDetailsModel } from 'src/app/models/ticket-details-model';

@Component({
  selector: 'app-ticket-summary',
  templateUrl: './ticket-summary.component.html',
  styleUrls: ['./ticket-summary.component.css']
})
export class TicketSummaryComponent implements OnInit {
   @Input()
   model: TicketSummaryModel = new TicketDetailsModel();
  constructor() { }

  ngOnInit() {

  }

}
