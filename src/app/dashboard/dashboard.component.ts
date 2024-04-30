import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface DataItem {
  id: number;
  name: string;
}

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent implements OnInit{







  componentName: string = ''; // Property to hold the component name
  apiUrl: string = 'https://webapiproject2.azurewebsites.net/api/ut';
  data: DataItem[] = [];
  firstItem: DataItem | undefined;
 
  constructor(private http: HttpClient) {}
 
  ngOnInit() {
    this.getData();
  }
 
  getData() {
    this.http.get<DataItem[]>(this.apiUrl).subscribe(
      (response: DataItem[]) => {
        this.data = response;
        this.firstItem = this.data.length > 0 ? this.data[0] : undefined;
      },
      (error) => {
        console.error('Error fetching data:', error);
      }
    );
  }
}
 