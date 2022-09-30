using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_PRX.Proxies;
using System.Threading.Tasks;

namespace LectoresConGloria_PRX.Servicios
{
    public class SVC_Click : ISVC_Click
    {
        private readonly PRX_Generico<MDL_Click, int> _proxie;
        public SVC_Click()
        {
            _proxie = new PRX_Generico<MDL_Click, int>("","");
        }
        public void Write(MDL_Click reg)
        {
            var modelo = _proxie.Post(reg);
            modelo.Wait();
        }
    }
}
