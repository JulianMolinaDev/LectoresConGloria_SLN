using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface IServicio<TEntity, TKey>
    {
        void Post(TEntity reg);
        void Delete(TKey id);
        TEntity Get(TKey id);
        IEnumerable<TEntity> Get();
        void Put(TKey id, TEntity reg);
    }
}
