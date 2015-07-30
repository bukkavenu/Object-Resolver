using System;
using RO = ObjectResolver.ResolverObject;
using LM = ObjectResolver.LifeTimeManager;

namespace ObjectResolver.LifeTimeManager
{
    internal static class LifeTimeFactory
    {
        internal static void Add(Type TInterface, Type TImplementor, LifeTime lifeTime)
        {
            if (lifeTime == LifeTime.Singleton && RO.ResolverFactory.ResData[TInterface] == null || lifeTime != LifeTime.Singleton)
            {
                RO.ResolverFactory.ResData[TInterface] = LifeTimeCreator.Create(TImplementor, lifeTime);
            }
        }

        internal static void Add(Type type, object instance, LM.LifeTime lifeTime)
        {
            if (lifeTime == LifeTime.Singleton && RO.ResolverFactory.ResData[type] == null || lifeTime != LifeTime.Singleton)
            {
                RO.ResolverFactory.ResData[type] = LifeTimeCreator.Create(instance, lifeTime);
            }
        }
    }
}
