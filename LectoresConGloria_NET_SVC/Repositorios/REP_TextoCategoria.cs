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
    class REP_TextoCategoria : ISVC_TextoCategoria
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_TextoCategoria()
        {
            _contexto = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public void Delete(int id)
        {
            var entity = _contexto.TBL_TextosCategorias.Find(id);
            _contexto.TBL_TextosCategorias.Remove(entity);
            _contexto.SaveChanges();
        }

        public IEnumerable<V_Lista> FaltantesCategoriasPorTexto(int idTexto)
        {
            var output = _contexto.Database.SqlQuery<V_Lista>
                ("EXEC [SCH_LectoresConGloria].SP_FaltantesCategoriasByTexto @idTexto", new SqlParameter("@idTexto", idTexto))
                .ToList();
            return output;
        }

        public MDL_TextoCategoria Get(int id)
        {
            var entity = _contexto.TBL_TextosCategorias.Find(id);
            var output = _mapper.Map<MDL_TextoCategoria>(entity);
            return output;
        }

        public IEnumerable<MDL_TextoCategoria> Get()
        {
            var entity = _contexto.TBL_TextosCategorias
                .AsNoTracking()
                .ToList();
            var output = _mapper.Map<IEnumerable<MDL_TextoCategoria>>(entity);
            return output;
        }

        public V_AsociacionDetalle GetAsociacionDetalle(int id)
        {
            var output = _contexto.TBL_TextosCategorias
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
                .FirstOrDefault();
            return output;
        }

        public IEnumerable<V_ListaRelacion> GetCategoriaPorTexto(int idTexto)
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

        public IEnumerable<V_ListaRelacion> GetTextoPorCategoria(int idCategoria)
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

        public void Post(MDL_TextoCategoria reg)
        {
            var entity = _mapper.Map<TBL_TextosCategorias>(reg);
            _contexto.TBL_TextosCategorias.Add(entity);
            _contexto.SaveChanges();
        }

        public void Put(int id, MDL_TextoCategoria reg)
        {
            var convert = _mapper.Map<TBL_TextosCategorias>(reg);
            var entity = _contexto.TBL_TextosCategorias.Find(id);
            entity.IdCategoria = convert.IdCategoria;
            entity.IdTexto = convert.IdTexto;
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }
    }
}
