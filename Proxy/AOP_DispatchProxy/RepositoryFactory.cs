namespace Proxy.AOP_DispatchProxy
{
    public class RepositoryFactory
    {
        public static IRepository<T> Create<T>()
        {
            return LoggerDecorator<IRepository<T>>.Create(new Repository<T>());
        }
    }
}
