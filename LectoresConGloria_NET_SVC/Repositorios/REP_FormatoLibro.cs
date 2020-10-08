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
using System.Text;
using System.Threading.Tasks;

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
        public async void Delete(int id)
        {
            var entity = _contexto.TBL_FormatosLibros.Find(id);
            _contexto.TBL_FormatosLibros.Remove(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task<MDL_FormatoLibro> Get(int id)
        {
            var entity = await _contexto.TBL_FormatosLibros.FindAsync(id);
            var output = _mapper.Map<MDL_FormatoLibro>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_FormatoLibro>> Get()
        {
            var entity = await _contexto.TBL_FormatosLibros.ToListAsync();
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
                .FirstOrDefault(x => x.Id == idFormatoLibro);
            var output = new V_LibroDescarga()
            {
                Contenido = entity.Contenido,
                Nombre = entity.TBL_Libros.Nombre,
                Tipo = entity.TBL_Formatos.Nombre
            };
            return output;
        }

        /// <summary>
        /// Obtiene los formatos para despues entregar el contenido
        /// </summary>
        /// <param name="idLibro">Id del libro/// </param>
        /// <returns>Lista de formatos disponibles para descargar</returns>
        public IEnumerable<V_Lista> GetFormatosByLibro(int idLibro)
        {
            var output = _contexto.TBL_FormatosLibros
                .Where(x => x.IdLibro == idLibro)
                .Include(x => x.TBL_Formatos)
                .Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.TBL_Formatos.Nombre
                });
            return output;
        }

        public async void Post(MDL_FormatoLibro reg)
        {
            var entity = _mapper.Map<TBL_FormatosLibros>(reg);
            _contexto.TBL_FormatosLibros.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public async void Put(int id, MDL_FormatoLibro reg)
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
