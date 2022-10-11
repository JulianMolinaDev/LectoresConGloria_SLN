using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_PRX.Proxies;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LectoresConGloria_PRX.Servicios
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
        public async Task Delete(int id)
        {
            await _proxie.Delete(id);
            
        }

        public async Task<MDL_Lector> Get(int id)
        {
            return await _proxie.Get(id);
            
            
        }

        public async Task<IEnumerable<MDL_Lector>> Get()
        {
            return await _proxie.Get();
            
            
        }

        public async Task<MDL_Lector> Login(MDL_Login reg)
        {
            _endpoint += "/Login";
            var prx = new PRX_Custom<MDL_Login, int>(_url, _endpoint);
            return await  prx.PostGet<MDL_Lector>(reg);
            
            
        }

        public async Task Post(MDL_Lector reg)
        {
            await _proxie.Post(reg);
            
        }

        public async Task Put(int id, MDL_Lector reg)
        {
            await _proxie.Put(id, reg);
            
        }

        public async Task Register(MDL_Lector reg)
        {
            _proxie.EndPoint = _endpoint + "/Register";
            await _proxie.Post(reg);
            
        }
    }

}
