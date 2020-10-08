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
        public async void Delete(int id)
        {
             _repositorio.Delete(id);
        }

        public async Task<MDL_Usuario> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_Usuario>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<MDL_Usuario> Login(MDL_Login reg)
        {
            return await _repositorio.Login(reg);
        }

        public async void Post(MDL_Usuario reg)
        {
            _repositorio.Post(reg);
        }

        public async void Put(int id, MDL_Usuario reg)
        {
            _repositorio.Put(id, reg);
        }

        public async void Register(MDL_Usuario reg)
        {
            _repositorio.Register(reg);
        }
    }
}