using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface IWriteOnly<TEntity>
    {
        void Write(TEntity reg);
    }
}
