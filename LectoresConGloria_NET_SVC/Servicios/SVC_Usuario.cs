using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Usuario : ISVC_Usuario
    {
        private readonly REP_Usuario _repositorio;
        public SVC_Usuario()
        {
            _repositorio = new REP_Usuario();
        }
        public void Delete(int id)
        {
             _repositorio.Delete(id);
        }

        public MDL_Usuario Get(int id)
        {
            return _repositorio.Get(id);
        }

        public IEnumerable<MDL_Usuario> Get()
        {
            return _repositorio.Get();
        }

        public MDL_Usuario Login(MDL_Login reg)
        {
            return _repositorio.Login(reg);
        }

        public void Post(MDL_Usuario reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Usuario reg)
        {
            _repositorio.Put(id, reg);
        }

        public void Register(MDL_Usuario reg)
        {
            _repositorio.Register(reg);
        }
    }
}