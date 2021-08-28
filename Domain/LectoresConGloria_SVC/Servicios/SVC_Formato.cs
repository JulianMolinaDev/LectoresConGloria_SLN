using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LectoresConGloria_SVC.Data.Entidades;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Formato : ISVC_Formato
    {
        readonly REP_Formato _repositorio;
        public SVC_Formato(LectoresConGloria_Context context)
        {
            _repositorio = new REP_Formato(context);
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public MDL_Formato Get(int id)
        {
            return _repositorio.Get(id);
        }

        public IEnumerable<MDL_Formato> Get()
        {
            return _repositorio.Get();
        }

        public V_Lista GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<V_Lista> GetList()
        {
            return _repositorio.GetList();
        }

        public void Post(MDL_Formato reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Formato reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
