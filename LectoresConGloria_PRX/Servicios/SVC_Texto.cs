using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_PRX.Proxies;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_PRX.Servicios
{
    public class SVC_Texto : ISVC_Texto
    {
        readonly PRX_Generico<MDL_Texto, int> _proxie;
        private readonly string _url;
        private string _endpoint;

        public SVC_Texto()
        {
            _url = "";
            _endpoint = "";
            _proxie = new PRX_Generico<MDL_Texto, int>(_url, _endpoint);
        }
        public async Task Delete(int id)
        {
            await _proxie.Delete(id);
            
        }

        public async Task<MDL_Texto> Get(int id)
        {
            return await _proxie.Get(id);
            
            
        }

        public async Task<IEnumerable<MDL_Texto>> Get()
        {
            return await _proxie.Get();
            
            
        }

        public async Task<V_TextoDetalle> GetDetalle(int id)
        {
            _endpoint += "/GetDetalle";
            var prx = new PRX_Custom<V_TextoDetalle, int>(_url, _endpoint);
            return await  prx.Get(id);
            
            
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

        public async Task<IEnumerable<V_TextoLista>> GetListaMasClicks()
        {
            _endpoint += "/GetListaMasClicks";
            var prx = new PRX_Custom<V_TextoLista, int>(_url, _endpoint);
            return await  prx.Get();
            
            
        }

        public async Task<IEnumerable<V_Lista>> GetListaPorTitulo(string titulo)
        {
            _endpoint += "/GetListaPorTitulo";
            var prx = new PRX_Custom<V_Lista, string>(_url, _endpoint);
            return await  prx.GetList(titulo);
            
            
        }

        public async Task<IEnumerable<V_TextoLista>> GetListaUltimos()
        {
            _endpoint += "/GetListaUltimos";
            var prx = new PRX_Custom<V_TextoLista, string>(_url, _endpoint);
            return await  prx.Get();
            
            
        }

        public async Task<IEnumerable<V_TextoLista>> GetListaUltimosPorFecha(DateTime fecha)
        {
            _endpoint += "/GetListaUltimosPorFecha";
            var prx = new PRX_Custom<V_TextoLista, DateTime>(_url, _endpoint);
            return await  prx.GetList(fecha);
            
            
        }

        public async Task<IEnumerable<MDL_Texto>> GetUltimos(int cantidad)
        {
            _endpoint += "/GetUltimos";
            var prx = new PRX_Custom<MDL_Texto, int>(_url, _endpoint);
            return await  prx.GetList(cantidad);
            
            
        }

        public async Task Post(MDL_Texto reg)
        {
            await _proxie.Post(reg);
            
        }

        public async Task Put(int id, MDL_Texto reg)
        {
            await _proxie.Put(id, reg);
            
        }
    }
}