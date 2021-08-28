using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_GW.Proxies;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LectoresConGloria_GW.Servicios
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
        public void Delete(int id)
        {
            var modelo = _proxie.Delete(id);
            modelo.Wait();
        }

        public MDL_Libro Get(int id)
        {
            var modelo = _proxie.Get(id);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<MDL_Libro> Get()
        {
            var modelo = _proxie.Get();
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

        public IEnumerable<V_Lista> GetListaUltimos(int cantidad)
        {
            _endpoint += "/GetListaUltimos";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            var modelo = prx.GetList(cantidad);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_Lista> GetListByNombre(string nombre)
        {
            _endpoint += "/GetListByNombre";
            var prx = new PRX_Custom<V_Lista, string>(_url, _endpoint);
            var modelo = prx.GetList(nombre);
            modelo.Wait();
            return modelo.Result;
        }

        public void Post(MDL_Libro reg)
        {
            var modelo = _proxie.Post(reg);
            modelo.Wait();
        }

        public void Put(int id, MDL_Libro reg)
        {
            var modelo = _proxie.Put(id, reg);
            modelo.Wait();
        }
    }
}
