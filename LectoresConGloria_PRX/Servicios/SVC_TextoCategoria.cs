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
        public void Delete(int id)
        {
            var modelo = _proxie.Delete(id);
            modelo.Wait();
        }

        public IEnumerable<V_Lista> GetFaltantesCategoriasPorTexto(int idTexto)
        {
            _endpoint += "/GetFaltantesCategoriasPorTexto";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            var modelo = prx.GetList(idTexto);
            modelo.Wait();
            return modelo.Result;
        }

        public MDL_TextoCategoria Get(int id)
        {
            var modelo = _proxie.Get(id);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<MDL_TextoCategoria> Get()
        {
            var modelo = _proxie.Get();
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_ListaRelacion> GetCategoriaPorTexto(int idTexto)
        {
            _endpoint += "/GetCategoriaPorTexto";
            var prx = new PRX_Custom<V_ListaRelacion, int>(_url, _endpoint);
            var modelo = prx.GetList(idTexto);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_ListaRelacion> GetTextoPorCategoria(int idCategoria)
        {
            _endpoint += "/GetTextoPorCategoria";
            var prx = new PRX_Custom<V_ListaRelacion, int>(_url, _endpoint);
            var modelo = prx.GetList(idCategoria);
            modelo.Wait();
            return modelo.Result;
        }

        public void Post(MDL_TextoCategoria reg)
        {
            var modelo = _proxie.Post(reg);
            modelo.Wait();
        }

        public void Put(int id, MDL_TextoCategoria reg)
        {
            var modelo = _proxie.Put(id, reg);
            modelo.Wait();
        }

        public V_AsociacionDetalle GetAsociacionDetalle(int id)
        {
            _endpoint += "/GetAsociacionDetalle";
            var prx = new PRX_Custom<V_AsociacionDetalle, int>(_url, _endpoint);
            var modelo = prx.Get(id);
            modelo.Wait();
            return modelo.Result;
        }
    }
}
