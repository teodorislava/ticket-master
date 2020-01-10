export class TicketDetailsModel {
    name?: string | undefined;
    type?: string | undefined;
    note?: string | undefined;
    organisationName?: string | undefined;
    price?: number | undefined;
    fullPrice?: number | undefined;
    discount?: number | undefined;
    numberSold?: number | undefined;
    numberLeft?: number | undefined;
    validFrom?: Date | undefined;
    validTo?: Date | undefined;

    constructor(){
        this.validFrom = new Date();
        this.validTo = new Date();
    }
}