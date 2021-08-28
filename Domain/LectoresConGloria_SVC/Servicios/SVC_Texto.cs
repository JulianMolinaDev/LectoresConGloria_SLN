using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using LectoresConGloria_SVC.Data.Entidades;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Texto : ISVC_Texto
    {
        private readonly REP_Texto _repositorio;
        public SVC_Texto(LectoresConGloria_Context context)
        {
            _repositorio = new REP_Texto(context);
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public MDL_Texto Get(int id)
        {
            return _repositorio.Get(id);
        }

        public IEnumerable<MDL_Texto> Get()
        {
            return _repositorio.Get();
        }

        public V_TextoDetalle GetDetalle(int id)
        {
            return _repositorio.GetDetalle(id);
        }

        public V_Lista GetItem(int id)
        {
            return _repositorio.GetItem(id);
        }

        public IEnumerable<V_Lista> GetList()
        {
            return _repositorio.GetList();
        }

        public IEnumerable<V_TextoLista> GetListaMasClicks()
        {
            return _repositorio.GetListaMasClicks();
        }

        public IEnumerable<V_Lista> GetListaPorTitulo(string titulo)
        {
            return _repositorio.GetListaPorTitulo(titulo);
        }

        public IEnumerable<V_TextoLista> GetListaUltimos()
        {
            return _repositorio.GetListaUltimos();
        }

        public IEnumerable<V_TextoLista> GetListaUltimosPorFecha(DateTime fecha)
        {
            return _repositorio.GetListaUltimosPorFecha(fecha);
        }

        public IEnumerable<MDL_Texto> GetUltimos(int cantidad)
        {
            return _repositorio.GetUltimos(cantidad);
        }

        public void Post(MDL_Texto reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Texto reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}