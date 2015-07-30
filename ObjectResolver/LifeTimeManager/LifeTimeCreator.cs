using System;
using RO = ObjectResolver.ResolverObject;

namespace ObjectResolver.LifeTimeManager
{
    internal static class LifeTimeCreator
    {
        internal static RO.ResolveObject Create(Type ro, LifeTime lifeTime)
        {
            return new RO.ResolveObject { Lifetime = lifeTime, Obj = ro, Type = ro };
        }
        internal static RO.ResolveObject Create(object ro, LifeTime lifeTime)
        {
            return new RO.ResolveObject { Lifetime = lifeTime, Obj = ro, Type = typeof(object) };
        }

        internal static RO.ResolveObject Create(Type ro)
        {
            return new RO.ResolveObject { Obj = ro, Type = ro };
        }
    }
}
