import { Component, OnInit } from '@angular/core';
import { MatCheckboxChange, MatCheckboxClickAction } from '@angular/material/checkbox';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { Referral } from '../../core/models/referrals';
import { MemberService } from '../../core/services/member-service';
import { EditReferralComponent } from '../edit-referral/edit-referral.component';

@Component({
  selector: 'app-referrals',
  templateUrl: './referrals.component.html',
  styleUrls: ['./referrals.component.less']
})

export class ReferralsComponent implements OnInit {
  memberId: string = '';
  referrals: Referral[] = [];
  referringMemberName: string = '';
  referralCode: string = '';
  newRefFirstName: string = '';
  newRefLastName: string = '';
  newRefEmail: string = '';
  newRefPhone: string = '';
  newRefAmount: string = '';
  newRefIsApproved: boolean = false;

  columnsToDisplay = ["firstName", "lastName", "email", "phone", "referralUrl", "referralCode", 'edit', 'delete'];

  constructor(
    private route: ActivatedRoute,
    private memberService: MemberService,
    private dialog: MatDialog) {}

  ngOnInit(): void {
    this.route.queryParams
      .subscribe(params => {
        this.memberId = params['memberId'];
        this.referringMemberName = params['memberName'];
        this.getReferrals();
      })
  }

  getReferrals(): void {
    this.memberService
      .getReferrals(this.memberId)
      .subscribe(r => {
        this.referrals = r.referrals
        this.referralCode = r?.referrals[0].memberReferralCode
      });
  }

  isApproved(event: MatCheckboxChange) {
      this.newRefIsApproved = event.checked;
  }

  saveReferral() {
    this.memberService.saveReferral(
      this.referralCode,
      this.newRefFirstName,
      this.newRefLastName,
      this.newRefEmail,
      this.newRefPhone,
      this.newRefAmount,
      this.newRefIsApproved).subscribe(i => i);
  }

  editReferral(row: Referral) {
    const dialogRef = this.dialog.open(EditReferralComponent, {
      width: '400px',
      data: { referralId: row.id, firstName: row.firstName, lastName: row.lastName, phone: row.phoneNumber, email: row.email, amount: row.amount }
    });

    dialogRef.afterClosed().subscribe();
  }

  removeReferral(row: Referral) {
    this.memberService.removeReferral(row.id).subscribe();
  }
}
