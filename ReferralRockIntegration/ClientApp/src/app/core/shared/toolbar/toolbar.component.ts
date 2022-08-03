import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.less']
})

export class ToolbarComponent implements OnInit {
  constructor(private router: Router) {}

  ngOnInit(): void {
  }

  navBtnClick(name: string) {
    switch (name) {
      case 'members': {
        this.router.navigateByUrl('/display-members');
        break;
      }
      case "referrals": {
        this.router.navigateByUrl('/edit-referrals');
        break;
      }
    }
  }
}
