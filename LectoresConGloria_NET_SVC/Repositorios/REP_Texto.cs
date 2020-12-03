using AutoMapper;
using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Texto : ISVC_Texto
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Texto()
        {
            _contexto = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public void Delete(int id)
        {
            var entity = _contexto.TBL_Textos.Find(id);
            _contexto.TBL_Textos.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Post(MDL_Texto item)
        {
            var entity = _mapper.Map<TBL_Textos>(item);
            _contexto.TBL_Textos.Add(entity);
            _contexto.SaveChanges();
        }

        public MDL_Texto Get(int id)
        {
            var entity = _contexto.TBL_Textos.Find(id);
            var output = _mapper.Map<MDL_Texto>(entity);
            return output;
        }

        public IEnumerable<MDL_Texto> Get()
        {
            var entity = _contexto.TBL_Textos
                .AsNoTracking()
                .ToList();
            var output = _mapper.Map<IEnumerable<MDL_Texto>>(entity);
            return output;
        }

        public IEnumerable<V_TextoLista> GetListaMasClicks()
        {
            var output = _contexto.TBL_Textos.OrderByDescending(x => x.FechaAlta)
                .AsNoTracking()
                .Take(5).Select(x => new V_TextoLista()
                {
                    Id = x.Id,
                    Valor = x.Titulo,
                    UrlDescripcion = x.Explicacion
                }).ToList();
            return output;
        }

        public IEnumerable<V_TextoLista> GetListaUltimos()
        {
            var output = _contexto.TBL_Textos
                .OrderByDescending(x => x.FechaAlta)
                .AsNoTracking()
                .Take(5).Select(x => new V_TextoLista()
                {
                    Id = x.Id,
                    Valor = x.Titulo,
                    UrlDescripcion = x.Explicacion
                });
            return output;
        }

        public IEnumerable<V_TextoLista> GetListaUltimosPorFecha(DateTime fecha)
        {
            var output = _contexto.TBL_Textos.Where(x => x.FechaAlta >= fecha)
                .AsNoTracking()
                .Take(5).Select(x => new V_TextoLista()
                {
                    Id = x.Id,
                    Valor = x.Titulo,
                    UrlDescripcion = x.Explicacion
                });
            return output;
        }

        public void Put(int id, MDL_Texto item)
        {
            var entity = _contexto.TBL_Textos.Find(id);
            item.FechaAlta = DateTime.Now;
            entity.FechaAlta = DateTime.Now;
            entity.Archivo = item.Archivo;
            entity.Audio = item.Audio;
            entity.Explicacion = item.Explicacion;
            entity.Titulo = item.Titulo;
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public V_TextoDetalle GetDetalle(int id)
        {
            var entity = _contexto.TBL_Textos.Find(id);
            var output = new V_TextoDetalle()
            {
                Audio = !string.IsNullOrEmpty(entity.Audio),
                Explicacion = !string.IsNullOrEmpty(entity.Explicacion),
                Texto = !string.IsNullOrEmpty(entity.Archivo),
                Titulo = entity.Titulo,
                Id = entity.Id
            };
            return output;
        }

        public IEnumerable<V_Lista> GetList()
        {
            var output = _contexto.TBL_Textos
                .AsNoTracking()
                .Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.Titulo
                });
            return output;
        }

        public IEnumerable<V_Lista> GetListaPorTitulo(string titulo)
        {
            var output = _contexto.TBL_Textos.Where(x => x.Titulo.Contains(titulo))
               .AsNoTracking()
               .Select(x => new V_Lista()
               {
                   Id = x.Id,
                   Valor = x.Titulo
               });
            return output;
        }

        public IEnumerable<MDL_Texto> GetUltimos(int cantidad)
        {
            var entity = _contexto.TBL_Textos
                .OrderByDescending(x => x.FechaAlta)
                .AsNoTracking()
                .Take(cantidad)
                .ToList();
            var output = _mapper.Map<IEnumerable<MDL_Texto>>(entity);
            return output;
        }

        public V_Lista GetItem(int id)
        {
            var entity = _contexto.TBL_Textos.Find(id);
            var output = new V_Lista()
            {
                Id = entity.Id,
                Valor = entity.Titulo
            };
            return output;
        }
    }
}
