using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Usuario : ISVC_Usuario
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Usuario()
        {
            _contexto = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public void Delete(int id)
        {
            var entity = _contexto.TBL_Usuarios.Find(id);
            _contexto.TBL_Usuarios.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Post(MDL_Usuario item)
        {
            var entity = _mapper.Map<TBL_Usuarios>(item);
            _contexto.TBL_Usuarios.Add(entity);
            _contexto.SaveChanges();
        }

        public MDL_Usuario Login(MDL_Login reg)
        {
            var entity = _contexto.TBL_Usuarios.SqlQuery("", new { reg.Usuario, reg.Password })
                .FirstOrDefaultAsync();
            var output = _mapper.Map<MDL_Usuario>(entity);
            return output;
        }

        public void Register(MDL_Usuario reg)
        {
            _contexto.Database.ExecuteSqlCommand("",
                new { reg.Nombre, reg.Apellidos, reg.Correo, reg.FechaNacimiento, reg.Password });
        }

        public MDL_Usuario Get(int id)
        {
            var entity = _contexto.TBL_Usuarios.Find(id);
            var output = _mapper.Map<MDL_Usuario>(entity);
            return output;
        }

        public IEnumerable<MDL_Usuario> Get()
        {
            var entity = _contexto.TBL_Usuarios.ToList();
            var output = _mapper.Map<IEnumerable<MDL_Usuario>>(entity);
            return output;
        }

        public void Put(int id, MDL_Usuario item)
        {
            throw new NotImplementedException();
        }
    }
}
