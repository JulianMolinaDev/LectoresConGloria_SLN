import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TextoLibro } from 'src/app/interfaces/app-interfaces';


@Injectable({
  providedIn: 'root'
})
export class TextoLibroService {

  private _baseUrl: string = '';
  private _lista: TextoLibro[] = [];
  private _cliente?: TextoLibro;

  get lista() {
    return [...this._lista];
  }

  constructor(private http: HttpClient) {
  }
  buscar(busqueda: string) {
    console.log("generar busqueda:", busqueda);
  }
  obtener(id: number) {
    console.log("obtener:", id);
    this._lista.forEach(element => {
      if (element.id === id) {
        this._cliente = element;
      }
    });
    console.log("obtenido:", this._cliente);

  }
  insertar(cliente: TextoLibro) {

    cliente.id = this._lista.length + 1;
    console.log("insertar:", cliente);
    this._lista.push(cliente);
  }
  actualizar(cliente: TextoLibro) {
    console.log("actualizar:", cliente);
    this._lista.forEach(element => {
      if (element.id === cliente.id) {
        element = cliente;
      }
    });
  }
  eliminar(id: number) {
    let arreglo: TextoLibro[] = [];

    console.log("eliminar:", id);
    this._lista.forEach(element => {
      if (element.id !== id) {
        arreglo.push(element);
      }
    });
    this._lista = arreglo;
  }

}
