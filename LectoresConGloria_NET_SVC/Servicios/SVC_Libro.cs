using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Libro : ISVC_Libro
    {
        readonly REP_Libro _repositorio;
        public SVC_Libro()
        {
            _repositorio = new REP_Libro();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public MDL_Libro Get(int id)
        {
            return _repositorio.Get(id);
        }

        public IEnumerable<MDL_Libro> Get()
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

        public IEnumerable<V_Lista> GetListaUltimos(int cantidad)
        {
            return _repositorio.GetListaUltimos(cantidad);
        }

        public IEnumerable<V_Lista> GetListByNombre(string nombre)
        {
            return _repositorio.GetListByNombre(nombre);
        }

        public void Post(MDL_Libro reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Libro reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
