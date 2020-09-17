using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface IWriteOnly<TEntity>
    {
        Task<bool> Write(TEntity reg);
    }
}
