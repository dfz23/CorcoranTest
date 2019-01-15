import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import {Observable} from 'rxjs';
import {PresidentModel} from '../models/presidentModel'
import { ResponseModel } from '../models/responseModel';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {

  constructor(private http: HttpClient) { }

  getAllPresidents(): Observable<any> {
    console.log("Here");
  return this.http.get(`http://localhost:49342/api/president/`); 
  }
}
