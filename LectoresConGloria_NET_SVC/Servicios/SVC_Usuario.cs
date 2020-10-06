using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using LectoresConGloria_SVC.Repositorios.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Usuario : ISVC_Usuario
    {
        private readonly IREP_Usuario _repositorio;
        public SVC_Usuario()
        {
            _repositorio = new REP_Usuario();
        }
        public async void Delete(int id)
        {
            return await _repositorio.Delete(id);
        }

        public async Task<MDL_Usuario> Get(int id)
        {
            return await _repositorio.Select(id);
        }

        public async Task<IEnumerable<MDL_Usuario>> Get()
        {
            return await _repositorio.Select();
        }

        public async Task<MDL_Usuario> Login(MDL_Login reg)
        {
            return await _repositorio.Login(reg);
        }

        public async void Post(MDL_Usuario reg)
        {
            return await _repositorio.Insert(reg);
        }

        public async void Put(int id, MDL_Usuario reg)
        {
            return await _repositorio.Update(id, reg);
        }

        public async void Register(MDL_Usuario reg)
        {
            return await _repositorio.Register(reg);
        }
    }
}