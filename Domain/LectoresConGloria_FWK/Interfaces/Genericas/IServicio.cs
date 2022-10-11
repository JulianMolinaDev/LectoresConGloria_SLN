using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface IServicio<TEntity, TKey>
    {
        Task Post(TEntity reg);
        Task Delete(TKey id);
        Task<TEntity> Get(TKey id);
        Task<IEnumerable<TEntity>> Get();
        Task Put(TKey id, TEntity reg);
    }
}
