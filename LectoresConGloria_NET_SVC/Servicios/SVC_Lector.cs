﻿using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Lector : ISVC_Lector
    {
        public async void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<MDL_Lector> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MDL_Lector>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<MDL_Lector> Login(MDL_Login reg)
        {
            throw new NotImplementedException();
        }

        public async void Post(MDL_Lector reg)
        {
            throw new NotImplementedException();
        }

        public async void Put(int id, MDL_Lector reg)
        {
            throw new NotImplementedException();
        }

        public async void Register(MDL_Lector reg)
        {
            throw new NotImplementedException();
        }
    }
}
