using LectoresConGloria_MDL.Modelos;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_Usuario : IServicio<MDL_Usuario, int>,
        ISecurity<MDL_Usuario, MDL_Login>
    {

    }
}
