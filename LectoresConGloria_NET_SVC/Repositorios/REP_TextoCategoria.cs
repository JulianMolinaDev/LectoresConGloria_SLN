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

        public MDL_TextoCategoria Get(int id)
        {
            var entity = _contexto.TBL_TextosCategorias.Find(id);
            var output = _mapper.Map<MDL_TextoCategoria>(entity);
            return output;
        }

        public IEnumerable<MDL_TextoCategoria> Get()
        {
            var entity = _contexto.TBL_TextosCategorias.ToList();
            var output = _mapper.Map<IEnumerable<MDL_TextoCategoria>>(entity);
            return output;
        }

        public IEnumerable<V_ListaRelacion> GetCategoriaPorTexto(int idTexto)
        {
            var output = _contexto.TBL_TextosCategorias
                .Include(x => x.TBL_Categorias)
                .AsNoTracking()
                .Where(x => x.IdTexto == idTexto)
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
