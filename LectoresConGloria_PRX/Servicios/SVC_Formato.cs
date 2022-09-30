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
    public class SVC_Formato : ISVC_Formato
    {
        private readonly PRX_Generico<MDL_Formato, int> _proxie;
        private readonly string _url;
        private string _endpoint;

        public SVC_Formato()
        {
            _url = "";
            _endpoint = "";
            _proxie = new PRX_Generico<MDL_Formato, int>(_url, _endpoint);
        }
        public void Delete(int id)
        {
            var modelo = _proxie.Delete(id);
            modelo.Wait();
        }

        public MDL_Formato Get(int id)
        {
            var modelo = _proxie.Get(id);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<MDL_Formato> Get()
        {
            var modelo = _proxie.Get();
            modelo.Wait();
            return modelo.Result;
        }

        public V_Lista GetItem(int id)
        {
            _endpoint += "/GetItem";
            var prx = new PRX_Custom<V_Lista,int>(_url,_endpoint);
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

        public void Post(MDL_Formato reg)
        {
            var modelo = _proxie.Post(reg);
            modelo.Wait();
        }

        public void Put(int id, MDL_Formato reg)
        {
            var modelo = _proxie.Put(id, reg);
            modelo.Wait();
        }
    }
}
