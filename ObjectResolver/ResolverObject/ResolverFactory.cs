using System;

namespace ObjectResolver.ResolverObject
{
    internal class ResolverFactory
    {

        internal static ResolveData ResData = ResolveData.Instance;

        internal static void Add(Type TInterface, Type TImplementor)
        {
            ResData[TInterface] = ResolveCreator.Create(TImplementor);
        }

        internal static void Add(Type TInterface, object TImplementor)
        {
            ResData[TInterface] = ResolveCreator.Create(TImplementor);
        }

        internal static T Create<T>()
        {
            return Activator.CreateInstance<T>();
        }

        internal static TInterface Retrieve<TInterface>()
        {
            return ResData[typeof(TInterface)].Type == typeof(object) ? 
                (TInterface)ResData[typeof(TInterface)].Obj : 
                (TInterface)Activator.CreateInstance(ResData[typeof(TInterface)].Type);
        }

    }
}
