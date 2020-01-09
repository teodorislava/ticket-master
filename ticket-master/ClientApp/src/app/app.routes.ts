import { HomeComponent } from "./home/home.component";
import { Routes } from "@angular/router";
import { CounterComponent } from "./counter/counter.component";
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { HomepageComponent } from "./components/homepage/homepage.component";
import { RegisterComponent } from "./components/register/register.component";
import { LoginComponent } from "src/app/components/login/login.component";
import { TicketListComponent } from "./components/ticket-list/ticket-list.component";

export const appRoutes : Routes = [
    { path: '', component: HomepageComponent},
    {path: 'login', component: LoginComponent},
    {path: 'register', component: RegisterComponent},
    { path: 'counter', component: CounterComponent },
    { path: 'fetch-data', component: FetchDataComponent },
    { path: 'ticket-list', component: TicketListComponent },
  ]