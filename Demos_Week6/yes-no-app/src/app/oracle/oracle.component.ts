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
  }

  ngOnInit(): void {

  }

}
