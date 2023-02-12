import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Candidato } from 'src/app/models/candidato';

@Component({
  selector: 'app-lista-candidatos',
  templateUrl: './lista-candidatos.component.html',
  styleUrls: ['./lista-candidatos.component.scss']
})
export class ListaCandidatosComponent implements OnInit {

  candidatos: Candidato[] = [{
    id: 1,
    nome: 'João',
    cpf: '55054184066'
  },
  {
    id: 2,
    nome: 'Maria',
    cpf: '94030929044'
  },
  {
    id: 3,
    nome: 'Carlos',
    cpf: '80603707076'
  },
  {
    id: 4,
    nome: 'Celso',
    cpf: '55426206040'
  }];
  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  detalheCandidato(id: number) {
    this.router.navigate([`candidatos/detalhe-candidato/${id}`])
  }
}
