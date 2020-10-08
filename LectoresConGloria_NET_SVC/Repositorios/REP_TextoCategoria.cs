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

        public async Task<MDL_TextoCategoria> Get(int id)
        {
            var entity = await _contexto.TBL_TextosCategorias.FindAsync(id);
            var output = _mapper.Map<MDL_TextoCategoria>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_TextoCategoria>> Get()
        {
            var entity = await _contexto.TBL_TextosCategorias.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_TextoCategoria>>(entity);
            return output;
        }

        public async Task<IEnumerable<V_Lista>> GetCategoriaPorTexto(int idTexto)
        {
            var entity = await _contexto.TBL_TextosCategorias
                .Include(x=> x.TBL_Categorias)
                .Where(x => x.IdTexto == idTexto).ToListAsync();
            var output = entity.Select(x => new V_Lista()
            {
                Id = x.IdCategoria,
                Valor = x.TBL_Categorias.Nombre
            });
            return output;
        }

        public async Task<IEnumerable<V_Lista>> GetTextoPorCategoria(int idCategoria)
        {
            var entity = await _contexto.TBL_TextosCategorias
                .Include(x => x.TBL_Textos)
                .Where(x => x.IdCategoria == idCategoria).ToListAsync();
            var output = entity.Select(x => new V_Lista()
            {
                Id = x.IdTexto,
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
