import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestErrorsComponent } from './test-errors.component';

describe('TestErrorsComponent', () => {
  let component: TestErrorsComponent;
  let fixture: ComponentFixture<TestErrorsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TestErrorsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TestErrorsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
