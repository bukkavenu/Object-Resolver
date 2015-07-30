using System;
using LM = ObjectResolver.LifeTimeManager;

namespace ObjectResolver.ResolverObject
{
    internal class ResolveCreator
    {
        internal static ResolveObject Create(LM.LifeTime lifeTime, Type ro)
        {
            return new ResolveObject { Lifetime = lifeTime, Obj = ro , Type = ro};
        }

        internal static ResolveObject Create(Type ro)
        {
            return new ResolveObject { Lifetime = LM.LifeTime.Transient, Obj = ro, Type = ro };
        }

        internal static ResolveObject Create(object ro)
        {
            return new ResolveObject { Lifetime = LM.LifeTime.Transient, Obj = ro , Type = typeof(Object) };
        }
    }
}
