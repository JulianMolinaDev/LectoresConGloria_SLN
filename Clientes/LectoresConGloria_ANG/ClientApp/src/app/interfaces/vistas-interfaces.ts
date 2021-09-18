export interface V_Asociacion {
  izquierda : number,
  derecha : number
}

export interface V_AsociacionDetalle extends V_Asociacion {
  id : number,
  derechaTexto : string,
  izquierdaTexto : string
}

export interface V_DetalleItemLista {
   padre: V_Lista, 
   detalle : V_Lista[]
}

export interface V_LibroDescarga {
  nombre : string,
  tipo : string ,
  archivo : string 
}

export interface V_Lista {
  id: number,
  nombre: string
}

export interface V_ListaRelacion extends V_Lista {
  idForanea: number
}

export interface V_TextoDetalle {
  id: number,
  titulo: string,
  texto : string,
  audio : boolean,
  explicacion : boolean,
  vistas: number
}

export interface V_TextoLista extends V_Lista { 
  urlDescripcion : string  
}
