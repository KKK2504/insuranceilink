import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ins';

  constructor(private http:HttpClient){

  }
  ngOnInit(){
    this.http.get('http://localhost:64943/api/PaymentDetails')
    .subscribe((data:any)=>{
      console.log(data);
    }),(error:any)=>{
      console.log(error);
    }
  }
}
