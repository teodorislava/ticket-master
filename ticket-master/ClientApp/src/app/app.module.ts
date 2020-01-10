import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { RegisterComponent } from './components/register/register.component';
import { HomepageComponent } from './components/homepage/homepage.component';
import { appRoutes } from './app.routes';
import { LoginComponent } from './components/login/login.component';
import { TicketListComponent } from './components/ticket-list/ticket-list.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { TicketSummaryComponent } from './components/ticket-summary/ticket-summary.component';
import { TicketDetailsComponent } from './components/ticket-details/ticket-details.component';
import { NewTicketComponent } from './components/new-ticket/new-ticket.component';
import { UserDetailsComponent } from './components/user-details/user-details.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    RegisterComponent,
    HomepageComponent,
    LoginComponent,
    TicketListComponent,
    DashboardComponent,
    TicketSummaryComponent,
    TicketDetailsComponent,
    NewTicketComponent,
    UserDetailsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
