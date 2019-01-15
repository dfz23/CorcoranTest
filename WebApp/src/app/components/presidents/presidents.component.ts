import { Component, OnInit } from '@angular/core';
import{ServiceService} from'../../service/service.service';
import{ResponseModel} from '../../models/responseModel'
import { from } from 'rxjs';

@Component({
  selector: 'app-presidents',
  templateUrl: './presidents.component.html',
  styleUrls: ['./presidents.component.css']
})
export class PresidentsComponent implements OnInit {

  gridData:any
  constructor(private _service:ServiceService)
  {
    this._service.getAllPresidents().subscribe(this.showdata.bind(this));
   }

  ngOnInit() {
  }

  showdata(data:ResponseModel){
    this.gridData = data.DataResponse;
    console.log(this.gridData);
  }
}
