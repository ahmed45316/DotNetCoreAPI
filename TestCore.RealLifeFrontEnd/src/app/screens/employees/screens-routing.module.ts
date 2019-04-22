import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeesComponent } from './employees.component';

const routes: Routes = [
    {
      path: '',
      data: {
        title: 'screens'
      },
      children: [
        {
          path: '',
          redirectTo: 'employees',
          pathMatch:"full"
        },
       {
          path: 'employees',
          component: EmployeesComponent,
          data: {
            title: 'Employees'
          }
        }
      ]
    }
  ];
  
  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class ScreensRoutingModule {}