using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_FormatoLibro : ISVC_FormatoLibro
    {
        readonly REP_FormatoLibro _repositorio;
        public SVC_FormatoLibro()
        {
            _repositorio = new REP_FormatoLibro();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public async Task<MDL_FormatoLibro> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_FormatoLibro>> Get()
        {
            return await _repositorio.Get();
        }

        public V_LibroDescarga GetContenido(int idFormatoLibro)
        {
            return _repositorio.GetContenido(idFormatoLibro);
        }

        public IEnumerable<V_Lista> GetFormatosByLibro(int idLibro)
        {
            return _repositorio.GetFormatosByLibro(idLibro);
        }

        public void Post(MDL_FormatoLibro reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_FormatoLibro reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
