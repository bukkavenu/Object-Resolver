using System;
using OB = ObjectResolver.ObjectBuilder;

namespace ObjectResolver.LifeTimeManager
{
    interface ILifeTimeManager : OB.IBuilderManager
    {
        void Add(Type TInterface, Type TImplementor);
        void Add(Type TInterface, object instance);
    }
}

