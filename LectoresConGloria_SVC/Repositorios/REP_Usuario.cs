using AutoMapper;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using LectoresConGloria_SVC.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Usuario : IREP_Usuario
    {
        readonly LectoresConGloria_Context _context;
        readonly IMapper _mapper;
        public REP_Usuario()
        {
            _context = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public async Task<bool> Delete(int id)
        {
            var entity = await _context.TBL_Usuarios.FindAsync(id);
            _context.TBL_Usuarios.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insert(MDL_Usuario item)
        {
            var entity = _mapper.Map<TBL_Usuarios>(item);
            _context.TBL_Usuarios.Add(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<MDL_Usuario> Login(MDL_Login reg)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register(MDL_Usuario reg)
        {
            throw new NotImplementedException();
        }

        public async Task<MDL_Usuario> Select(int id)
        {
            var entity = await _context.TBL_Usuarios.FindAsync(id);
            var output = _mapper.Map<MDL_Usuario>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Usuario>> Select()
        {
            var entity = await _context.TBL_Usuarios.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Usuario>>(entity);
            return output;
        }

        public async Task<bool> Update(int id, MDL_Usuario item)
        {
            throw new NotImplementedException();
        }
    }
}
