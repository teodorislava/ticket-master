import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TicketSummaryModel } from '../models/ticket-summary-model';
import { TicketDetailsModel } from '../models/ticket-details-model';

@Injectable({
  providedIn: 'root'
})
export class TicketsService {

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  getTickets(){
    return this.http.get<TicketSummaryModel[]>(this.baseUrl + 'api/tickets');
  }

  getTicketDetails(id:number){
    return this.http.get<TicketDetailsModel>(this.baseUrl + 'api/tickets/' + id);
  }
}
