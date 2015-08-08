using System;
using System.Collections.Generic;
using RO = ObjectResolver.ResolverObject;


namespace ObjectResolver.ObjectBuilder
{
    class SingletonBuilder : IBuilder
    {
        private IDictionary<Type, object> dicSingle = new Dictionary<Type, object>();

        private object this[Type key]
        {
            get
            {
                return dicSingle[key];
            }
        }

        public TInterface Retrieve<TInterface>()
        {
            return (TInterface)Build<TInterface>()[typeof(TInterface)];
        }

        private SingletonBuilder Build<TInterface>()
        {
            if (!dicSingle.ContainsKey(typeof(TInterface)))
            {
                dicSingle.Add(typeof(TInterface), RO.ResolveFactory.ResData[typeof(TInterface)].Type == typeof(object) ?
                    RO.ResolveFactory.ResData[typeof(TInterface)].Obj :
                    Activator.CreateInstance(RO.ResolveFactory.ResData[typeof(TInterface)].Type));
            }
            return this;
        }
    }

}
