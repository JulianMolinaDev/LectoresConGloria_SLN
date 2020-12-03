using AutoMapper;
using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_FormatoLibro : ISVC_FormatoLibro
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_FormatoLibro()
        {
            _contexto = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }

        public void CambiarContenido(int idFormatoLibro, string contenido)
        {
            var entity = _contexto.TBL_FormatosLibros.Find(idFormatoLibro);
            entity.Archivo = contenido;
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void CambiarFormato(int idFormatoLibro, int idFormato)
        {
            var entity = _contexto.TBL_FormatosLibros.Find(idFormatoLibro);
            entity.IdFormato = idFormato;
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _contexto.TBL_FormatosLibros.Find(id);
            _contexto.TBL_FormatosLibros.Remove(entity);
            _contexto.SaveChanges();
        }

        public IEnumerable<V_Lista> FaltantesFormatosByLibro(int idLibro)
        {
            var output = _contexto.Database.SqlQuery<V_Lista>
                ("SP_FaltantesFormatosByLibro @idLibro", new SqlParameter("@idLibro", idLibro))
                .ToList();
            return output;
        }

        public MDL_FormatoLibro Get(int id)
        {
            var entity = _contexto.TBL_FormatosLibros.Find(id);
            var output = _mapper.Map<MDL_FormatoLibro>(entity);
            return output;
        }

        public IEnumerable<MDL_FormatoLibro> Get()
        {
            var entity = _contexto.TBL_FormatosLibros
                .AsNoTracking()
                .ToList();
            var output = _mapper.Map<IEnumerable<MDL_FormatoLibro>>(entity);
            return output;
        }
        /// <summary>
        /// Obtiene el contenido del archivo que se va a descargar
        /// </summary>
        /// <param name="idFormatoLibro"></param>
        /// <returns></returns>
        public V_LibroDescarga GetContenido(int idFormatoLibro)
        {
            var entity = _contexto.TBL_FormatosLibros
                .Include(x => x.TBL_Libros)
                .Include(x => x.TBL_Formatos)
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == idFormatoLibro);
            var output = new V_LibroDescarga()
            {
                Archivo = entity.Archivo,
                Nombre = entity.TBL_Libros.Nombre,
                Tipo = entity.TBL_Formatos.Nombre
            };
            return output;
        }

        public V_Lista GetFormatoAsItem(int idFormatoLibro)
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
        public IEnumerable<V_ListaRelacion> GetFormatosByLibro(int idLibro)
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

        public V_Lista GetLibroAsItem(int idFormatoLibro)
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

        public IEnumerable<V_ListaRelacion> GetLibrosByFormato(int idFormato)
        {
            var output = _contexto.TBL_FormatosLibros
                .Where(x => x.IdFormato == idFormato)
                .Include(x => x.TBL_Libros)
                .AsNoTracking()
                .Select(x => new V_ListaRelacion()
                {
                    Id = x.Id,
                    IdForanea = x.IdLibro,
                    Valor = x.TBL_Libros.Nombre
                });
            return output;
        }

        public void Post(MDL_FormatoLibro reg)
        {
            var entity = _mapper.Map<TBL_FormatosLibros>(reg);
            _contexto.TBL_FormatosLibros.Add(entity);
            _contexto.SaveChanges();
        }

        public void Put(int id, MDL_FormatoLibro reg)
        {
            var register = _mapper.Map<TBL_FormatosLibros>(reg);
            var entity = _contexto.TBL_FormatosLibros.Find(id);
            entity.IdFormato = register.IdFormato;
            entity.IdLibro = register.IdLibro;
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }
    }
}
