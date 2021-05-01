import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TemperatureConverterService } from '../shared/temperature-converter-service.service';

@Component({
  selector: 'app-temperature-coverter',
  templateUrl: './temperature-coverter.component.html',
  styleUrls: ['./temperature-coverter.component.scss']
})
export class TemperatureCoverterComponent implements OnInit {

  isSubmitted = false;
  tempratureForm: FormGroup;
  convertedValue: number;

  constructor(public fb: FormBuilder, public temperatureConverterService: TemperatureConverterService) {
    this.tempratureForm = this.fb.group({
      temperature: ['temperature', [Validators.required]],
      temperatureInput: [[], [Validators.required]]
    })

  }

  ngOnInit() { }



  // Getter method to access form control
  get myForm() {
    return this.tempratureForm.get('temperature');
  }

  // Submit Form
  public onSubmit() {
    this.isSubmitted = true;
    if (!this.tempratureForm.valid) {
      return false;
    } else {
      // alert(JSON.stringify(this.tempratureForm.value))
      this.temperatureConverterService.getConvertedValues(Number(this.tempratureForm.value.temperature), Number(this.tempratureForm.value.temperatureInput)).subscribe((convertedValue) => {
        this.convertedValue = convertedValue;
      });
    }
  }

}
