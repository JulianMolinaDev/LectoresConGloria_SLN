﻿using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Formato : ISVC_Formato
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Formato()
        {
            _contexto = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public async void Delete(int id)
        {
            var entity = _contexto.TBL_Formatos.Find(id);
            _contexto.TBL_Formatos.Remove(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task<MDL_Formato> Get(int id)
        {
            var entity = await _contexto.TBL_Formatos.FindAsync(id);
            var output = _mapper.Map<MDL_Formato>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Formato>> Get()
        {
            var entity = await _contexto.TBL_Formatos.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Formato>>(entity);
            return output;
        }

        public async void Post(MDL_Formato reg)
        {
            var entity = _mapper.Map<TBL_Formatos>(reg);
            _contexto.TBL_Formatos.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public async void Put(int id, MDL_Formato reg)
        {
            var register = _mapper.Map<TBL_Formatos>(reg);
            var entity = await _contexto.TBL_Formatos.FindAsync(id);
            entity.Nombre = register.Nombre;
            _contexto.Entry(entity).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }
    }
}
