using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Enumerados;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_PRX.Proxies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_PRX.Servicios
{
    public class SVC_FormatoLibro : ISVC_FormatoLibro
    {
        readonly PRX_Generico<MDL_FormatoLibro, int> _proxie;
        private readonly string _url;
        private string _endpoint;

        public SVC_FormatoLibro()
        {
            _url = "";
            _endpoint = "";
            _proxie = new PRX_Generico<MDL_FormatoLibro, int>("","");
        }
        public async Task Delete(int id)
        {
            await _proxie.Delete(id);
            
        }

        public async Task<IEnumerable<V_Lista>> GetFaltantesFormatosByLibro(int idLibro)
        {
            _endpoint += "/GetFaltantesFormatosByLibro";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            return await  prx.GetList(idLibro);
            
            
        }

        public async Task<MDL_FormatoLibro> Get(int id)
        {
            return await _proxie.Get(id);
            
            
        }

        public async Task<IEnumerable<MDL_FormatoLibro>> Get()
        {
            return await _proxie.Get();
            
            
        }

        public async Task<V_LibroDescarga> GetContenido(int idFormatoLibro)
        {
            _endpoint += "/GetContenido";
            var prx = new PRX_Custom<V_LibroDescarga, int>(_url, _endpoint);
            return await  prx.Get(idFormatoLibro);
            
            
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetFormatosByLibro(int idLibro)
        {
            _endpoint += "/GetFormatosByLibro";
            var prx = new PRX_Custom<V_ListaRelacion, int>(_url, _endpoint);
            return await  prx.GetList(idLibro);
            
            
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetLibrosByFormato(int idFormato)
        {
            _endpoint += "/GetLibrosByFormato";
            var prx = new PRX_Custom<V_ListaRelacion, int>(_url, _endpoint);
            return await  prx.GetList(idFormato);
            
            
        }

        public async Task Post(MDL_FormatoLibro reg)
        {
            await _proxie.Post(reg);
            
        }

        public async Task Put(int id, MDL_FormatoLibro reg)
        {
            await _proxie.Put(id, reg);
            
        }

        public async Task<V_Lista> GetLibroAsItem(int idFormatoLibro)
        {
            _endpoint += "/GetLibroAsItem";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            return await  prx.Get(idFormatoLibro);
            
            
        }

        public async Task<V_Lista> GetFormatoAsItem(int idFormatoLibro)
        {
            _endpoint += "/GetFormatoAsItem";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            return await  prx.Get(idFormatoLibro);
            
            
        }

        public async Task CambiarContenido(int idFormatoLibro, string contenido)
        {
            //TODO: Hacer
        }

        public async Task CambiarFormato(int idFormatoLibro, int idFormato)
        {
            //TODO: Hacer
        }

        public async Task<V_AsociacionDetalle> GetAsociacionDetalle(int idFormatoLibro)
        {
            _endpoint += "/GetAsociacionDetalle";
            var prx = new PRX_Custom<V_AsociacionDetalle, int>(_url, _endpoint);
            return await  prx.Get(idFormatoLibro);
            
            
        }
    }
}
