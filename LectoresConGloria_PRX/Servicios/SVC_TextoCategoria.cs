using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_PRX.Proxies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace LectoresConGloria_PRX.Servicios
{
    public class SVC_TextoCategoria : ISVC_TextoCategoria
    {
        readonly PRX_Generico<MDL_TextoCategoria, int> _proxie;
        private readonly string _url;
        private string _endpoint;

        public SVC_TextoCategoria()
        {
            _url = "";
            _endpoint = "";
            _proxie = new PRX_Generico<MDL_TextoCategoria, int>(_url, _endpoint);
        }
        public async Task Delete(int id)
        {
            await _proxie.Delete(id);
            
        }

        public async Task<IEnumerable<V_Lista>> GetFaltantesCategoriasPorTexto(int idTexto)
        {
            _endpoint += "/GetFaltantesCategoriasPorTexto";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            return await  prx.GetList(idTexto);
            
            
        }

        public async Task<MDL_TextoCategoria> Get(int id)
        {
            return await _proxie.Get(id);
            
            
        }

        public async Task<IEnumerable<MDL_TextoCategoria>> Get()
        {
            return await _proxie.Get();
            
            
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetCategoriaPorTexto(int idTexto)
        {
            _endpoint += "/GetCategoriaPorTexto";
            var prx = new PRX_Custom<V_ListaRelacion, int>(_url, _endpoint);
            return await  prx.GetList(idTexto);
            
            
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetTextoPorCategoria(int idCategoria)
        {
            _endpoint += "/GetTextoPorCategoria";
            var prx = new PRX_Custom<V_ListaRelacion, int>(_url, _endpoint);
            return await  prx.GetList(idCategoria);
            
            
        }

        public async Task Post(MDL_TextoCategoria reg)
        {
            await _proxie.Post(reg);
            
        }

        public async Task Put(int id, MDL_TextoCategoria reg)
        {
            await _proxie.Put(id, reg);
            
        }

        public async Task<V_AsociacionDetalle> GetAsociacionDetalle(int id)
        {
            _endpoint += "/GetAsociacionDetalle";
            var prx = new PRX_Custom<V_AsociacionDetalle, int>(_url, _endpoint);
            return await  prx.Get(id);
            
            
        }
    }
}
