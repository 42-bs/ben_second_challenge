import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Api1authService } from 'src/app/core/services';
import { LoginRequest } from 'src/app/core/dto/login-request';
import { LoginResponse } from 'src/app/core/dto/login-response';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.sass']
})
export class SigninComponent implements OnInit {
    title = 'datapointui';
    loginForm = new FormGroup({
        userName: new FormControl(null, Validators.required),
        password: new FormControl(null, Validators.required)
    });

    constructor(private authService: Api1authService, private router: Router) { }

    ngOnInit(): void {
    }

    onSubmit() {
            
            if (this.loginForm.valid) {
                let userLogin = new LoginRequest();
                Object.assign(userLogin, this.loginForm.value);
                this.authService.signin(userLogin).subscribe((data: LoginResponse) => {
                        if (data.token !== null) {
                            console.log(data.token);
                        } else {
                            alert("Falha no Login!");
                        }
                    },
                );
            }
    }
}
