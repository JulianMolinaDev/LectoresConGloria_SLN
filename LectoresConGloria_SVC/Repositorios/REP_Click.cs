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
        public async Task<bool> Delete(int id)
        {
            var entity = await _context.TBL_Clicks.FindAsync(id);
            _context.TBL_Clicks.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insert(MDL_Click item)
        {
            var entity = _mapper.Map<TBL_Clicks>(item);
            _context.TBL_Clicks.Add(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<MDL_Click> Select(int id)
        {
            var entity = await _context.TBL_Clicks.FindAsync(id);
            var output = _mapper.Map<MDL_Click>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Click>> Select()
        {
            var entity = await _context.TBL_Clicks.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Click>>(entity);
            return output;
        }

        public async Task<bool> Update(int id, MDL_Click item)
        {
            throw new NotImplementedException();
        }
    }
}
