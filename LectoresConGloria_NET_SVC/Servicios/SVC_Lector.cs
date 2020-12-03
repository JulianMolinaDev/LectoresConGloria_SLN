using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Lector : ISVC_Lector
    {
        readonly REP_Lector _repositorio;
        public SVC_Lector()
        {
            _repositorio = new REP_Lector();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public MDL_Lector Get(int id)
        {
            return _repositorio.Get(id);
        }

        public IEnumerable<MDL_Lector> Get()
        {
            return _repositorio.Get();
        }

        public MDL_Lector Login(MDL_Login reg)
        {
            return _repositorio.Login(reg);
        }

        public void Post(MDL_Lector reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Lector reg)
        {
            _repositorio.Put(id, reg);
        }

        public void Register(MDL_Lector reg)
        {
            _repositorio.Register(reg);
        }
    }

}
