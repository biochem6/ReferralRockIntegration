import { first, Observable } from 'rxjs'
import { Members } from '../models/members'
import { HttpClient, HttpParams } from '@angular/common/http'
import { Injectable, ResolvedReflectiveFactory } from '@angular/core';
import { Referrals } from '../models/referrals';

@Injectable({ providedIn: 'root' })
export class MemberService {
  baseUrl: string = 'https://localhost:7184/member/';
  constructor(private http: HttpClient) {
  }

  getMembers(): Observable<Members> {
    return this.http.get<Members>(this.baseUrl + 'getmembersasync');
  }

  getReferrals(memberId: string): Observable<Referrals> {
    return this.http.get<Referrals>(this.baseUrl + 'getreferralsasync', { params: new HttpParams().set('memberId', memberId) } );
  }

  saveReferral(
    referralCode: string,
    firstName: string,
    lastName: string,
    email: string,
    phone: string,
    amount: string,
    isApproved: boolean): Observable<object> {
    return this.http.post(this.baseUrl + 'savereferralasync', {
      "referralCode": referralCode,
      "firstName": firstName,
      "lastName": lastName,
      "email": email,
      "phone": phone,
      "amount": amount,
      "isApproved": isApproved
    });
  }

  updateReferral(
    referralId: string,
    firstName: string,
    lastName: string,
    email: string,
    phone: string,
    amount: number): Observable<object> {
    return this.http.post(this.baseUrl + 'updatereferralasync', {
      "referralId": referralId,
      "firstName": firstName,
      "lastName": lastName,
      "email": email,
      "phone": phone,
      "amount": amount
    });
  }

  removeReferral(referralId: string) {
    return this.http.post(this.baseUrl + 'removereferralasync', {
      'referralId': referralId
    });
  }
}
