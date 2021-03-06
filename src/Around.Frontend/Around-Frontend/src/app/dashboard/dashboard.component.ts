import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor() { }

  public dashCard = [
    { colorDark: '#5C6BC0', colorLight: '#7986CB', number: 1221, title: 'SALES', icon: 'local_grocery_store' },
    { colorDark: '#42A5F5', colorLight: '#64B5F6', number: 1221, title: 'LEADS', icon: 'new_releases' },
    { colorDark: '#26A69A', colorLight: '#4DB6AC', number: 1221, title: 'ASSETS', icon: 'assignments' },
    { colorDark: '#66BB6A', colorLight: '#81C784', number: 1221, title: 'BANKING', icon: 'account_balance' }
];

  ngOnInit() {
  }
}
