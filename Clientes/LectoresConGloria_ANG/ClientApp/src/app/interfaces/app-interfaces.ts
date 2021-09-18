export interface Categoria {
  id: number,
  nombre: string
}

export interface Click {
  id: number,
  idTexto: number,
  idUsuario: number,
  tipoClick: number,
  fechaAlta: Date
}

export interface Formato {
  id: number,
  nombre: string
}

export interface FormatoLibro {
  id: number,
  idLibro: number,
  idFormato: number,
  archivo: any
}

export interface Lector {
  id: number,
  nombre: string,
  apellidos: string,
  fechaNacimiento : Date,
  correo: string  ,
  password: string,
  fechaAlta: Date
}

export interface Libro {
  id: number,
  nombre: string,
  imagen : File
}

export interface Texto {
  id : number,
  titulo: string ,
  explicacion: string,
  audio : string
  archivo : string
}

export interface TextoCategoria {
  id: number,
  idTexto : number,
  idCategoria : number
}

export interface TextoLibro {
  id: number,
  idLibro: number,
  idTexto : number
}
