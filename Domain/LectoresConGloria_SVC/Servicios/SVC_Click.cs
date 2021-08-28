using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using System.Threading.Tasks;
using LectoresConGloria_SVC.Data.Entidades;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Click : ISVC_Click
    {
        private readonly REP_Click _repositorio;
        public SVC_Click(LectoresConGloria_Context context)
        {
            _repositorio = new REP_Click(context);
        }
        public void Write(MDL_Click reg)
        {
            _repositorio.Write(reg);
        }
    }
}
