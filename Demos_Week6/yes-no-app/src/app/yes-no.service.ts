import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { YesNoResponse } from './models/yes-no-response';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class YesNoService {

  constructor(private http: HttpClient) { }

  getAnswer() {
    return this.http.get<YesNoResponse>(environment.yesNoUrl).toPromise()
      .then(yesNo => yesNo.answer);
  }
}
