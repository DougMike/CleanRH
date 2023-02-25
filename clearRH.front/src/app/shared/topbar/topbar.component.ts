import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-topbar',
  templateUrl: './topbar.component.html',
  styleUrls: ['./topbar.component.scss']
})
export class TopbarComponent implements OnInit {

  showSearch = false;
  constructor() { }

  ngOnInit(): void {
  }

  setShowSearch() {
    this.showSearch = !this.showSearch;
  }


}
