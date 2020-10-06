using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface IServicio<TEntity, TKey>
    {
        void Post(TEntity reg);
        void Delete(TKey id);
        Task<TEntity> Get(TKey id);
        Task<IEnumerable<TEntity>> Get();
        void Put(TKey id, TEntity reg);
    }
}
