# Object-Resolver
<b><u>v1.0.0(Beta)</b><u/> <br />
Light-weight Dependency Injection for .NET <br />
More features to follow in subsequent releases

#How to Use:
Import namespace ObjectResolver.Resolver, ObjectResolver.Resolver.LifeTimeManager into source file

    var con = new ResolverContainer();

<b><u>To register a type:</u></b>

    con.Register<Itest,Test>();
    con.Register<Itest,Test>(LifeTime.Singleton); // Injects singleton behaviour

<b><u>To register an Instance:</u></b>

    con.RegisterInstance<ITest>(new Test());
    con.RegisterInstance<ITest>(new Test(20), LifeTime.Singleton); // Injects singleton behaviour

<b><u>Resolve the objects using:</u></b>

    ITest t = con.Resolve<ITest>();

<b><u>Note:</u></b>You could as well use ResolverContainer in a using block

    using (var con = new ResolverContainer())
    {
        con.Register<ITest, Test>();
        ITest t = con.Resolve<ITest>();
        con.RegisterInstance<ITest>(new Test(20));
        t = con.Resolve<ITest>();
        con.Register<ITest, Test>(LifeTime.Singleton);
        t = con.Resolve<ITest>();
        con.RegisterInstance<ITest>(new Test(20), LifeTime.Singleton);
        t = con.Resolve<ITest>();
        t = con.Resolve<ITest>();
    }
