export class TicketCreationModel {
    name?: string | undefined;
    type?: string | undefined;
    note?: string | undefined;
    fullPrice?: number | undefined;
    capacity?: number | undefined;
    validFrom?: Date | undefined;
    validTo?: Date | undefined;
    description?: string | undefined;
    discount?: number | undefined;
}