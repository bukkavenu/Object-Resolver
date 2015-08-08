namespace ObjectResolver.ObjectBuilder
{
    interface IBuilder
    {
        TInterface Retrieve<TInterface>();
    }
}
