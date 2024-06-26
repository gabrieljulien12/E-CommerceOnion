﻿using Microsoft.Extensions.DependencyInjection;
using OnionAplication.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication
{
    public static class Registration
    {
        public static void AddAplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddTransient<ExceptionMiddlewear>();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
        }
    }
}
