using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Interfaces
{
    public interface IWriteOnly<TEntity>
    {
        void Write(TEntity reg);
    }
}
