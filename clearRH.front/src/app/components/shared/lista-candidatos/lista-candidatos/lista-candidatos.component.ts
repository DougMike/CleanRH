import { Component, OnInit } from '@angular/core';
import { Candidato } from 'src/app/models/candidato';

@Component({
  selector: 'app-lista-candidatos',
  templateUrl: './lista-candidatos.component.html',
  styleUrls: ['./lista-candidatos.component.scss']
})
export class ListaCandidatosComponent implements OnInit {

  candidatos: Candidato[] = [];
  constructor() { }

  ngOnInit(): void {
  }

}
