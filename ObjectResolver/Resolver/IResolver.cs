using System;

namespace ObjectResolver.Resolver
{
    public interface IResolver : IWithLifeTimeResolver
    {
        void RegisterInstance<TInterface>(object instance);
        TInterface Resolve<TInterface>();
        TInterface Resolve<TInterface>(Action<TInterface> act);
    }
}
