import { Component, OnInit } from '@angular/core';
import { AlertifyService } from './_services/alertify.service';
import { AuthService } from './_services/auth.service';
import {JwtHelperService} from '@auth0/angular-jwt';
import { TestObject } from 'protractor/built/driverProviders';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  // = 'Moiyds App';
  jwtHelper = new JwtHelperService();


  constructor(private authService: AuthService){}

  ngOnInit() {
    const token = localStorage.getItem('token');
    if (token) {
      this.authService.decodedToken = this.jwtHelper.decodeToken(token);
    }
  }
}
