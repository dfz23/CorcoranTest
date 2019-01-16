import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders, HttpParams } from '@angular/common/http';
import {Observable} from 'rxjs';
import {PresidentModel} from '../models/presidentModel'
import { ResponseModel } from '../models/responseModel';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {

  constructor(private http: HttpClient) { }

  getAllPresidents(sortType:string): Observable<any> {
    console.log("Here" + sortType);     
  return this.http.get(environment.apiURL + `president/getall?orderType=`+ sortType); 
  }
}
