import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { LoginComponent } from './login.component';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { AlertModule } from 'ngx-bootstrap/alert';import { NgxSpinnerModule } from 'ngx-spinner';
AlertModule



@NgModule({
  imports: [
    SharedModule,
    AlertModule.forRoot(),
    RouterModule.forChild([
      { path: 'login', component: LoginComponent }
    ]),
    NgxSpinnerModule
  ],
  declarations: [
    LoginComponent
  ]
})
export class UserModule { }
