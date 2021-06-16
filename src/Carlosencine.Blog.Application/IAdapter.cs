namespace Carlosencine.Blog.Application
{
    public interface IAdapter<TEntity, TResponse>
    {
        public TResponse Adapt(TEntity input);
    }
}