using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;

namespace LectoresConGloria_SVC.Repositorios.Interfaces
{
    interface IREP_Usuario : IRepositorio<MDL_Usuario, int>, ISecurity<MDL_Usuario, MDL_Login>
    {
    }
}
