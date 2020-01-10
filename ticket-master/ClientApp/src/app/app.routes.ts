import { HomeComponent } from "./home/home.component";
import { Routes } from "@angular/router";
import { CounterComponent } from "./counter/counter.component";
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { HomepageComponent } from "./components/homepage/homepage.component";
import { RegisterComponent } from "./components/register/register.component";
import { LoginComponent } from "src/app/components/login/login.component";
import { TicketListComponent } from "./components/ticket-list/ticket-list.component";
import { DashboardComponent } from "./components/dashboard/dashboard.component";
import { TicketDetailsComponent } from "./components/ticket-details/ticket-details.component";
import { NewTicketComponent } from "./components/new-ticket/new-ticket.component";
import { OrganisationGuardGuard } from "./guards/organisation-guard.guard";
import { UserDetailsComponent } from "./components/user-details/user-details.component";

export const appRoutes : Routes = [
    { path: '', component: HomepageComponent},
    {path: 'login', component: LoginComponent},
    {path: 'register', component: RegisterComponent},
    { path: 'counter', component: CounterComponent },
    { path: 'fetch-data', component: FetchDataComponent },
    { path: 'dashboard', component: DashboardComponent, children: [
        {path: '', redirectTo:'ticket-list', pathMatch:'full'},
        { path: 'ticket-list', component: TicketListComponent, children: [
            {path: ':id', component: TicketDetailsComponent}
        ]},
        {path: 'new-ticket', component: NewTicketComponent, canActivate: [OrganisationGuardGuard]},
        {path: 'user-details', component: UserDetailsComponent}
    ] },
  ]