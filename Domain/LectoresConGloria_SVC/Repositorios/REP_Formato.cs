using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Mapeo;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Formato : ISVC_Formato
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Formato(LectoresConGloria_Context context)
        {
            _contexto = context;
            _mapper = Automapeo.Instance;
        }
        public async Task Delete(int id)
        {
            var entity = await _contexto.TBL_Formatos.FindAsync(id);
            _contexto.TBL_Formatos.Remove(entity);
             await _contexto.SaveChangesAsync();
        }

        public async Task<MDL_Formato> Get(int id)
        {
            var entity = await _contexto.TBL_Formatos.FindAsync(id);
            var output = _mapper.Map<MDL_Formato>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Formato>> Get()
        {
            var entity = await _contexto.TBL_Formatos.AsNoTracking().ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Formato>>(entity);
            return output;
        }

        public async Task<V_Lista> GetItem(int id)
        {
            var entity = await _contexto.TBL_Formatos.FindAsync(id);
            var output = new V_Lista()
            {
                Id = entity.Id,
                Valor = entity.Nombre
            };
            return output;
        }

        public async Task<IEnumerable<V_Lista>> GetList()
        {
            var output = _contexto.TBL_Formatos.AsNoTracking().Select(x => new V_Lista()
            {
                Id = x.Id,
                Valor = x.Nombre
            });
            return output;
        }

        public async Task Post(MDL_Formato reg)
        {
            var entity = _mapper.Map<TBL_Formatos>(reg);
            _contexto.TBL_Formatos.Add(entity);
             await _contexto.SaveChangesAsync();
        }

        public async Task Put(int id, MDL_Formato reg)
        {
            var register = _mapper.Map<TBL_Formatos>(reg);
            var entity = await _contexto.TBL_Formatos.FindAsync(id);
            entity.Nombre = register.Nombre;
            _contexto.Entry(entity).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }
    }
}
