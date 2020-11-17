using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_TextoCategoria : ISVC_TextoCategoria
    {
        readonly REP_TextoCategoria _repositorio;
        public SVC_TextoCategoria()
        {
            _repositorio = new REP_TextoCategoria();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public MDL_TextoCategoria Get(int id)
        {
            return _repositorio.Get(id);
        }

        public IEnumerable<MDL_TextoCategoria> Get()
        {
            return _repositorio.Get();
        }

        public IEnumerable<V_ListaRelacion> GetCategoriaPorTexto(int idTexto)
        {
            return _repositorio.GetCategoriaPorTexto(idTexto);
        }

        public IEnumerable<V_ListaRelacion> GetTextoPorCategoria(int idCategoria)
        {
            return _repositorio.GetTextoPorCategoria(idCategoria);
        }

        public void Post(MDL_TextoCategoria reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_TextoCategoria reg)
        {
            _repositorio.Put(id, reg);
        }
        
    }
}
