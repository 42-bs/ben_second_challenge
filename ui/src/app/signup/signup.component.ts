import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-signup',
    templateUrl: './signup.component.html',
    styleUrls: ['./signup.component.sass']
})
export class SignupComponent {
    username: string = "";
    password: string = "";
    repassword: string = "";
    show: boolean = false;
    submit() {
        console.log("user name is " + this.username)
        this.clear();
    }
    clear() {
        this.username = "";
        this.password = "";
        this.show = true;
    }
    // sendauthdata() {
        
    //     this.http.post<any>("http://localhost:3000/signupUsersList",this.)
    //     .subscribe(res=>{alert('SIGNIN SUCCESFUL');
    //     this.router.navigate(["login"])},
    //     err=>{alert("Something went wrong")})
    // }
}
