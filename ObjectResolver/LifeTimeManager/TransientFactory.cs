using System;
using RO = ObjectResolver.ResolverObject;
using OB = ObjectResolver.ObjectBuilder;
using static ObjectResolver.LifeTimeManager.ResolveCreate;

namespace ObjectResolver.LifeTimeManager
{
    class TransientFactory : OB.BuilderManager, ILifeTimeManager
    {
        public void Add(Type TInterface, Type TImplementor)
        {
            RO.ResolveFactory.ResData[TInterface] = Create(TImplementor, typeof(OB.TransientBuilder));
        }

        public void Add(Type TInterface, object TImplementor)
        {
            RO.ResolveFactory.ResData[TInterface] = Create(TImplementor, typeof(OB.TransientBuilder));
        }
    }
}
