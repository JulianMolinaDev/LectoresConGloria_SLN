using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Texto : ISVC_Texto
    {
        readonly LectoresConGloria_Context _context;
        readonly IMapper _mapper;
        public REP_Texto()
        {
            _context = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public async void Delete(int id)
        {
            var entity = await _context.TBL_Textos.FindAsync(id);
            _context.TBL_Textos.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async void Post(MDL_Texto item)
        {
            var entity = _mapper.Map<TBL_Textos>(item);
            _context.TBL_Textos.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<MDL_Texto> Get(int id)
        {
            var entity = await _context.TBL_Textos.FindAsync(id);
            var output = _mapper.Map<MDL_Texto>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Texto>> Get()
        {
            var entity = await _context.TBL_Textos.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Texto>>(entity);
            return output;
        }

        public async Task<IEnumerable<V_Lista>> GetMasClicks()
        {
            var output = await _context.TBL_Textos.OrderByDescending(x => x.FechaAlta)
                .Take(5).Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.Titulo
                }).ToListAsync();
            return output;
        }

        public async Task<IEnumerable<V_Lista>> GetUltimos()
        {
            var output = await _context.TBL_Textos.OrderByDescending(x => x.FechaAlta)
                .Take(5).Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.Titulo
                }).ToListAsync();
            return output;
        }

        public async Task<IEnumerable<V_Lista>> GetUltimosPorFecha(DateTime fecha)
        {
            var output = await _context.TBL_Textos.Where(x => x.FechaAlta >= fecha)
                .Take(5).Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.Titulo
                }).ToListAsync();
            return output;
        }

        public async void Put(int id, MDL_Texto item)
        {
            throw new NotImplementedException();
        }

        public async Task<V_TextoDetalle> GetDetalle(int id)
        {
            var entity = await _context.TBL_Textos.FindAsync(id);
            var output = new V_TextoDetalle()
            {
                Audio = !string.IsNullOrEmpty(entity.Audio),
                Explicacion = !string.IsNullOrEmpty(entity.Explicacion),
                Texto = !string.IsNullOrEmpty(entity.Archivo),
                Titulo = entity.Titulo,
                Id = entity.Id
            };
            return output;
        }
    }
}
