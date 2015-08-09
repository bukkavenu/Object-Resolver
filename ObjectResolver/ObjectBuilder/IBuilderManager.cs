using System;

namespace ObjectResolver.ObjectBuilder
{
    interface IBuilderManager : IDisposable
    {
        TInterface Retrieve<TInterface>();
    }
}
