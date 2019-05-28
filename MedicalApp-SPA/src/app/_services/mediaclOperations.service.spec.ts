/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { MediaclOperationsService } from './mediaclOperations.service';

describe('Service: MediaclOperations', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [MediaclOperationsService]
    });
  });

  it('should ...', inject([MediaclOperationsService], (service: MediaclOperationsService) => {
    expect(service).toBeTruthy();
  }));
});
