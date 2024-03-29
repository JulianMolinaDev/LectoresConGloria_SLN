﻿using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Texto : ISVC_Texto
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Texto(LectoresConGloria_Context context)
        {
            _contexto = context;
            _mapper = Automapeo.Instance;
        }
        public async Task Delete(int id)
        {
            var entity = await _contexto.TBL_Textos.FindAsync(id);
            _contexto.TBL_Textos.Remove(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task Post(MDL_Texto item)
        {
            var entity = _mapper.Map<TBL_Textos>(item);
            entity.FechaAlta = DateTime.Now;
            _contexto.TBL_Textos.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task<MDL_Texto> Get(int id)
        {
            var entity = await _contexto.TBL_Textos.FindAsync(id);
            var output = _mapper.Map<MDL_Texto>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Texto>> Get()
        {
            var entity = await _contexto.TBL_Textos
                .AsNoTracking()
                .ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Texto>>(entity);
            return output;
        }

        public async Task<IEnumerable<V_TextoLista>> GetListaMasClicks()
        {
            var output = await _contexto.TBL_Textos.OrderByDescending(x => x.FechaAlta)
                .AsNoTracking()
                .Take(5).Select(x => new V_TextoLista()
                {
                    Id = x.Id,
                    Valor = x.Titulo,
                    UrlDescripcion = x.Explicacion
                }).ToListAsync();
            return output;
        }

        public async Task<IEnumerable<V_TextoLista>> GetListaUltimos()
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

        public async Task<IEnumerable<V_TextoLista>> GetListaUltimosPorFecha(DateTime fecha)
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

        public async Task Put(int id, MDL_Texto item)
        {
            var entity = await _contexto.TBL_Textos.FindAsync(id);
            entity.FechaAlta = DateTime.Now;
            entity.Archivo = item.Archivo;
            entity.Audio = item.Audio;
            entity.Explicacion = item.Explicacion;
            entity.Titulo = item.Titulo;
            _contexto.Entry(entity).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }

        public async Task<V_TextoDetalle> GetDetalle(int id)
        {
            var entity = await _contexto.TBL_Textos.FindAsync(id);
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

        public async Task<IEnumerable<V_Lista>> GetList()
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

        public async Task<IEnumerable<V_Lista>> GetListaPorTitulo(string titulo)
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

        public async Task<IEnumerable<MDL_Texto>> GetUltimos(int cantidad)
        {
            var entity = await _contexto.TBL_Textos
                .OrderByDescending(x => x.FechaAlta)
                .AsNoTracking()
                .Take(cantidad)
                .ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Texto>>(entity);
            return output;
        }

        public async Task<V_Lista> GetItem(int id)
        {
            var entity = await _contexto.TBL_Textos.FindAsync(id);
            var output = new V_Lista()
            {
                Id = entity.Id,
                Valor = entity.Titulo
            };
            return output;
        }
    }
}
