﻿using Autofac;
using Autofac.Integration.Mvc;
using QuestRooms.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuestRooms.UI.App_Start
{
    public class AutoFacConfig
    {
        public static void ConfigureAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            RegisterTypes(builder);
        }
        private static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<RoomsContext>().As<DbContext>();
        }
    }
}