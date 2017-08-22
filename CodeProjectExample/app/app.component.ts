﻿import { Component } from "@angular/core"

@Component({
    selector: "user-app",
    template: `
               <div>
                  <nav class='navbar navbar-inverse'>
                       <div class='container-fluid'>
                         <ul class='nav navbar-nav'>
                           <li><a [routerLink]="['home']">Home</a></li>
                           <li><a [routerLink]="['knob']">Knob</a></li>
                          <!-- <li><a [routerLink]="['user']">User Management</a></li>-->
                      </ul>
                      </div>
                 </nav>    
              <div class='container'>
                <router-outlet></router-outlet>
              </div>
             </div>          
`
})

export class AppComponent {

}