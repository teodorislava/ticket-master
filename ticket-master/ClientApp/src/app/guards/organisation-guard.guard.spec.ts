import { TestBed, async, inject } from '@angular/core/testing';

import { OrganisationGuardGuard } from './organisation-guard.guard';

describe('OrganisationGuardGuard', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [OrganisationGuardGuard]
    });
  });

  it('should ...', inject([OrganisationGuardGuard], (guard: OrganisationGuardGuard) => {
    expect(guard).toBeTruthy();
  }));
});
