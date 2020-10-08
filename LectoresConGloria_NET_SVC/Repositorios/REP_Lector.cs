using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Lector : ISVC_Lector
    {
        readonly LectoresConGloria_Context _context;
        readonly IMapper _mapper;
        public REP_Lector()
        {
            _context = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public async void Delete(int id)
        {
            var entity = await _context.TBL_Lectores.FindAsync(id);
            _context.TBL_Lectores.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async void Post(MDL_Lector item)
        {
            var entity = _mapper.Map<TBL_Lectores>(item);
            _context.TBL_Lectores.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<MDL_Lector> Login(MDL_Login reg)
        {
            var entity = await _context.TBL_Lectores.SqlQuery("", new { reg.Usuario, reg.Password })
                .FirstOrDefaultAsync();
            var output = _mapper.Map<MDL_Lector>(entity);
            return output;
        }

        public async void Register(MDL_Lector reg)
        {
            var output = await _context.Database.ExecuteSqlCommandAsync("",
                new { reg.Nombre, reg.Apellidos, reg.Correo, reg.FechaNacimiento, reg.Password });
        }

        public async Task<MDL_Lector> Get(int id)
        {
            var entity = await _context.TBL_Lectores.FindAsync(id);
            var output = _mapper.Map<MDL_Lector>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Lector>> Get()
        {
            var entity = await _context.TBL_Lectores.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Lector>>(entity);
            return output;
        }

        public async void Put(int id, MDL_Lector item)
        {
            throw new NotImplementedException();
        }
    }
}

