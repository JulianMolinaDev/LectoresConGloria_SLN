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
    class REP_Usuario : ISVC_Usuario
    {
        readonly LectoresConGloria_Context _context;
        readonly IMapper _mapper;
        public REP_Usuario()
        {
            _context = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public async void Delete(int id)
        {
            var entity = await _context.TBL_Usuarios.FindAsync(id);
            _context.TBL_Usuarios.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async void Post(MDL_Usuario item)
        {
            var entity = _mapper.Map<TBL_Usuarios>(item);
            _context.TBL_Usuarios.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<MDL_Usuario> Login(MDL_Login reg)
        {
            var entity = await _context.TBL_Usuarios.SqlQuery("", new { reg.Usuario, reg.Password })
                .FirstOrDefaultAsync();
            var output = _mapper.Map<MDL_Usuario>(entity);
            return output;
        }

        public async void Register(MDL_Usuario reg)
        {
            var output = await _context.Database.ExecuteSqlCommandAsync("",
                new { reg.Nombre, reg.Apellidos, reg.Correo, reg.FechaNacimiento, reg.Password });
        }

        public async Task<MDL_Usuario> Get(int id)
        {
            var entity = await _context.TBL_Usuarios.FindAsync(id);
            var output = _mapper.Map<MDL_Usuario>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Usuario>> Get()
        {
            var entity = await _context.TBL_Usuarios.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Usuario>>(entity);
            return output;
        }

        public async void Put(int id, MDL_Usuario item)
        {
            throw new NotImplementedException();
        }
    }
}
