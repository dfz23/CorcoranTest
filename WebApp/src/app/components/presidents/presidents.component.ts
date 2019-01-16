import { Component, OnInit } from '@angular/core';
import { ServiceService } from '../../service/service.service';
import { ResponseModel } from '../../models/responseModel'
import { GridDataResult } from '@progress/kendo-angular-grid';
import { SortDescriptor, orderBy } from '@progress/kendo-data-query';

@Component({
  selector: 'app-presidents',
  templateUrl: './presidents.component.html',
  styleUrls: ['./presidents.component.css']
})
export class PresidentsComponent implements OnInit {

  gridData: any
  public multiple = false;
  public allowUnsort = true;
  public sort: SortDescriptor[] = [{
    field: 'FullName',
    dir: 'asc'
  }];
  public gridView: GridDataResult;
  constructor(private _service: ServiceService) {
    this._service.getAllPresidents(this.sort[0].dir).subscribe(this.showdata.bind(this));  
  }

  ngOnInit() {
  }

  showdata(data: ResponseModel) {
    this.gridData = data.DataResponse;
    console.log(this.gridData);
  }
  private loadProducts(): void {
    this._service.getAllPresidents(this.sort[0].dir).subscribe(this.showdata.bind(this)); 
}
  public sortChange(sort: SortDescriptor[]): void {
    this.sort = sort;
    console.log(this.sort);
    this.loadProducts();
}
}
