import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TemperatureConverterService {
  public baseUrl = 'http://localhost:51690/api/temperature';
  constructor(public http: HttpClient) { }

  public getConvertedValues(caseNumber: number, valueToConvert: number): Observable<any> {
    return this.http.get(`${this.baseUrl}?caseValue=${caseNumber}&valueToConvert=${valueToConvert}`);
  }

}
