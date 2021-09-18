import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Categoria } from 'src/app/interfaces/app-interfaces';



@Injectable({
  providedIn: 'root'
})
export class CategoriaService {

  private _baseUrl: string = 'https://localhost:44340/api/Categorias';
  constructor(private http: HttpClient) {
  }
  get(): Observable<any> {
    const url: string = `${this._baseUrl}`;
    return this.http.get(url);
  }
  obtener(id: number): Observable<any> {
    const url: string = `${this._baseUrl}/${id}`;
    return this.http.get(url);
  }
  insertar(registro: Categoria): Observable<any> {

    if (registro.id != 0) {
      const url: string = `${this._baseUrl}/${registro.id}`;
      return this.http.put(url, registro);
    }
    const url: string = `${this._baseUrl}`;
    return this.http.post(url, registro);
  }
  eliminar(id: number): Observable<any> {
    const url: string = `${this._baseUrl}/${id}`;
    return this.http.delete(url);
  }
  getByTipoCategoria(id: number): Observable<any> {
    const url: string = `${this._baseUrl}/GetByTipoCategoria/${id}`;
    return this.http.get(url);
  }
  getByInstitucion(id: number): Observable<any> {
    const url: string = `${this._baseUrl}/GetByInstitucion/${id}`;
    return this.http.get(url);
  }
  getVista(): Observable<any> {
    const url: string = `${this._baseUrl}/GetVista`;
    return this.http.get(url);
  }

}
