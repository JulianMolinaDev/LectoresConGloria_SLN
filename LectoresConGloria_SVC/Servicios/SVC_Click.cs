using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using LectoresConGloria_SVC.Repositorios.Interfaces;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Click : ISVC_Click
    {
        private readonly IREP_Click _repositorio;
        public SVC_Click()
        {
            _repositorio = new REP_Click();
        }
        public async Task<bool> Write(MDL_Click reg)
        {
            return await _repositorio.Write(reg);
        }
    }
}
