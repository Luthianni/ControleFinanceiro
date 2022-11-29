import { Component, Inject, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { CartoesService } from 'src/app/services/cartoes.service';

@Component({
  selector: 'app-listagem-cartoes',
  templateUrl: './listagem-cartoes.component.html',
  styleUrls: ['./listagem-cartoes.component.css'],
})
export class ListagemCartoesComponent implements OnInit {
  cartoes = new MatTableDataSource<any>();
  displayedColumns: string[];
  usuarioId: string = localStorage.getItem('UsuarioId');

  @ViewChild(MatPaginator, { static: true })
  paginator: MatPaginator;

  @ViewChild(MatSort, { static: true })
  sort: MatSort;

  constructor(
    private cartoesService: CartoesService,
    private dialog: MatDialog
  ) {}

  ngOnInit(): void {
    this.cartoesService
      .PegarCartoesPeloUsuarioId(this.usuarioId)
      .subscribe((resultado) => {
        this.cartoes.data = resultado;
        this.cartoes.paginator = this.paginator;
        this.cartoes.sort = this.sort;
      });

    this.displayedColumns = this.ExibirColunas();
  }

  ExibirColunas(): string[] {
    return ['nome', 'bandeira', 'numero', 'limite', 'acoes'];
  }

  AbrirDialog(cartaoId, numero): void {
    this.dialog
      .open(DialogExclusaoCartoesComponent, {
        data: {
          cartaoId: cartaoId,
          numero: numero,
        },
      })
      .afterClosed()
      .subscribe((resultado) => {
        if (resultado === true) {
          this.cartoesService
            .PegarCartoesPeloUsuarioId(this.usuarioId)
            .subscribe((dados) => {
              this.cartoes.data = dados;
              this.cartoes.paginator = this.paginator;
            });
          this.displayedColumns = this.ExibirColunas();
        }
      });
  }
}

@Component({
  selector: 'app-dialog-exclusao-cartoes',
  templateUrl: 'dialog-exclusao-cartoes.html',
})
export class DialogExclusaoCartoesComponent {
  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    private cartoesService: CartoesService,
    private snackbar: MatSnackBar
  ) {}

  ExcluirCartao(cartaoId): void {
    this.cartoesService.ExcluirCartao(cartaoId).subscribe((resultado) => {
      this.snackbar.open(resultado.mensagem, null, {
        duration: 2000,
        horizontalPosition: 'right',
        verticalPosition: 'top',
      });
    });
  }
}
