import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Formato } from 'src/app/interfaces/app-interfaces';


@Injectable({
  providedIn: 'root'
})
export class FormatoService {

  private _baseUrl: string = '';
  private _lista: Formato[] = [];
  private _cliente?: Formato;

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
  insertar(cliente: Formato) {

    cliente.id = this._lista.length + 1;
    console.log("insertar:", cliente);
    this._lista.push(cliente);
  }
  actualizar(cliente: Formato) {
    console.log("actualizar:", cliente);
    this._lista.forEach(element => {
      if (element.id === cliente.id) {
        element = cliente;
      }
    });
  }
  eliminar(id: number) {
    let arreglo: Formato[] = [];

    console.log("eliminar:", id);
    this._lista.forEach(element => {
      if (element.id !== id) {
        arreglo.push(element);
      }
    });
    this._lista = arreglo;
  }

}
