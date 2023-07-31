import { TestBed } from '@angular/core/testing';

import { Api1authService } from './api1auth.service';

describe('Api1authService', () => {
  let service: Api1authService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Api1authService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
