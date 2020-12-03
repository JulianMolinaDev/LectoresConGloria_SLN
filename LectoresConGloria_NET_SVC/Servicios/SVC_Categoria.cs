using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Categoria : ISVC_Categoria
    {
        readonly REP_Categoria _repositorio;
        public SVC_Categoria()
        {
            _repositorio = new REP_Categoria();
        }
        public void Delete(int id)
        {
           _repositorio.Delete(id);
        }

        public MDL_Categoria Get(int id)
        {
            return _repositorio.Get(id);
        }

        public IEnumerable<MDL_Categoria> Get()
        {
            return _repositorio.Get();
        }

        public V_Lista GetItem(int id)
        {
            return _repositorio.GetItem(id);
        }

        public IEnumerable<V_Lista> GetList()
        {
            return _repositorio.GetList();
        }

        public void Post(MDL_Categoria reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Categoria reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
