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
    class REP_FormatoLibro : ISVC_FormatoLibro
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_FormatoLibro(LectoresConGloria_Context context)
        {
            _contexto = context;
            _mapper = Automapeo.Instance;
        }

        public async Task CambiarContenido(int idFormatoLibro, string contenido)
        {
            var entity = await _contexto.TBL_FormatosLibros.FindAsync(idFormatoLibro);
            entity.Archivo = contenido;
            _contexto.Entry(entity).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }

        public async Task CambiarFormato(int idFormatoLibro, int idFormato)
        {
            var entity = await _contexto.TBL_FormatosLibros.FindAsync(idFormatoLibro);
            entity.IdFormato = idFormato;
            _contexto.Entry(entity).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _contexto.TBL_FormatosLibros.FindAsync(id);
            _contexto.TBL_FormatosLibros.Remove(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task<IEnumerable<V_Lista>> GetFaltantesFormatosByLibro(int idLibro)
        {
            var output = await _contexto.Set<V_Lista>().FromSqlRaw
                ("EXEC [SCH_LectoresConGloria].[SP_FaltantesFormatosByLibro] @idLibro", new SqlParameter("@idLibro", idLibro))
                .ToListAsync();
            return output;
        }

        public async Task<MDL_FormatoLibro> Get(int id)
        {
            var entity = await _contexto.TBL_FormatosLibros.FindAsync(id);
            var output = _mapper.Map<MDL_FormatoLibro>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_FormatoLibro>> Get()
        {
            var entity = await _contexto.TBL_FormatosLibros
                .AsNoTracking()
                .ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_FormatoLibro>>(entity);
            return output;
        }

        public async Task<V_AsociacionDetalle> GetAsociacionDetalle(int idFormatoLibro)
        {
            var output = _contexto.TBL_FormatosLibros
                .Where(x => x.Id == idFormatoLibro)
                .Include(x => x.TBL_Libros)
                .Include(x => x.TBL_Formatos)
                .AsNoTracking()
                .Select(i => new V_AsociacionDetalle()
                {
                    Id = i.Id,
                    DerechaTexto = i.TBL_Libros.Nombre,
                    Derecha = i.TBL_Libros.Id,
                    IzquierdaTexto = i.TBL_Formatos.Nombre,
                    Izquierda = i.TBL_Formatos.Id
                })
                .FirstOrDefault();
            return output;
        }

        /// <summary>
        /// Obtiene el contenido del archivo que se va a descargar
        /// </summary>
        /// <param name="idFormatoLibro"></param>
        /// <returns></returns>
        public async Task<V_LibroDescarga> GetContenido(int idFormatoLibro)
        {
            var entity = await _contexto.TBL_FormatosLibros
                .Include(x => x.TBL_Libros)
                .Include(x => x.TBL_Formatos)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == idFormatoLibro);
            var output = new V_LibroDescarga()
            {
                Archivo = entity.Archivo,
                Nombre = entity.TBL_Libros.Nombre,
                Tipo = entity.TBL_Formatos.Nombre
            };
            return output;
        }

        public async Task<V_Lista> GetFormatoAsItem(int idFormatoLibro)
        {
            var output = _contexto.TBL_FormatosLibros
                .Where(x => x.Id == idFormatoLibro)
                .Include(x => x.TBL_Formatos)
                .AsNoTracking()
                .Select(x => new V_Lista()
                {
                    Id = x.IdFormato,
                    Valor = x.TBL_Formatos.Nombre
                }).FirstOrDefault();

            return output;
        }

        /// <summary>
        /// Obtiene los formatos para despues entregar el contenido
        /// </summary>
        /// <param name="idLibro">Id del libro/// </param>
        /// <returns>Lista de formatos disponibles para descargar</returns>
        public async Task<IEnumerable<V_ListaRelacion>> GetFormatosByLibro(int idLibro)
        {

            var output = _contexto.TBL_FormatosLibros
                .Where(x => x.IdLibro == idLibro)
                .Include(x => x.TBL_Formatos)
                .AsNoTracking()
                .Select(x => new V_ListaRelacion()
                {
                    Id = x.Id,
                    IdForanea = x.IdFormato,
                    Valor = x.TBL_Formatos.Nombre
                });
            return output;

        }

        public async Task<V_Lista> GetLibroAsItem(int idFormatoLibro)
        {
            var output = _contexto.TBL_FormatosLibros
                .Where(x => x.Id == idFormatoLibro)
                .Include(x => x.TBL_Libros)
                .AsNoTracking()
                .Select(x => new V_Lista()
                {
                    Id = x.IdLibro,
                    Valor = x.TBL_Libros.Nombre
                }).FirstOrDefault();

            return output;
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetLibrosByFormato(int idFormato)
        {
            var output = _contexto.TBL_FormatosLibros
                .Where(x => x.IdFormato == idFormato)
                .Include(x => x.TBL_Libros)
                .AsNoTracking()
                .Select(x => new V_ListaRelacion()
                {
                    Id = x.Id,
                    IdForanea = x.TBL_Libros.Id,
                    Valor = x.TBL_Libros.Nombre
                });
            return output;
        }

        public async Task Post(MDL_FormatoLibro reg)
        {
            var entity = _mapper.Map<TBL_FormatosLibros>(reg);
            _contexto.TBL_FormatosLibros.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task Put(int id, MDL_FormatoLibro reg)
        {
            var register = _mapper.Map<TBL_FormatosLibros>(reg);
            var entity = await _contexto.TBL_FormatosLibros.FindAsync(id);
            entity.IdFormato = register.IdFormato;
            entity.IdLibro = register.IdLibro;
            _contexto.Entry(entity).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }
    }
}
