import {NgModule} from "@angular/core";
import {WarningDialogComponent} from './components/warning-dialog/warning-dialog.component';
import {MatIconModule} from "@angular/material/icon";
import {MatButtonModule} from "@angular/material/button";
import {MatDialogModule} from "@angular/material/dialog";
import { HeaderComponent } from './components/header/header.component';
import {RouterLink} from "@angular/router";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import {MatOptionModule} from "@angular/material/core";
import {MatSelectModule} from "@angular/material/select";
import {NgForOf} from "@angular/common";
import {NgxMaskDirective} from "ngx-mask";

@NgModule({
  declarations: [
    WarningDialogComponent,
    HeaderComponent
  ],
  imports: [
    MatIconModule,
    MatButtonModule,
    MatDialogModule,
    RouterLink,
    FormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatOptionModule,
    MatSelectModule,
    NgForOf,
    NgxMaskDirective,
    ReactiveFormsModule
  ],
  exports: [
    HeaderComponent
  ]
})
export class SharedModule {
}
