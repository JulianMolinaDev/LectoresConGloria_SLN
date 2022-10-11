using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_PRX.Proxies;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LectoresConGloria_PRX.Servicios
{
    public class SVC_Libro : ISVC_Libro
    {
        readonly PRX_Generico<MDL_Libro, int> _proxie;
        private readonly string _url;
        private string _endpoint;

        public SVC_Libro()
        {
            _url = "";
            _endpoint = "";
            _proxie = new PRX_Generico<MDL_Libro, int>(_url, _endpoint);
        }
        public async Task Delete(int id)
        {
            await _proxie.Delete(id);
            
        }

        public async Task<MDL_Libro> Get(int id)
        {
            return await _proxie.Get(id);
            
            
        }

        public async Task<IEnumerable<MDL_Libro>> Get()
        {
            return await _proxie.Get();
            
            
        }

        public async Task<V_Lista> GetItem(int id)
        {
            _endpoint += "/GetItem";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            return await  prx.Get(id);
            
            
        }

        public async Task<IEnumerable<V_Lista>> GetList()
        {
            _endpoint += "/GetList";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            return await  prx.Get();
            
            
        }

        public async Task<IEnumerable<V_Lista>> GetListaUltimos(int cantidad)
        {
            _endpoint += "/GetListaUltimos";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            return await  prx.GetList(cantidad);
            
            
        }

        public async Task<IEnumerable<V_Lista>> GetListByNombre(string nombre)
        {
            _endpoint += "/GetListByNombre";
            var prx = new PRX_Custom<V_Lista, string>(_url, _endpoint);
            return await  prx.GetList(nombre);
            
            
        }

        public async Task Post(MDL_Libro reg)
        {
            await _proxie.Post(reg);
            
        }

        public async Task Put(int id, MDL_Libro reg)
        {
            await _proxie.Put(id, reg);
            
        }
    }
}
