import { ToastrModule } from 'ngx-toastr';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { NgxGalleryModule } from '@kolkov/ngx-gallery';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ToastrModule.forRoot({
      positionClass: "toast-bottom-right"
    }),
    TabsModule.forRoot(),
    BsDropdownModule.forRoot(),
    NgxGalleryModule
  ],
  exports: [
     BsDropdownModule,
     ToastrModule,
     TabsModule,
     NgxGalleryModule
  ]
})
export class SharedModule { }
