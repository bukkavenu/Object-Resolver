using System;
using RS = ObjectResolver.Resolver;

namespace ObjectResolver.LifeTimeManager
{
    public static class LifeTimeContainer
    {
        public static void Register<TInterface, TImplementor>(this RS.ResolverContainer rc, LifeTime lifeTime)
        {
            rc.Register(typeof(TInterface), typeof(TImplementor), lifeTime);
        }

        public static void Register(this RS.ResolverContainer rc, Type TInterface, Type TImplementor, LifeTime lifeTime)
        {
            LifeTimeFactory.Add(TInterface, TImplementor, lifeTime);
        }

        public static void RegisterInstance<TInterface>(this RS.ResolverContainer rc, object instance, LifeTime lifeTime)
        {
            LifeTimeFactory.Add(typeof(TInterface), instance, lifeTime);
        }
    }
}
