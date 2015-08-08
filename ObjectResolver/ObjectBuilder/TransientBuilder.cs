using System;
using RO = ObjectResolver.ResolverObject;

namespace ObjectResolver.ObjectBuilder
{
    class TransientBuilder : IBuilder
    {
        public TInterface Retrieve<TInterface>()
        {
            return RO.ResolveFactory.ResData[typeof(TInterface)].Type == typeof(object) ?
                    (TInterface)RO.ResolveFactory.ResData[typeof(TInterface)].Obj :
                    (TInterface)Activator.CreateInstance(RO.ResolveFactory.ResData[typeof(TInterface)].Type);
        }
    }
}
