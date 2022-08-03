import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MemberService } from '../../core/services/member-service';

@Component({
  selector: 'app-edit-referral',
  templateUrl: './edit-referral.component.html',
  styleUrls: ['./edit-referral.component.less']
})

export class EditReferralComponent implements OnInit {
  referralId: string = '';
  firstName: string = '';
  lastName: string = '';
  phone: string = '';
  email: string = '';
  amount: number = 0;

  constructor(
    private memberService: MemberService,
    private dialogRef: MatDialogRef<EditReferralComponent>,
    @Inject(MAT_DIALOG_DATA) private data: { referralId: string, firstName: string,  lastName: string, phone: string, email: string, amount: number}) { }

  ngOnInit(): void {
    this.referralId = this.data.referralId;
    this.firstName = this.data.firstName;
    this.lastName = this.data.lastName;
    this.phone = this.data.phone;
    this.email = this.data.email;
    this.amount = this.data.amount;
  }

  save() {
    this.memberService.updateReferral(this.referralId, this.firstName, this.lastName, this.email, this.phone, this.amount).subscribe();
  }
}
