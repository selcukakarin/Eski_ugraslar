﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;


[assembly: OwinStartup(typeof(ChatApp.Startup))] 
namespace ChatApp
{
    public class Startup
    { 
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
         
    }
}