import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Member } from '../../core/models/members';
import { MemberService } from '../../core/services/member-service';

@Component({
  selector: 'app-members',
  templateUrl: './display-members.component.html',
  styleUrls: ['./display-members.component.less']
})
export class DisplayMembersComponent implements OnInit {
  members: Member[] = [];
  columnsToDisplay = ["firstName", "lastName", "email", "phone", "referralUrl", "referralCode", "actions"];

  constructor(
    private memberService: MemberService,
    private router: Router) { }

  ngOnInit(): void {
    this.getMembers();
  }

  getMembers(): void {
    this.memberService.getMembers()
      .subscribe(m => this.members = m.members);
  }

  referralsBtn(member: Member): void {
    this.router.navigateByUrl(`/referrals?memberId=${member.id}&memberName=${member.firstName + '%20' + member.lastName}`);
  }
}
