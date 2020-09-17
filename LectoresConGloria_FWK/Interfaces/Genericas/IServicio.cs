using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface IServicio<TEntity, TKey>
    {
        Task<bool> Post(TEntity reg);
        Task<bool> Delete(TKey id);
        Task<TEntity> Get(TKey id);
        Task<IEnumerable<TEntity>> Get();
        Task<bool> Put(TKey id, TEntity reg);
    }
}
