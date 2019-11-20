import { Component, OnInit } from '@angular/core';
import { FundsService } from '../funds.service';
import { Fund } from '../fund';

@Component({
  selector: 'app-funds',
  templateUrl: './funds.component.html',
  styleUrls: ['./funds.component.scss']
})
export class FundsComponent implements OnInit {

	funds: Fund[] = [];

	constructor(private fundsService: FundsService) { }


	ngOnInit() {
		this.fundsService.getFunds().subscribe(
			data => {
				this.funds = data;
			}
		);
  }

}
