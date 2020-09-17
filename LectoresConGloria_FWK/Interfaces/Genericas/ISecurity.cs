using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISecurity<TEntity, TLogin>
    {
        Task<bool> Register(TEntity reg);
        Task<TEntity> Login(TLogin reg);
    }
}
