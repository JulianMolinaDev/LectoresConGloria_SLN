using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Click : ISVC_Click
    {
        private readonly REP_Click _repositorio;
        public SVC_Click()
        {
            _repositorio = new REP_Click();
        }
        public async void Write(MDL_Click reg)
        {
            _repositorio.Write(reg);
        }
    }
}
