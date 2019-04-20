import { Injectable } from '@angular/core';

import { User } from './user';
import { MessageService } from '../messages/message.service';
import { loginParameters } from './loginParameters';
import { HttpClient } from "@angular/common/http";
import { AppSettings } from '../../_constants';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  currentUser: User;
  redirectUrl: string;
  loginParameter: loginParameters

  get isLoggedIn(): boolean {
    return !!this.currentUser;
  }
  constructor(private messageService: MessageService, private http: HttpClient) { }

   login(formLogin: loginParameters) {
    if (!formLogin.username || !formLogin.password) {
      this.messageService.addMessage('Please enter your userName and password');
    }
   return this.http.post(`${AppSettings.API_ENDPOINT}User/Login`, formLogin);
    // this.messageService.addMessage(`User: ${this.currentUser.userName} logged in`);
  }

  logout(): void {
    this.currentUser = null;
  }
}
