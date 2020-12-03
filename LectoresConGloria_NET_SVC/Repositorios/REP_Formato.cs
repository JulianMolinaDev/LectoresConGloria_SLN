using AutoMapper;
using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Formato : ISVC_Formato
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Formato()
        {
            _contexto = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public void Delete(int id)
        {
            var entity = _contexto.TBL_Formatos.Find(id);
            _contexto.TBL_Formatos.Remove(entity);
             _contexto.SaveChanges();
        }

        public MDL_Formato Get(int id)
        {
            var entity = _contexto.TBL_Formatos.Find(id);
            var output = _mapper.Map<MDL_Formato>(entity);
            return output;
        }

        public IEnumerable<MDL_Formato> Get()
        {
            var entity = _contexto.TBL_Formatos.AsNoTracking().ToList();
            var output = _mapper.Map<IEnumerable<MDL_Formato>>(entity);
            return output;
        }

        public V_Lista GetItem(int id)
        {
            var entity = _contexto.TBL_Formatos.Find(id);
            var output = new V_Lista()
            {
                Id = entity.Id,
                Valor = entity.Nombre
            };
            return output;
        }

        public IEnumerable<V_Lista> GetList()
        {
            var output = _contexto.TBL_Formatos.AsNoTracking().Select(x => new V_Lista()
            {
                Id = x.Id,
                Valor = x.Nombre
            });
            return output;
        }

        public void Post(MDL_Formato reg)
        {
            var entity = _mapper.Map<TBL_Formatos>(reg);
            _contexto.TBL_Formatos.Add(entity);
             _contexto.SaveChanges();
        }

        public void Put(int id, MDL_Formato reg)
        {
            var register = _mapper.Map<TBL_Formatos>(reg);
            var entity = _contexto.TBL_Formatos.Find(id);
            entity.Nombre = register.Nombre;
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }
    }
}
