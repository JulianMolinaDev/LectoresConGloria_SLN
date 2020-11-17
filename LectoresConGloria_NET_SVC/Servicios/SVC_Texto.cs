using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Texto : ISVC_Texto
    {
        private readonly REP_Texto _repositorio;
        public SVC_Texto()
        {
            _repositorio = new REP_Texto();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public MDL_Texto Get(int id)
        {
            return _repositorio.Get(id);
        }

        public IEnumerable<MDL_Texto> Get()
        {
            return _repositorio.Get();
        }

        public V_TextoDetalle GetDetalle(int id)
        {
            return _repositorio.GetDetalle(id);
        }

        public IEnumerable<V_Lista> GetList()
        {
            return _repositorio.GetList();
        }

        public IEnumerable<V_Lista> GetMasClicks()
        {
            return _repositorio.GetMasClicks();
        }

        public IEnumerable<V_Lista> GetUltimos()
        {
            return _repositorio.GetUltimos();
        }

        public IEnumerable<V_Lista> GetUltimosPorFecha(DateTime fecha)
        {
            return _repositorio.GetUltimosPorFecha(fecha);
        }

        public void Post(MDL_Texto reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Texto reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}