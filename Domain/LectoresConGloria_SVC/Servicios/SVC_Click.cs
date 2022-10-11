using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using System.Threading.Tasks;
using LectoresConGloria_SVC.Data;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Click : ISVC_Click
    {
        private readonly REP_Click _repositorio;
        public SVC_Click(LectoresConGloria_Context context)
        {
            _repositorio = new REP_Click(context);
        }
        public async Task Write(MDL_Click reg)
        {
            await _repositorio.Write(reg);
        }
    }
}
