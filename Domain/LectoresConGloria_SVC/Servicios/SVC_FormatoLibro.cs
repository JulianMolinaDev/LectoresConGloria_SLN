using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Enumerados;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LectoresConGloria_SVC.Data;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_FormatoLibro : ISVC_FormatoLibro
    {
        readonly REP_FormatoLibro _repositorio;
        public SVC_FormatoLibro(LectoresConGloria_Context context)
        {
            _repositorio = new REP_FormatoLibro(context);
        }
        public async Task Delete(int id)
        {
            await _repositorio.Delete(id);
        }

        public async Task<IEnumerable<V_Lista>> GetFaltantesFormatosByLibro(int idLibro)
        {
            return await _repositorio.GetFaltantesFormatosByLibro(idLibro);
        }

        public async Task<MDL_FormatoLibro> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_FormatoLibro>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<V_LibroDescarga> GetContenido(int idFormatoLibro)
        {
            return await _repositorio.GetContenido(idFormatoLibro);
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetFormatosByLibro(int idLibro)
        {
            return await _repositorio.GetFormatosByLibro(idLibro);
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetLibrosByFormato(int idFormato)
        {
            return await _repositorio.GetLibrosByFormato(idFormato);
        }

        public async Task Post(MDL_FormatoLibro reg)
        {
            await _repositorio.Post(reg);
        }

        public async Task Put(int id, MDL_FormatoLibro reg)
        {
            await _repositorio.Put(id, reg);
        }

        public async Task<V_Lista> GetLibroAsItem(int idFormatoLibro)
        {
            return await _repositorio.GetLibroAsItem(idFormatoLibro);
        }

        public async Task<V_Lista> GetFormatoAsItem(int idFormatoLibro)
        {
            return await _repositorio.GetFormatoAsItem(idFormatoLibro);
        }

        public async Task CambiarContenido(int idFormatoLibro, string contenido)
        {
            await _repositorio.CambiarContenido(idFormatoLibro, contenido);
        }

        public async Task CambiarFormato(int idFormatoLibro, int idFormato)
        {
            await _repositorio.CambiarFormato(idFormatoLibro, idFormato);
        }

        public async Task<V_AsociacionDetalle> GetAsociacionDetalle(int idFormatoLibro)
        {
            return await _repositorio.GetAsociacionDetalle(idFormatoLibro);
        }
    }
}
