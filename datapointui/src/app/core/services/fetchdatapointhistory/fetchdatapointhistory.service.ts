import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FetchdatapointhistoryService {

  constructor(private http: HttpClient) {}
  getDatapointHistory() {
    let token = localStorage.getItem("id_token");
    var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
    const httpOptions = {
        headers: headers_object
    };
    return this.http.get('http://localhost:5174/DataPointHistory', httpOptions);
  }
}
