using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_TextoLibro : ISVC_TextoLibro
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_TextoLibro(LectoresConGloria_Context context)
        {
            _contexto = context;
            _mapper = Automapeo.Instance;
        }
        public async Task Delete(int id)
        {
            var entity = await _contexto.TBL_TextosCategorias.FindAsync(id);
            _contexto.TBL_TextosCategorias.Remove(entity);
            await _contexto.SaveChangesAsync();
        }
        public async Task<MDL_TextoLibro> Get(int id)
        {
            var entity = await _contexto.TBL_TextosLibros.FindAsync(id);
            var output = _mapper.Map<MDL_TextoLibro>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_TextoLibro>> Get()
        {
            var entity = await _contexto.TBL_TextosLibros.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_TextoLibro>>(entity);
            return output;
        }

        public async Task<V_AsociacionDetalle> GetAsociacionDetalle(int id)
        {
            var output = _contexto.TBL_TextosLibros
               .Where(x => x.Id == id)
               .Include(x => x.TBL_Textos)
               .Include(x => x.TBL_Libros)
               .AsNoTracking()
               .Select(x => new V_AsociacionDetalle()
               {
                   Id = x.Id,
                   Izquierda = x.TBL_Textos.Id,
                   IzquierdaTexto = x.TBL_Textos.Titulo,
                   Derecha = x.TBL_Libros.Id,
                   DerechaTexto = x.TBL_Libros.Nombre
               })
               .FirstOrDefault();
            return output;
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetTextosPorLibro(int idLibro)
        {
            var output = _contexto.TBL_TextosLibros
                .Where(x => x.IdLibro == idLibro)
                .Include(x => x.TBL_Textos)
                .AsNoTracking()
                .Select(x => new V_ListaRelacion()
                {
                    Id = x.Id,
                    IdForanea = x.IdTexto,
                    Valor = x.TBL_Textos.Titulo
                });
            return output;
        }

        public async Task Post(MDL_TextoLibro reg)
        {
            var entity = _mapper.Map<TBL_TextosLibros>(reg);
            _contexto.TBL_TextosLibros.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task Put(int id, MDL_TextoLibro reg)
        {
            throw new NotImplementedException();
        }

        public async Task TextoDesdeLibro(int idLibro, MDL_Texto texto)
        {
            var entity = _mapper.Map<TBL_Textos>(texto);
            entity.FechaAlta = DateTime.Now;
            _contexto.TBL_Textos.Add(entity);
            _contexto.TBL_TextosLibros.Add(new TBL_TextosLibros()
            {
                IdLibro = idLibro,
                IdTexto = entity.Id

            });
            await _contexto.SaveChangesAsync();
        }
    }
}
