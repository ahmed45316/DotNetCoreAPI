import { EmployeesComponent } from './employees.component';
import { NgModule } from '@angular/core';
import { ScreensRoutingModule } from './screens-routing.module'
@NgModule({
    imports: [
       ScreensRoutingModule
    ],
    declarations: [
    EmployeesComponent
    ]
  })
  export class ScreensModule { }