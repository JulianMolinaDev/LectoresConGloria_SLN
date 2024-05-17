using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using LectoresConGloria_SVC.Data;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Texto : ISVC_Texto
    {
        private readonly REP_Texto _repositorio;
        public SVC_Texto(LectoresConGloria_Context context)
        {
            _repositorio = new REP_Texto(context);
        }
        public async Task Delete(int id)
        {
            await _repositorio.Delete(id);
        }

        public async Task<MDL_Texto> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_Texto>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<V_TextoDetalle> GetDetalle(int id)
        {
            return await _repositorio.GetDetalle(id);
        }

        public async Task<V_Lista> GetItem(int id)
        {
            return await _repositorio.GetItem(id);
        }

        public async Task<IEnumerable<V_Lista>> GetList()
        {
            return await _repositorio.GetList();
        }

        public async Task<IEnumerable<V_TextoLista>> GetListaMasClicks()
        {
            return await _repositorio.GetListaMasClicks();
        }

        public async Task<IEnumerable<V_Lista>> GetListaPorTitulo(string titulo)
        {
            return await _repositorio.GetListaPorTitulo(titulo);
        }

        public async Task<IEnumerable<V_TextoLista>> GetListaUltimos()
        {
            return await _repositorio.GetListaUltimos();
        }

        public async Task<IEnumerable<V_TextoLista>> GetListaUltimosPorFecha(DateTime fecha)
        {
            return await _repositorio.GetListaUltimosPorFecha(fecha);
        }

        public async Task<IEnumerable<MDL_Texto>> GetUltimos(int cantidad)
        {
            return await _repositorio.GetUltimos(cantidad);
        }

        public async Task Post(MDL_Texto reg)
        {
            await _repositorio.Post(reg);
        }

        public async Task Put(int id, MDL_Texto reg)
        {
            await _repositorio.Put(id, reg);
        }
    }
}