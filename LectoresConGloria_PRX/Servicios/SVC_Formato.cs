﻿using LectoresConGloria_FWK.Interfaces;
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
        public async Task Delete(int id)
        {
            await _proxie.Delete(id);
            
        }

        public async Task<MDL_Formato> Get(int id)
        {
            return await _proxie.Get(id);
            
            
        }

        public async Task<IEnumerable<MDL_Formato>> Get()
        {
            return await _proxie.Get();
            
            
        }

        public async Task<V_Lista> GetItem(int id)
        {
            _endpoint += "/GetItem";
            var prx = new PRX_Custom<V_Lista,int>(_url,_endpoint);
            return await  prx.Get(id);
            
            
        }

        public async Task<IEnumerable<V_Lista>> GetList()
        {
            _endpoint += "/GetList";
            var prx = new PRX_Custom<V_Lista, int>(_url, _endpoint);
            return await  prx.Get();
            
            
        }

        public async Task Post(MDL_Formato reg)
        {
            await _proxie.Post(reg);
            
        }

        public async Task Put(int id, MDL_Formato reg)
        {
            await _proxie.Put(id, reg);
            
        }
    }
}
