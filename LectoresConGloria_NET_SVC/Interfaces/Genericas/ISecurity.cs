namespace LectoresConGloria_SVC.Interfaces
{
    public interface ISecurity<TEntity, TLogin>
    {
        void Register(TEntity reg);
        TEntity Login(TLogin reg);
    }
}
