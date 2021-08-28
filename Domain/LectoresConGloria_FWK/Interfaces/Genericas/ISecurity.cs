namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISecurity<TEntity, TLogin>
    {
        void Register(TEntity reg);
        TEntity Login(TLogin reg);
    }
}
