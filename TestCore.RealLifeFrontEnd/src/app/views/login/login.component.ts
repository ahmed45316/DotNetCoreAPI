import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from './auth.service';
import { NgForm } from '@angular/forms';
import { User } from './user';
import { AlertConfig } from 'ngx-bootstrap/alert';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'login.component.html',
  providers: [AlertConfig]
})
export class LoginComponent {
  pageTitle = 'Login';
  message = "Sign In to your account";
  loginError="user name or password incorrect"
  errorMessage: string;
  canLogin: boolean;
  currentUser: User;
  constructor(private authService: AuthService,
    private router: Router,private spinner: NgxSpinnerService) { }
    public ngOnInit() {
    }
  async login(loginForm: NgForm) {
    this.spinner.show();
    if (loginForm && loginForm.valid) {
      await this.authService.login(loginForm.form.value).subscribe((res) => {
        debugger
        this.currentUser = res as User
        if (this.currentUser.canLogin) {
          this.canLogin = true;
          if (this.authService.redirectUrl) {
            this.router.navigateByUrl(this.authService.redirectUrl);
          } else {
            this.router.navigate(['/dashboard']);
          }
        } else {
          this.canLogin = false;
          setTimeout(() => {
            this.canLogin=true
          }, 5000);
          this.errorMessage = 'user name or password incorrect.';
          this.spinner.hide();
        }
      });
    } else {
      this.errorMessage = 'Please enter a user name and password.';
      this.spinner.hide();
    }
  }
  showSpinner() {
    this.spinner.show();
    setTimeout(() => {
        /** spinner ends after 5 seconds */
        this.spinner.hide();
    }, 5000);
  }
}
