import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { CartoesService } from '../../../services/cartoes.service';
import { Cartao } from './../../../models/Cartao';

@Component({
  selector: 'app-atualizar-cartao',
  templateUrl: './atualizar-cartao.component.html',
  styleUrls: ['../listagem-cartoes/listagem-cartoes.component.css'],
})
export class AtualizarCartaoComponent implements OnInit {

  formulario: any;
  cartao: Observable<Cartao>;
  numeroCartao: string;
  erros: string[];

  constructor(private CartoesService: CartoesService,
    private router: Router,
    private route: ActivatedRoute,
    private snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.erros = [];
    const cartaoId = this.route.snapshot.params.id;

    this.CartoesService.PegarCartaoPeloId(cartaoId).subscribe(resultado => {
      this.numeroCartao = resultado.numero;
      this.formulario = new FormGroup({
        cartaoId: new FormControl(resultado.cartaoId),
        nome: new FormControl(resultado.nome, [Validators.required, Validators.minLength(1), Validators.maxLength(20)]),
        bandeira: new FormControl(resultado.bandeira, [Validators.required, Validators.minLength(1), Validators.maxLength(15)]),
        numero: new FormControl(resultado.numero, [Validators.required, Validators.minLength(1), Validators.maxLength(20)]),
        limite: new FormControl(resultado.limite, [Validators.required]),
        usuarioId: new FormControl(resultado.usuarioId)
      });
    });
  }
  get propriedade() {
    return this.formulario.controls;
  }

  VoltarListagem(): void {
    this.router.navigate(['cartoes/atualizarcartao']);
  }
}
