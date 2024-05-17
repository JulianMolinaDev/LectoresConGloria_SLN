using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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
        public async Task Delete(int id)
        {
            var entity = await _contexto.TBL_Lectores.FindAsync(id);
            _contexto.TBL_Lectores.Remove(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task Post(MDL_Lector item)
        {
            var entity = _mapper.Map<TBL_Lectores>(item);
            _contexto.TBL_Lectores.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task<MDL_Lector> Login(MDL_Login reg)
        {
            var entity = await _contexto.TBL_Lectores.FromSqlRaw("", new { reg.Usuario, reg.Password })
                .FirstOrDefaultAsync();
            var output = _mapper.Map<MDL_Lector>(entity);
            return output;
        }

        public async Task Register(MDL_Lector reg)
        {
            await _contexto.Database.ExecuteSqlRawAsync("",
                new { reg.Nombre, reg.Apellidos, reg.Correo, reg.FechaNacimiento, reg.Password });
        }

        public async Task<MDL_Lector> Get(int id)
        {
            var entity = await _contexto.TBL_Lectores.FindAsync(id);
            var output = _mapper.Map<MDL_Lector>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Lector>> Get()
        {
            var entity = await _contexto.TBL_Lectores
                .AsNoTracking()
                .ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Lector>>(entity);
            return output;
        }

        public async Task Put(int id, MDL_Lector item)
        {
            var entity = _mapper.Map<TBL_Lectores>(item);
            _contexto.TBL_Lectores.Update(entity);
            await _contexto.SaveChangesAsync();
        }
    }
}

