import {NgModule} from "@angular/core";
import {AuthInterceptorService} from "./auth-interceptor.service";
import {HTTP_INTERCEPTORS} from "@angular/common/http";

@NgModule({
  providers: [
    AuthInterceptorService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptorService,
      multi: true
    }
  ]
})
export class InterceptorModule {
}
