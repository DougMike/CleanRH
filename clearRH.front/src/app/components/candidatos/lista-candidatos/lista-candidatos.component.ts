import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Candidato } from 'src/app/models/candidato';
import { RequestService } from 'src/app/services/requests-service/request.service';

@Component({
  selector: 'app-lista-candidatos',
  templateUrl: './lista-candidatos.component.html',
  styleUrls: ['./lista-candidatos.component.scss']
})
export class ListaCandidatosComponent implements OnInit {

  candidatos: Candidato[] = [];
  candidatosFilter: Candidato[] = [];

  qtdStatus: number;

  constructor(private router: Router,
    private requestService: RequestService) { }

  ngOnInit(): void {
    this.getList();
  }

  getList() {
    this.requestService.getListCandidatos()
      .subscribe({
        next: (c: Candidato[]) => { this.candidatos = c; this.candidatosFilter = c },
        error: (e: any) => console.log('vish..', e)
      });
  }

  detalheCandidato(id: number) {
    this.router.navigate([`candidatos/detalhe-candidato/${id}`])
  }

  // RETORNOS PARA TABLE
  getBadgeColor(status: string) {
    switch (status.toLowerCase()) {
      case 'ativo':
        return 'success';
      case 'verificado':
        return 'success';
      case 'em preenchimento':
        return 'warning';
      case 'em andamento':
        return 'warning';
      case 'verificando':
        return 'warning';
      case 'inativo':
        return 'danger';
      case 'nao verificado':
        return 'danger';
    }
    return '';
  }

  filterBy(status: string) {
    if (status === '') {
      this.candidatosFilter = this.candidatos;
      return;
    }

    this.candidatosFilter = this.candidatosFilter
      .filter(c => c.situacao.toLocaleLowerCase() == status.toLowerCase());
  }

  getPorStatus(status: string){
    return this.qtdStatus = this.candidatosFilter
    .filter(c => c.situacao.toLocaleLowerCase() == status.toLowerCase()).length;
    
  }

}
