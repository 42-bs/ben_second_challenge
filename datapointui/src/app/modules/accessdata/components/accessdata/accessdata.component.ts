import { Component } from '@angular/core';
import { FetchdatapointhistoryService } from '../../../../core/services/fetchdatapointhistory/fetchdatapointhistory.service';

@Component({
  selector: 'app-accessdata',
  templateUrl: './accessdata.component.html',
  styleUrls: ['./accessdata.component.sass']
})
export class AccessdataComponent {

    storeddata: any;
    constructor(private fetchdatapointhistoryService: FetchdatapointhistoryService) { }
    ngOnInit() {
        this.fetchdatapointhistoryService.getDatapointHistory().subscribe((data) => {
            this.storeddata = data;
        });
    }

}
