import {Component, Input, OnInit} from '@angular/core';
import {DayOfWeek} from "../../../../shared/interfaces/DayOfWeek";
import {AbstractControl, FormArray, FormBuilder, FormGroup, Validators} from "@angular/forms";

@Component({
  selector: 'app-business-hours',
  templateUrl: './business-hours.component.html',
  styleUrls: ['./business-hours.component.sass']
})
export class BusinessHoursComponent implements OnInit {
  @Input({
    required: true
  })
  formGroup: FormGroup;

  daysOfWeek: DayOfWeek[] = [];

  constructor(
    private readonly formBuilder: FormBuilder
  ) {
  }

  ngOnInit() {
    this.formGroup.addControl('businessHours', this.formBuilder.array([]));

    this.loadDaysOfWeek();
  }

  get businessHours() {
    return this.formGroup.get('businessHours') as FormArray;
  }

  loadDaysOfWeek() {
    this.daysOfWeek = [
      {id: 0, name: 'Domingo'},
      {id: 1, name: 'Segunda-feira'},
      {id: 2, name: 'Terça-feira'},
      {id: 3, name: 'Quarta-feira'},
      {id: 4, name: 'Quinta-feira'},
      {id: 5, name: 'Sexta-feira'},
      {id: 6, name: 'Sábado'},
    ];
  }

  getFormGroup() {
    return this.formBuilder.group({
      dayOfWeek: [null, Validators.required],
      openingTime: [null, Validators.required],
      closingTime: [null, Validators.required],
    });
  }

  getInfoBusinessHours(businessHours: AbstractControl) {
    const dayOfWeek = this.daysOfWeek.find(
      dayOfWeek => dayOfWeek.id === businessHours.get('dayOfWeek')?.value
    )?.name || 'Dia da semana';

    const openingTime = businessHours.get('openingTime')?.value || '00:00';

    const closingTime = businessHours.get('closingTime')?.value || '00:00';

    return `${dayOfWeek} - ${openingTime} às ${closingTime}`;
  }

  addBusinessHours() {
    this.businessHours.push(this.getFormGroup());
  }

  removeBusinessHours(index: number) {
    this.businessHours.removeAt(index);
  }
}