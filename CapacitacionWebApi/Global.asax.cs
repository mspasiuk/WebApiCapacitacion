﻿using CapacitacionWebApi.App_Start;
using CapacitacionWebApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace CapacitacionWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //Init Db
            System.Data.Entity.Database.SetInitializer(new DataSeed());

            Bootstrapper.Run();

        }
    }
}
