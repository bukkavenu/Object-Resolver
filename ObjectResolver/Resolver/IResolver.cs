using System;

namespace ObjectResolver.Resolver
{
    interface IResolver : IDisposable
    {
        void Register<TInterface, TImplementor>();
        void Register(Type tInterface, Type tImplementor);
        void RegisterInstance<TInterface>(object instance);
        TInterface Resolve<TInterface>();
        TInterface Resolve<TInterface>(Action<TInterface> act);
    }
}
