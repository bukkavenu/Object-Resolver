using System;

namespace ObjectResolver.Resolver
{
    public interface IWithLifeTimeResolver : IDisposable
    {
        void Register<TInterface, TImplementor>();
        void Register(Type tInterface, Type tImplementor);
    }
}
