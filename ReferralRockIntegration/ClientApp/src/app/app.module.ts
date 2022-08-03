import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { DisplayMembersComponent } from './components/display-members/display-members.component';
import { RouterModule } from '@angular/router';
import { MatTableModule } from '@angular/material/table'
import { MemberService } from './core/services/member-service';
import { HttpClientModule } from '@angular/common/http';
import { MatButtonModule } from '@angular/material/button';
import { ToolbarComponent } from './core/shared/toolbar/toolbar.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { ReferralsComponent } from './components/display-referrals/referrals.component';
import { MatCardModule } from '@angular/material/card';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatExpansionModule } from '@angular/material/expansion';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { FormsModule } from '@angular/forms';
import { MatDialogModule } from '@angular/material/dialog';
import { EditReferralComponent } from './components/edit-referral/edit-referral.component';

@NgModule({
  declarations: [
    AppComponent,
    DisplayMembersComponent,
    ToolbarComponent,
    ReferralsComponent,
    EditReferralComponent
  ],
  imports: [
    BrowserModule,
    MatTableModule,
    HttpClientModule,
    MatButtonModule,
    MatToolbarModule,
    MatIconModule,
    MatMenuModule,
    MatCardModule,
    FlexLayoutModule,
    MatExpansionModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatCheckboxModule,
    FormsModule,
    MatDialogModule,
    RouterModule.forRoot([
      { path: 'members', component: DisplayMembersComponent },
      { path: 'referrals', component: ReferralsComponent }
    ])
  ],
  exports: [MatTableModule],
  providers: [MemberService],
  bootstrap: [AppComponent]
})
export class AppModule { }
