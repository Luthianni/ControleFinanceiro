import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Funcao } from '../models/Funcao';

const httpOtions = {
  headers : new HttpHeaders({
    'Content-Type' : 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class FuncoesService {
  url = 'https://localhost:44317/api/funcoes';

  constructor(private http: HttpClient) { }

  PegarTodos(): Observable<Funcao[]>{
    return this.http.get<Funcao[]>(this.url);
  }

  PegarPeloId(funcaoId: string): Observable<Funcao>{
    const apiUrl = `${this.url}/${funcaoId}`;
    return this.http.get<Funcao>(apiUrl);
  }

  NovaFuncao(funcao: Funcao): Observable<any>{
    return this.http.post<Funcao>(this.url, funcao, httpOtions);
  }

  AtualizarFuncao(funcaoId: string, funcao: Funcao) : Observable<any>{
    const apiUrl = `${this.url}/${funcaoId}`;
    return this.http.put<Funcao>(apiUrl, funcao, httpOtions);
  }

  ExcluirFuncao(funcaoId: string): Observable<any>{
    const apiUrl = `${this.url}/${funcaoId}`;
    return this.http.delete<string>(apiUrl, httpOtions);
  }
}
