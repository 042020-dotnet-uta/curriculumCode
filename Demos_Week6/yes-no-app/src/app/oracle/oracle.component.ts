import { Component, OnInit } from '@angular/core';
import { YesNoService } from '../yes-no.service';
import { YesNo } from '../models/yes-no-response';

@Component({
  selector: 'app-oracle',
  templateUrl: './oracle.component.html',
  styleUrls: ['./oracle.component.css']
})
export class OracleComponent implements OnInit {
  answer: YesNo | undefined;

  constructor(private yesNo: YesNoService) { }

  getAnswer() {
    this.yesNo.getAnswer()
      .then(answer => this.answer = answer);
    console.log(this.answer);
  }

  ngOnInit(): void {

  }

}
// promises:
//    only one result ever
//    only one line of code can wait on the promise at a time
//    standard in ES6
// observables:
//    supports many results arriving at different times into the future forever
//    many subscribers to the same observable
//    not standard JS, provided by package rxjs.
