using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_PRX.Proxies;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LectoresConGloria_PRX.Servicios
{
    public class SVC_TextoLibro : ISVC_TextoLibro
    {
        readonly PRX_Generico<MDL_TextoLibro, int> _proxie;
        private readonly string _url;
        private string _endpoint;

        public SVC_TextoLibro()
        {
            _url = "";
            _endpoint = "";
            _proxie = new PRX_Generico<MDL_TextoLibro, int>(_url, _endpoint);
        }
        public async Task Delete(int id)
        {
            await _proxie.Delete(id);
            
        }

        public async Task<MDL_TextoLibro> Get(int id)
        {
            return await _proxie.Get(id);
            
            
        }

        public async Task<IEnumerable<MDL_TextoLibro>> Get()
        {
            return await _proxie.Get();
            
            
        }

        public async Task<V_AsociacionDetalle> GetAsociacionDetalle(int id)
        {
            _endpoint += "/GetAsociacionDetalle";
            var prx = new PRX_Custom<V_AsociacionDetalle, int>(_url, _endpoint);
            return await  prx.Get(id);
            
            
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetTextosPorLibro(int idLibro)
        {
            _endpoint += "/GetTextosPorLibro";
            var prx = new PRX_Custom<V_ListaRelacion, int>(_url, _endpoint);
            return await  prx.GetList(idLibro);
            
            
        }

        public async Task Post(MDL_TextoLibro reg)
        {
            await _proxie.Post(reg);
            
        }

        public async Task Put(int id, MDL_TextoLibro reg)
        {
            await _proxie.Put(id, reg);
            
        }

        public async Task TextoDesdeLibro(int idLibro, MDL_Texto texto)
        {
            _endpoint += "/TextoDesdeLibro";
            var prx = new PRX_Generico<MDL_Texto, int>(_url, _endpoint);
            await  prx.Put(idLibro, texto);
            
        }
    }
}
