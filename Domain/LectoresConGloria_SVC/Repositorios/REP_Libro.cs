using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Mapeo;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Libro : ISVC_Libro
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Libro(LectoresConGloria_Context context)
        {
            _contexto = context;
            _mapper = Automapeo.Instance;
        }
        public void Delete(int id)
        {
            var entity = _contexto.TBL_Libros.Find(id);
            _contexto.TBL_Libros.Remove(entity);
            _contexto.SaveChanges();
        }

        public MDL_Libro Get(int id)
        {
            var entity = _contexto.TBL_Libros.Find(id);
            var output = _mapper.Map<MDL_Libro>(entity);
            return output;
        }

        public IEnumerable<MDL_Libro> Get()
        {
            var entity = _contexto.TBL_Libros
                .AsNoTracking()
                .ToList();
            var output = _mapper.Map<IEnumerable<MDL_Libro>>(entity);
            return output;
        }

        public V_Lista GetItem(int id)
        {
            var entity = _contexto.TBL_Libros.Find(id);
            var output = new V_Lista()
            {
                Id = entity.Id,
                Valor = entity.Nombre
            };
            return output;
        }

        public IEnumerable<V_Lista> GetList()
        {
            var output = _contexto.TBL_Libros
                .AsNoTracking()
                .Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.Nombre
                });
            return output;
        }

        public IEnumerable<V_Lista> GetListaUltimos(int cantidad)
        {
            var output = _contexto.TBL_Libros
                .OrderByDescending(f => f.Id)
                .Take(cantidad)
                .AsNoTracking()
                .Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.Nombre
                });
            return output;
        }

        public IEnumerable<V_Lista> GetListByNombre(string nombre)
        {
            var output = _contexto.TBL_Libros.Where(f => f.Nombre.Contains(nombre))
                .AsNoTracking()
                .Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.Nombre
                });
            return output;
        }

        public void Post(MDL_Libro reg)
        {
            var entity = _mapper.Map<TBL_Libros>(reg);
            _contexto.TBL_Libros.Add(entity);
            _contexto.SaveChanges();
        }

        public void Put(int id, MDL_Libro reg)
        {
            var register = _mapper.Map<TBL_Libros>(reg);
            var entity = _contexto.TBL_Libros.Find(id);
            entity.Nombre = register.Nombre;
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }
    }
}
