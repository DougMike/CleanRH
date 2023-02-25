import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'clearRH.front';
  login = true;

  constructor(private router: Router) { }

  ngOnInit() {
    this.login = this.router.url === '';
    console.log(this.login)
  }
}
