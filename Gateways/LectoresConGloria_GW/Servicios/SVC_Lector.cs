using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_GW.Proxies;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LectoresConGloria_GW.Servicios
{
    public class SVC_Lector : ISVC_Lector
    {
        readonly PRX_Generico<MDL_Lector, int> _proxie;
        private readonly string _url;
        private string _endpoint;
        public SVC_Lector()
        {
            _url = "";
            _endpoint = "";
            _proxie = new PRX_Generico<MDL_Lector, int>(_url, _endpoint);
        }
        public void Delete(int id)
        {
            var modelo = _proxie.Delete(id);
            modelo.Wait();
        }

        public MDL_Lector Get(int id)
        {
            var modelo = _proxie.Get(id);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<MDL_Lector> Get()
        {
            var modelo = _proxie.Get();
            modelo.Wait();
            return modelo.Result;
        }

        public MDL_Lector Login(MDL_Login reg)
        {
            _endpoint += "/Login";
            var prx = new PRX_Custom<MDL_Login, int>(_url, _endpoint);
            var modelo = prx.PostGet<MDL_Lector>(reg);
            modelo.Wait();
            return modelo.Result;
        }

        public void Post(MDL_Lector reg)
        {
            var modelo = _proxie.Post(reg);
            modelo.Wait();
        }

        public void Put(int id, MDL_Lector reg)
        {
            var modelo = _proxie.Put(id, reg);
            modelo.Wait();
        }

        public void Register(MDL_Lector reg)
        {
            _proxie.EndPoint = _endpoint + "/Register";
            var modelo = _proxie.Post(reg);
            modelo.Wait();
        }
    }

}
