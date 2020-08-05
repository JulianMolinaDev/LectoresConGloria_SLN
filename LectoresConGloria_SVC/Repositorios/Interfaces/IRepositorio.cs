using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios.Interfaces
{
    interface IRepositorio<TEntity, TKey>
    {
        Task<bool> Insert(TEntity item);
        Task<bool> Delete(TKey id);
        Task<bool> Update(TKey id, TEntity item);
        Task<TEntity> Select(TKey id);
        Task<IEnumerable<TEntity>> Select();
    }
}
