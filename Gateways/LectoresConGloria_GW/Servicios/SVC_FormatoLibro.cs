using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Enumerados;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_GW.Proxies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_GW.Servicios
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
        public void Delete(int id)
        {
            var modelo = _proxie.Delete(id);
            modelo.Wait();
        }

        public IEnumerable<V_Lista> GetFaltantesFormatosByLibro(int idLibro)
        {
            _endpoint += "/GetFaltantesFormatosByLibro";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            var modelo = prx.GetList(idLibro);
            modelo.Wait();
            return modelo.Result;
        }

        public MDL_FormatoLibro Get(int id)
        {
            var modelo = _proxie.Get(id);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<MDL_FormatoLibro> Get()
        {
            var modelo = _proxie.Get();
            modelo.Wait();
            return modelo.Result;
        }

        public V_LibroDescarga GetContenido(int idFormatoLibro)
        {
            _endpoint += "/GetContenido";
            var prx = new PRX_Custom<V_LibroDescarga, int>(_url, _endpoint);
            var modelo = prx.Get(idFormatoLibro);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_ListaRelacion> GetFormatosByLibro(int idLibro)
        {
            _endpoint += "/GetFormatosByLibro";
            var prx = new PRX_Custom<V_ListaRelacion, int>(_url, _endpoint);
            var modelo = prx.GetList(idLibro);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_ListaRelacion> GetLibrosByFormato(int idFormato)
        {
            _endpoint += "/GetLibrosByFormato";
            var prx = new PRX_Custom<V_ListaRelacion, int>(_url, _endpoint);
            var modelo = prx.GetList(idFormato);
            modelo.Wait();
            return modelo.Result;
        }

        public void Post(MDL_FormatoLibro reg)
        {
            var modelo = _proxie.Post(reg);
            modelo.Wait();
        }

        public void Put(int id, MDL_FormatoLibro reg)
        {
            var modelo = _proxie.Put(id, reg);
            modelo.Wait();
        }

        public V_Lista GetLibroAsItem(int idFormatoLibro)
        {
            _endpoint += "/GetLibroAsItem";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            var modelo = prx.Get(idFormatoLibro);
            modelo.Wait();
            return modelo.Result;
        }

        public V_Lista GetFormatoAsItem(int idFormatoLibro)
        {
            _endpoint += "/GetFormatoAsItem";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            var modelo = prx.Get(idFormatoLibro);
            modelo.Wait();
            return modelo.Result;
        }

        public void CambiarContenido(int idFormatoLibro, string contenido)
        {
            //TODO: Hacer
        }

        public void CambiarFormato(int idFormatoLibro, int idFormato)
        {
            //TODO: Hacer
        }

        public V_AsociacionDetalle GetAsociacionDetalle(int idFormatoLibro)
        {
            _endpoint += "/GetAsociacionDetalle";
            var prx = new PRX_Custom<V_AsociacionDetalle, int>(_url, _endpoint);
            var modelo = prx.Get(idFormatoLibro);
            modelo.Wait();
            return modelo.Result;
        }
    }
}
