export class RegistrationModel {
    email?: string | undefined;
    password?: string | undefined;
    isOrganisation?: boolean | undefined;
    user?: UserRegistrationModel | undefined;
    organisation?: OrganisationRegistrationModel | undefined;
}

export class UserRegistrationModel {
    firstName?: string | undefined;
    lastName?: string | undefined;
    birthdate?: Date | undefined;
    gender?: string | undefined;
}

export class OrganisationRegistrationModel{
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
}

