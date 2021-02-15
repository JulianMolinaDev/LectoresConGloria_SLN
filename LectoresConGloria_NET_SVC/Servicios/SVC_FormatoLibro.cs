using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Enumerados;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_FormatoLibro : ISVC_FormatoLibro
    {
        readonly REP_FormatoLibro _repositorio;
        public SVC_FormatoLibro()
        {
            _repositorio = new REP_FormatoLibro();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public IEnumerable<V_Lista> FaltantesFormatosByLibro(int idLibro)
        {
            return _repositorio.FaltantesFormatosByLibro(idLibro);
        }

        public MDL_FormatoLibro Get(int id)
        {
            return _repositorio.Get(id);
        }

        public IEnumerable<MDL_FormatoLibro> Get()
        {
            return _repositorio.Get();
        }

        public V_LibroDescarga GetContenido(int idFormatoLibro)
        {
            return _repositorio.GetContenido(idFormatoLibro);
        }

        public IEnumerable<V_ListaRelacion> GetFormatosByLibro(int idLibro)
        {
            return _repositorio.GetFormatosByLibro(idLibro);
        }

        public IEnumerable<V_ListaRelacion> GetLibrosByFormato(int idFormato)
        {
            return _repositorio.GetLibrosByFormato(idFormato);
        }

        public void Post(MDL_FormatoLibro reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_FormatoLibro reg)
        {
            _repositorio.Put(id, reg);
        }

        public V_Lista GetLibroAsItem(int idFormatoLibro)
        {
            return _repositorio.GetLibroAsItem(idFormatoLibro);
        }

        public V_Lista GetFormatoAsItem(int idFormatoLibro)
        {
            return _repositorio.GetFormatoAsItem(idFormatoLibro);
        }

        public void CambiarContenido(int idFormatoLibro, string contenido)
        {
            _repositorio.CambiarContenido(idFormatoLibro, contenido);
        }

        public void CambiarFormato(int idFormatoLibro, int idFormato)
        {
            _repositorio.CambiarFormato(idFormatoLibro, idFormato);
        }

        public V_AsociacionDetalle GetAsociacionDetalle(int idFormatoLibro)
        {
            return _repositorio.GetAsociacionDetalle(idFormatoLibro);
        }
    }
}
