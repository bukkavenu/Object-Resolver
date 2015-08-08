using System;
using RO = ObjectResolver.ResolverObject;

namespace ObjectResolver.LifeTimeManager
{
    static class ResolveCreate
    {
        internal static RO.ResolveObject Create(Type ro, Type builderType)
        {
            return new RO.ResolveObject { Obj = ro, Type = ro, BuilderType = builderType };
        }

        internal static RO.ResolveObject Create(object ro, Type builderType)
        {
            return new RO.ResolveObject { Obj = ro, Type = typeof(object), BuilderType = builderType };
        }
    }
}
