import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Candidato } from 'src/app/models/candidato';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RequestService {

  get environment() { return environment };

  constructor(private httpClient: HttpClient) { }

  getListCandidatos() {
    return this.httpClient.get<Candidato[]>(`${environment.urlApi}/colaborador`);
  }
}
