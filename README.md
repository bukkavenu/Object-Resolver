# Object-Resolver
<b><u>v1.0.1(Beta)</b><u/> <br />
Light-weight Dependency Injection for .NET <br />
<!--More features to follow in subsequent releases-->

#How to Use:
Import namespace ObjectResolver.Resolver into source file

    var con = new ResolverContainer();

<b><u>To register a type:</u></b>

    con.Register<Itest,Test>();
    con.Register(typeof(ITest), typeof(Test));

<b><u>To register an Instance:</u></b>

    con.RegisterInstance<ITest>(new Test());
    con.RegisterInstance<ITest>(new Test { A = 20 });

<b><u>To create objects with life-time specific attributes:</u></b>

    con.With<Singleton>().Register<ITest, Test>(); // Injects Singleton Behaviour
    con.With<Singleton>().Register(typeof(ITest), typeof(Test)); //Injects Singleton Behaviour with Types
    
<b><u>Resolve the objects using:</u></b>

    ITest t = con.Resolve<ITest>();

<b><u>Note:</u></b>You could as well use ResolverContainer in a using block

    using (var con = new ResolverContainer())
    {
        con.Register<ITest, Test>();
        ITest t = con.Resolve<ITest>();
        t = con.Resolve<ITest>();
        
        con.RegisterInstance<ITest>(new Test { A = 20 });
        t = con.Resolve<ITest>();
        t = con.Resolve<ITest>();
    }
