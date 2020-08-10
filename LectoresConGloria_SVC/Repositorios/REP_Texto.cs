using AutoMapper;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using LectoresConGloria_SVC.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Texto : IREP_Texto
    {
        readonly LectoresConGloria_Context _context;
        readonly IMapper _mapper;
        public REP_Texto()
        {
            _context = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public async Task<bool> Delete(int id)
        {
            var entity = await _context.TBL_Textos.FindAsync(id);
            _context.TBL_Textos.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insert(MDL_Texto item)
        {
            var entity = _mapper.Map<TBL_Textos>(item);
            _context.TBL_Textos.Add(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<MDL_Texto> Select(int id)
        {
            var entity = await _context.TBL_Textos.FindAsync(id);
            var output = _mapper.Map<MDL_Texto>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Texto>> Select()
        {
            var entity = await _context.TBL_Textos.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Texto>>(entity);
            return output;
        }

        public async Task<bool> Update(int id, MDL_Texto item)
        {
            throw new NotImplementedException();
        }
    }
}
