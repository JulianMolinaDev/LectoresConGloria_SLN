using LectoresConGloria_MDL.Modelos;

namespace LectoresConGloria_SVC.Interfaces
{
    public interface ISVC_Lector : IServicio<MDL_Lector, int>,
        ISecurity<MDL_Lector, MDL_Login>
    {
    }
}
