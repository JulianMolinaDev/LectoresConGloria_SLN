using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Mapeo;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Categoria : ISVC_Categoria
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Categoria(LectoresConGloria_Context context)
        {
            _contexto = context;
            _mapper = Automapeo.Instance;
        }
        public async Task Delete(int id)
        {
            var entity = await _contexto.TBL_Categorias.FindAsync(id);
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
            var entity = await _contexto.TBL_Categorias.AsNoTracking().ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Categoria>>(entity);
            return output;
        }

        public async Task<V_Lista> GetItem(int id)
        {
            var entity = await _contexto.TBL_Categorias.FindAsync(id);
            var output = new V_Lista()
            {
                Id = entity.Id,
                Valor = entity.Nombre
            };
            return output;
        }

        public async Task<IEnumerable<V_Lista>> GetList()
        {
            var output = _contexto.TBL_Categorias.AsNoTracking().Select(x => new V_Lista()
            {
                Id = x.Id,
                Valor = x.Nombre
            });
            return output;
        }

        public async Task Post(MDL_Categoria reg)
        {
            var entity = _mapper.Map<TBL_Categorias>(reg);
            _contexto.TBL_Categorias.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task Put(int id, MDL_Categoria reg)
        {
            var origin = _mapper.Map<TBL_Categorias>(reg);
            var entity = await _contexto.TBL_Categorias.FindAsync(id);
            entity.Nombre = origin.Nombre;
            _contexto.Entry(entity).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }
    }
}
