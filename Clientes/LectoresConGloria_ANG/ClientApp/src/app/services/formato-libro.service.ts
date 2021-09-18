import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { FormatoLibro } from 'src/app/interfaces/app-interfaces';



@Injectable({
  providedIn: 'root'
})
export class FormatoLibroService {

  private _baseUrl: string = 'https://localhost:44340/api/FormatoLibros';
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
  insertar(registro: FormatoLibro): Observable<any> {

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
  getByTipoFormatoLibro(id: number): Observable<any> {
    const url: string = `${this._baseUrl}/GetByTipoFormatoLibro/${id}`;
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
