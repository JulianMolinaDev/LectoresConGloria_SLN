using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface IWriteOnly<TEntity>
    {
        Task Write(TEntity reg);
    }
}
