import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { FetchdatapointhistoryService } from '../../../../core/services/fetchdatapointhistory/fetchdatapointhistory.service';

@Component({
  selector: 'app-accessdata',
  templateUrl: './accessdata.component.html',
  styleUrls: ['./accessdata.component.sass']
})
export class AccessdataComponent implements OnInit {

  storeddata: MatTableDataSource<any> = new MatTableDataSource();
  
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator | null = null;

  constructor(private fetchdatapointhistoryService: FetchdatapointhistoryService) { }

  ngOnInit() {
    this.fetchdatapointhistoryService.getDatapointHistory().subscribe((data) => {
      this.storeddata.data = data;
      this.storeddata.paginator = this.paginator;
    });
  }
}
