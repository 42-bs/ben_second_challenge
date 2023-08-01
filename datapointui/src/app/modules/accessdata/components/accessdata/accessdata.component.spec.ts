import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AccessdataComponent } from './accessdata.component';

describe('AccessdataComponent', () => {
  let component: AccessdataComponent;
  let fixture: ComponentFixture<AccessdataComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AccessdataComponent]
    });
    fixture = TestBed.createComponent(AccessdataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
