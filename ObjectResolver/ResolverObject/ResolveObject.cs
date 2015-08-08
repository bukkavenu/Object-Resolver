using System;
using OB = ObjectResolver.ObjectBuilder;

namespace ObjectResolver.ResolverObject
{
    class ResolveObject
    {
        internal string Name { get; set; } = string.Empty;
        internal object Obj { get; set; } = null;
        internal Type Type { get; set; }
        internal Type BuilderType { get; set; } = typeof(OB.TransientBuilder);
    }
}
