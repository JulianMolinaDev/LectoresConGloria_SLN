﻿using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Mapeo;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Click : ISVC_Click
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Click(LectoresConGloria_Context context)
        {
            _contexto = context;
            _mapper = Automapeo.Instance;
        }

        public void Write(MDL_Click reg)
        {
            var entity = _mapper.Map<TBL_Clicks>(reg);
            _contexto.TBL_Clicks.Add(entity);
            _contexto.SaveChanges();
        }
    }
}
