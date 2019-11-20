import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Fund } from './fund';

@Injectable({
  providedIn: 'root'
})
export class FundsService {

	private fundsUrl = "api/Funds";

	constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

	getFunds() {
		return this.http.get<Fund[]>(this.baseUrl + this.fundsUrl);
	}
}
