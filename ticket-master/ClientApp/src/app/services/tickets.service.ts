import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TicketSummaryModel } from '../models/ticket-summary-model';
import { TicketDetailsModel } from '../models/ticket-details-model';
import { TicketCreationModel } from '../models/ticket-create-model';

@Injectable({
  providedIn: 'root'
})
export class TicketsService {

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  getTickets(){
    return this.http.get<TicketSummaryModel[]>(this.baseUrl + 'api/tickets', {
      headers: {
        "X-Requested-With": "XMLHttpRequest"
      }
    });
  }

  createTicket(value: TicketCreationModel){
    console.log(value);
    return this.http.post(this.baseUrl + 'api/tickets/', value, {
        headers: {
          "X-Requested-With": "XMLHttpRequest"
        }
      });
  }

  getTicketDetails(id:number){
    return this.http.get<TicketDetailsModel>(this.baseUrl + 'api/tickets/' + id);
  }

  buyTicket(id: number) {
    return this.http.put<{ message: string }>(this.baseUrl + 'api/tickets/' + id, {});
  }
}
