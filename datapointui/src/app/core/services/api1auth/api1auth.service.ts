import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoginRequest } from 'src/app/core/dto/login-request';
import { LoginResponse } from 'src/app/core/dto/login-response';
import { AppUserAuth } from 'src/app/core/model/app-user-auth';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class Api1authService {

  private appUserAuth: AppUserAuth;

  constructor(private httpClient: HttpClient) 
    {this.appUserAuth = new AppUserAuth();
  }

  signin(request: LoginRequest){
    return this.httpClient.post<LoginResponse>('http://localhost:5174/User/signin', request)
    .pipe(
        tap(resp => {
            Object.assign(this.appUserAuth, resp);
            localStorage.setItem("id_token", this.appUserAuth.token);
        })
    );
  }
}
