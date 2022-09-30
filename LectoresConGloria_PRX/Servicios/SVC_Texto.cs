using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_PRX.Proxies;
using System;
using System.Collections.Generic;


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
        public void Delete(int id)
        {
            var modelo = _proxie.Delete(id);
            modelo.Wait();
        }

        public MDL_Texto Get(int id)
        {
            var modelo = _proxie.Get(id);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<MDL_Texto> Get()
        {
            var modelo = _proxie.Get();
            modelo.Wait();
            return modelo.Result;
        }

        public V_TextoDetalle GetDetalle(int id)
        {
            _endpoint += "/GetDetalle";
            var prx = new PRX_Custom<V_TextoDetalle, int>(_url, _endpoint);
            var modelo = prx.Get(id);
            modelo.Wait();
            return modelo.Result;
        }

        public V_Lista GetItem(int id)
        {
            _endpoint += "/GetItem";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            var modelo = prx.Get(id);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_Lista> GetList()
        {
            _endpoint += "/GetList";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            var modelo = prx.Get();
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_TextoLista> GetListaMasClicks()
        {
            _endpoint += "/GetListaMasClicks";
            var prx = new PRX_Custom<V_TextoLista, int>(_url, _endpoint);
            var modelo = prx.Get();
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_Lista> GetListaPorTitulo(string titulo)
        {
            _endpoint += "/GetListaPorTitulo";
            var prx = new PRX_Custom<V_Lista, string>(_url, _endpoint);
            var modelo = prx.GetList(titulo);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_TextoLista> GetListaUltimos()
        {
            _endpoint += "/GetListaUltimos";
            var prx = new PRX_Custom<V_TextoLista, string>(_url, _endpoint);
            var modelo = prx.Get();
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_TextoLista> GetListaUltimosPorFecha(DateTime fecha)
        {
            _endpoint += "/GetListaUltimosPorFecha";
            var prx = new PRX_Custom<V_TextoLista, DateTime>(_url, _endpoint);
            var modelo = prx.GetList(fecha);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<MDL_Texto> GetUltimos(int cantidad)
        {
            _endpoint += "/GetUltimos";
            var prx = new PRX_Custom<MDL_Texto, int>(_url, _endpoint);
            var modelo = prx.GetList(cantidad);
            modelo.Wait();
            return modelo.Result;
        }

        public void Post(MDL_Texto reg)
        {
            var modelo = _proxie.Post(reg);
            modelo.Wait();
        }

        public void Put(int id, MDL_Texto reg)
        {
            var modelo = _proxie.Put(id, reg);
            modelo.Wait();
        }
    }
}