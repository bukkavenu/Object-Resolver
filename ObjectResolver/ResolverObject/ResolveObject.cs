using System;
using LM = ObjectResolver.LifeTimeManager;

namespace ObjectResolver.ResolverObject
{
    internal class ResolveObject
    {
        internal string Name { get; set; } = string.Empty;
        internal object Obj { get; set; } = null;
        internal Type Type { get; set; }
        internal LM.LifeTime Lifetime { get; set; } = LM.LifeTime.Transient;
    }
}
