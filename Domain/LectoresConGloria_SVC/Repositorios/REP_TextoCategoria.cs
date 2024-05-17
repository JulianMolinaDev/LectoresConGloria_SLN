using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Mapeo;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using System.Linq;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_TextoCategoria : ISVC_TextoCategoria
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_TextoCategoria(LectoresConGloria_Context context)
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

        public async Task<IEnumerable<V_Lista>> GetFaltantesCategoriasPorTexto(int idTexto)
        {
            var output = await _contexto.Set<V_Lista>().FromSqlRaw
                ("EXEC [SCH_LectoresConGloria].SP_FaltantesCategoriasByTexto @idTexto", new SqlParameter("@idTexto", idTexto))
                .ToListAsync();
            return output;
        }

        public async Task<MDL_TextoCategoria> Get(int id)
        {
            var entity = await _contexto.TBL_TextosCategorias.FindAsync(id);
            var output = _mapper.Map<MDL_TextoCategoria>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_TextoCategoria>> Get()
        {
            var entity = await _contexto.TBL_TextosCategorias
                .AsNoTracking()
                .ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_TextoCategoria>>(entity);
            return output;
        }

        public async Task<V_AsociacionDetalle> GetAsociacionDetalle(int id)
        {
            var output = await _contexto.TBL_TextosCategorias
                .Where(x => x.Id == id)
                .Include(x => x.TBL_Categorias)
                .Include(x => x.TBL_Textos)                
                .AsNoTracking()
                .Select(x => new V_AsociacionDetalle()
                {
                    Id = x.Id,
                    DerechaTexto = x.TBL_Categorias.Nombre,
                    Derecha = x.TBL_Categorias.Id,
                    IzquierdaTexto = x.TBL_Textos.Titulo,
                    Izquierda = x.TBL_Textos.Id
                })
                .FirstOrDefaultAsync();
            return output;
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetCategoriaPorTexto(int idTexto)
        {
            var output = _contexto.TBL_TextosCategorias
                .Include(x => x.TBL_Categorias)
                .Where(x => x.IdTexto == idTexto)
                .AsNoTracking()
                .Select(x => new V_ListaRelacion()
                {
                    Id = x.Id,
                    IdForanea = x.IdCategoria,
                    Valor = x.TBL_Categorias.Nombre
                });
            return output;
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetTextoPorCategoria(int idCategoria)
        {
            var output = _contexto.TBL_TextosCategorias
                .Include(x => x.TBL_Textos)
                .Where(x => x.IdCategoria == idCategoria)
                .AsNoTracking()
                .Select(x => new V_ListaRelacion()
                {
                    Id = x.Id,
                    IdForanea = x.IdTexto,
                    Valor = x.TBL_Textos.Titulo
                });
            return output;
        }

        public async Task Post(MDL_TextoCategoria reg)
        {
            var entity = _mapper.Map<TBL_TextosCategorias>(reg);
            _contexto.TBL_TextosCategorias.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task Put(int id, MDL_TextoCategoria reg)
        {
            var convert = _mapper.Map<TBL_TextosCategorias>(reg);
            var entity = await _contexto.TBL_TextosCategorias.FindAsync(id);
            entity.IdCategoria = convert.IdCategoria;
            entity.IdTexto = convert.IdTexto;
            _contexto.Entry(entity).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }
    }
}
