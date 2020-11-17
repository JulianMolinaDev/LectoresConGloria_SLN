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
using System.Threading.Tasks;

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
            var entity = _contexto.TBL_Textos.ToList();
            var output = _mapper.Map<IEnumerable<MDL_Texto>>(entity);
            return output;
        }

        public IEnumerable<V_Lista> GetMasClicks()
        {
            var output =  _contexto.TBL_Textos.OrderByDescending(x => x.FechaAlta)
                .AsNoTracking()
                .Take(5).Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.Titulo
                }).ToList();
            return output;
        }

        public IEnumerable<V_Lista> GetUltimos()
        {
            var output =  _contexto.TBL_Textos
                .OrderByDescending(x => x.FechaAlta)
                .AsNoTracking()
                .Take(5).Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.Titulo
                });
            return output;
        }

        public IEnumerable<V_Lista> GetUltimosPorFecha(DateTime fecha)
        {
            var output =  _contexto.TBL_Textos.Where(x => x.FechaAlta >= fecha)
                .AsNoTracking()
                .Take(5).Select(x => new V_Lista()
                {
                    Id = x.Id,
                    Valor = x.Titulo
                });
            return output;
        }

        public void Put(int id, MDL_Texto item)
        {
            throw new NotImplementedException();
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
            var output = _contexto.TBL_Textos.Select(x => new V_Lista()
            {
                Id = x.Id,
                Valor = x.Titulo
            });
            return output;
        }
    }
}
