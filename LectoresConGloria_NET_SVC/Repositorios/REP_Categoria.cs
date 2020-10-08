using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Categoria : ISVC_Categoria
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Categoria()
        {
            _contexto = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public async void Delete(int id)
        {
            var entity = _contexto.TBL_Categorias.Find(id);
            _contexto.TBL_Categorias.Remove(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task<MDL_Categoria> Get(int id)
        {
            var entity = await _contexto.TBL_Categorias.FindAsync(id);
            var output = _mapper.Map<MDL_Categoria>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Categoria>> Get()
        {
            var entity = await _contexto.TBL_Categorias.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Categoria>>(entity);
            return output;
        }

        public async void Post(MDL_Categoria reg)
        {
            var entity = _mapper.Map<TBL_Categorias>(reg);
            _contexto.TBL_Categorias.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public async void Put(int id, MDL_Categoria reg)
        {
            var origin = _mapper.Map<TBL_Categorias>(reg);
            var entity = _contexto.TBL_Categorias.Find(id);
            entity.Nombre = origin.Nombre;
            _contexto.Entry(entity).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }
    }
}
