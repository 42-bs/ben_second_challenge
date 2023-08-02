import { TestBed } from '@angular/core/testing';

import { FetchdatapointhistoryService } from './fetchdatapointhistory.service';

describe('FetchdatapointhistoryService', () => {
  let service: FetchdatapointhistoryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FetchdatapointhistoryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
