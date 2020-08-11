using AutoMapper;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using LectoresConGloria_SVC.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Click : IREP_Click
    {
        readonly LectoresConGloria_Context _context;
        readonly IMapper _mapper;
        public REP_Click()
        {
            _context = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        
        public async Task<bool> Write(MDL_Click reg)
        {
            var entity = _mapper.Map<TBL_Clicks>(reg);
            _context.TBL_Clicks.Add(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
