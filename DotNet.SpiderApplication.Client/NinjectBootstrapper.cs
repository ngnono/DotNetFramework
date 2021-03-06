﻿// -----------------------------------------------------------------------
// <copyright file="NinjectBootstrapper.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DotNet.SpiderApplication.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using DotNet.IoC;
    using DotNet.SpiderApplication.Contract;
    using DotNet.SpiderApplication.Service;

    using Microsoft.Practices.ServiceLocation;

    using Ninject;

    public class NinjectBootstrapper : CommonBootStrapper
    {
        protected override IServiceLocator CreateServiceLocator()
        {
            return new NinjectServiceLocator(new StandardKernel(new RegisterServiceModule()));
        }
    }

    internal class RegisterServiceModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            //此处注册你的服务
            Bind<IProductDataAccess>().To<ProductDataAccess>();
            Bind<IProductService>().To<ProductService>();
        }
    }
}
