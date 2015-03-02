namespace Converters.ViewModels.Base
{
    using Autofac;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

public class ViewModelLocator
{
    IContainer container;

    public ViewModelLocator()
    {
        ContainerBuilder builder = new ContainerBuilder();

        builder.RegisterType<MainViewModel>();

        this.container = builder.Build();
    }

    public MainViewModel MainVM
    {
        get { return this.container.Resolve<MainViewModel>(); }
    }
}
}
