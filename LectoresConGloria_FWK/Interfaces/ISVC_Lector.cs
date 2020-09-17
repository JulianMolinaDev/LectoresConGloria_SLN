using LectoresConGloria_MDL.Modelos;

namespace LectoresConGloria_FWK.Interfaces
{
    interface ISVC_Lector : IServicio<MDL_Lector, int>,
        ISecurity<MDL_Lector, MDL_Login>
    {
    }
}
