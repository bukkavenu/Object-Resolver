using System;
using RO = ObjectResolver.ResolverObject;
using OB = ObjectResolver.ObjectBuilder;
using static ObjectResolver.LifeTimeManager.ResolveCreate;


namespace ObjectResolver.LifeTimeManager
{
    class SingletonFactory : OB.BuilderManager, OB.IBuilderManager, ILifeTimeManager
    {
        public void Add(Type TInterface, Type TImplementor)
        {
            RO.ResolveFactory.ResData[TInterface] = Create(TImplementor, typeof(OB.SingletonBuilder));
        }

        public void Add(Type TInterface, object TImplementor)
        {
            RO.ResolveFactory.ResData[TInterface] = Create(TImplementor, typeof(OB.SingletonBuilder));
        }
    }
}
