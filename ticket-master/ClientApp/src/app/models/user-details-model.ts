export class UserDetailsModel {
    isOrganisation?: boolean | undefined;
    email?: string | undefined; 
    registeredOn?: Date | undefined;
    organisation?: OrganisationDetailsModel | undefined;
    ticketBuyer?: TicketBuyerModel | undefined;

    constructor(){
        this.organisation = new OrganisationDetailsModel();
        this.ticketBuyer = new TicketBuyerModel();
    }
}

export class OrganisationDetailsModel {
    name?: string | undefined; 
    incorporatedDate?: Date | undefined; 
    description?: string | undefined; 
    phoneNumber?: string | undefined; 
    addressLine1?: string | undefined; 
    addressLine2?: string | undefined; 
    addressLine3?: string | undefined;
    country?: string | undefined;  
    state?: string | undefined; 
    city?: string | undefined; 
    zipCode?: string | undefined; 
    turnover?: number | undefined = 0; 
    offersCount?: number | undefined; 
}

export class TicketBuyerModel {
    firstName?: string | undefined; 
    lastName?: string | undefined; 
    birthdate?: Date | undefined; 
    gender?: string | undefined; 
    boughtCount?: number | undefined; 
}