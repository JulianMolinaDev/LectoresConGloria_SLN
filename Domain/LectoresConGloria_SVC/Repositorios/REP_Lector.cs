﻿using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Lector : ISVC_Lector
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Lector(LectoresConGloria_Context context)
        {
            _contexto = context;
            _mapper = Automapeo.Instance;
        }
        public void Delete(int id)
        {
            var entity = _contexto.TBL_Lectores.Find(id);
            _contexto.TBL_Lectores.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Post(MDL_Lector item)
        {
            var entity = _mapper.Map<TBL_Lectores>(item);
            _contexto.TBL_Lectores.Add(entity);
            _contexto.SaveChanges();
        }

        public MDL_Lector Login(MDL_Login reg)
        {
            var entity = _contexto.TBL_Lectores.FromSqlRaw("", new { reg.Usuario, reg.Password })
                .FirstOrDefaultAsync();
            var output = _mapper.Map<MDL_Lector>(entity);
            return output;
        }

        public void Register(MDL_Lector reg)
        {
            _contexto.Database.ExecuteSqlRaw("",
                new { reg.Nombre, reg.Apellidos, reg.Correo, reg.FechaNacimiento, reg.Password });
        }

        public MDL_Lector Get(int id)
        {
            var entity = _contexto.TBL_Lectores.Find(id);
            var output = _mapper.Map<MDL_Lector>(entity);
            return output;
        }

        public IEnumerable<MDL_Lector> Get()
        {
            var entity = _contexto.TBL_Lectores
                .AsNoTracking()
                .ToList();
            var output = _mapper.Map<IEnumerable<MDL_Lector>>(entity);
            return output;
        }

        public void Put(int id, MDL_Lector item)
        {
            throw new NotImplementedException();
        }
    }
}
